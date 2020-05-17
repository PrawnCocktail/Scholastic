using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Scholastic
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(0);
            Console.ReadKey();
        }

        static void Run(int startNum)
        {
            using (var client = new WebClient())
            {
                Console.WriteLine("Fetching results from #" + startNum);

                string json = client.DownloadString("https://teachables.scholastic.com/bin/scholastic/teachers/ecommerce/common-search.json?appType=teachables&isSSO=false&rows=120&siteID=teachables-ecomm-data&sort=ProductStartDate_dt_desc&start=" + startNum);

                Json searchResults = JsonConvert.DeserializeObject<Json>(json);

                if (searchResults.solrDocumentList.Count != 0)
                {
                    foreach (var item in searchResults.solrDocumentList)
                    {
                        Directory.CreateDirectory("Downloads/" + item.CustomGrade_s);
                        
                        //dump all results to file
                        //File.WriteAllText(startNum + ".json", JsonConvert.SerializeObject(searchResults.solrDocumentList));

                        //og dl path
                        string path = item.PdpDoc_s;

                        //file type
                        string fileType = "." + item.FileFormat_s;

                        //gen filename
                        string filename = Path.GetFileName(item.PdpDoc_s).Replace(fileType, "") + " - " + item.title_tsi;

                        //make filename safe
                        filename = String.Join("", filename.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');

                        //gen path
                        //filename = "Downloads/" + item.CustomGrade_s + "/" + filename;
                        string downloadPath = "Downloads/" + item.CustomGrade_s + "/";

                        //set new path
                        item.PdpDoc_s = downloadPath + filename + fileType;

                        if (!File.Exists(downloadPath + filename + fileType))
                        {
                            try
                            {
                                //download to grade folder
                                client.Headers.Add("Referer", "https://teachables.scholastic.com/teachables/books/");
                                client.DownloadFile("https://teachables.scholastic.com" + path, downloadPath + filename + fileType);

                                //dump individual json info
                                File.WriteAllText(downloadPath + filename + ".json", JsonConvert.SerializeObject(item));

                                Console.WriteLine("Downloaded: " + item.title_tsi);

                            }
                            catch (WebException)
                            {
                                Directory.CreateDirectory("ERRORS/" + item.CustomGrade_s);
                                //dump individual json info
                                item.PdpDoc_s = path;
                                File.WriteAllText("ERRORS/" + item.CustomGrade_s + "/" + filename + ".json", JsonConvert.SerializeObject(item));
                                Console.WriteLine("Download failed: " + item.title_tsi + ". check errors folder");

                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("File: " + item.title_tsi + " exists, Skipping");
                        }
                    }

                    Run(startNum + 120);
                }
                else
                {
                    Console.WriteLine("Finished");
                }
            }
        }
    }
}
