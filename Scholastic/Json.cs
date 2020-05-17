using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholastic
{
    public class SolrDocumentList
    {
        public string id { get; set; }
        public string child_doc { get; set; }
        public List<string> isbn13_tchable_ngram { get; set; }
        public string site_id_s { get; set; }
        public string ISBN13_s { get; set; }
        public List<string> tchecomm_dym { get; set; }
        public string PrintableType_tsi { get; set; }
        public string PrintableType_s { get; set; }
        public string NumberofSeeInsidePages_s { get; set; }
        public string CollateralType_tsi { get; set; }
        public List<string> text_fs { get; set; }
        public string CollateralType_s { get; set; }
        public string BadgeType_s { get; set; }
        public string PdpDoc_s { get; set; }
        public string LowGrade_tsi { get; set; }
        public string LowGrade_s { get; set; }
        public List<string> Grade_ss { get; set; }
        public List<double> Grade_fs { get; set; }
        public double LowGrade_f { get; set; }
        public List<string> Grade_tsim { get; set; }
        public string TchSubject_tsi { get; set; }
        public List<string> title_auto_print { get; set; }
        public string TchSubject_s { get; set; }
        public List<string> TchSubject_tsim { get; set; }
        public string FreeFlag_s { get; set; }
        public string CommonCoreList_s { get; set; }
        public List<string> CommonCoreList_tsim { get; set; }
        public string SmallImage_s { get; set; }
        public string ExtraSmallImage_s { get; set; }
        public string FileFormat_s { get; set; }
        public string BusinessUnit_tsi { get; set; }
        public string BusinessUnit_s { get; set; }
        public string CommonCoreAlignmentIDs_tsi { get; set; }
        public string CommonCoreAlignmentIDs_s { get; set; }
        public List<string> CommonCoreAlignmentIDs_tsim { get; set; }
        public List<string> CommonCoreAlignmentIDs_dot { get; set; }
        public List<string> CommonCoreAlignmentIDs_ss { get; set; }
        public string TSOISBN_s { get; set; }
        public string LargeImage_s { get; set; }
        public string ExtraLargeImage_s { get; set; }
        public string Subject_tsi { get; set; }
        public string Subject_s { get; set; }

        [DefaultValue("Grade Missing")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
        public string CustomGrade_s { get; set; }

        public string ISBN_s { get; set; }
        public string OurPrice_s { get; set; }
        public double OurPrice_f { get; set; }
        public string Pages_s { get; set; }
        public List<string> New_Shops_ss { get; set; }
        public string Shops_tsi { get; set; }
        public string Shops_s { get; set; }
        public List<string> Shops_tsim { get; set; }
        public List<string> Shops_ss { get; set; }
        public string title_tsi { get; set; }
        public List<string> parent_dym { get; set; }
        public List<string> parent_title_ngram { get; set; }
        public List<string> text_fs_parent { get; set; }
        public string title_tsi_suggest { get; set; }
        public string title_sort { get; set; }
        public List<string> teachers_dym { get; set; }
        public List<string> title_shingle { get; set; }
        public List<string> title_auto { get; set; }
        public List<string> text_fs_ecomm { get; set; }
        public string title_s { get; set; }
        public List<string> ProductType_ss_dp { get; set; }
        public List<string> NewProductType_ss_dp { get; set; }
        public string Keywords_tsi { get; set; }
        public string Keywords_s { get; set; }
        public List<string> Keywords_tsim { get; set; }
        public string LegacyISBN13_s { get; set; }
        public string ListPrice_s { get; set; }
        public double ListPrice_f { get; set; }
        public double SortPrice_f { get; set; }
        public string LongDescription_s { get; set; }
        public string LongDescription_tsi { get; set; }
        public string Searchable_s { get; set; }
        public string HighGrade_s { get; set; }
        public double HighGrade_f { get; set; }
        public string ViewableFlag_s { get; set; }
        public string ProductStartDate_dt { get; set; }
        public string ProductStartDate_tsi { get; set; }
        public string ProductStartDate_s { get; set; }
        public string TchPrintType_tsi { get; set; }
        public string TchPrintType_s { get; set; }
        public List<string> TchPrintType_tsim { get; set; }
        public string Platform_tsi { get; set; }
        public string Platform_s { get; set; }
        public string LegacyPrintablesID_s { get; set; }
        public string type_s { get; set; }
        public double TCBDownloads_f { get; set; }
        public object _version_ { get; set; }
        public string PdpUrl_s { get; set; }
        public bool isValidFree_s { get; set; }
        public string stockAvailability_s { get; set; }
        public string Language_s { get; set; }
        public string FreeStartDate_s { get; set; }
        public List<string> Subject_ss_dp { get; set; }
        public string SubjectTags_s { get; set; }
        public string Genre_tsi { get; set; }
        public string Genre_s { get; set; }
        public List<string> Genre_tsim { get; set; }
        public List<string> Genre_ss { get; set; }
        public string BuyNow_s { get; set; }
        public string Author_tsi { get; set; }
        public string Author_s { get; set; }
        public List<string> kids_author_tsim { get; set; }
        public List<string> Author_tsim { get; set; }
        public List<string> Author_ss { get; set; }
        public List<string> tch_author_tsim { get; set; }
        public string Themes_tsi { get; set; }
        public string Themes_s { get; set; }
        public string TchTheme_tsi { get; set; }
        public string TchTheme_s { get; set; }
        public List<string> TchTheme_tsim { get; set; }
        public string DefaultPageNumber_s { get; set; }
        public string cq_lastReplicationAction_s { get; set; }
        public string cq_lastReplicatedBy_s { get; set; }
        public string cq_lastReplicated_dt { get; set; }
        public string CommonCoreAlignmentIDsLong_s { get; set; }
        public string minibookVersions_s { get; set; }
    }

    public class MyHashMap2
    {
        public string value { get; set; }
        public int count { get; set; }
    }

    public class MyArrayList
    {
        public MyHashMap2 myHashMap { get; set; }
    }

    public class GradeF
    {
        public List<MyArrayList> myArrayList { get; set; }
    }

    public class MyHashMap3
    {
        public string value { get; set; }
        public int count { get; set; }
    }

    public class MyArrayList2
    {
        public MyHashMap3 myHashMap { get; set; }
    }

    public class GuidedReadingLevelF
    {
        public List<MyArrayList2> myArrayList { get; set; }
    }

    public class MyHashMap4
    {
        public string value { get; set; }
        public string count { get; set; }
    }

    public class MyArrayList3
    {
        public MyHashMap4 myHashMap { get; set; }
    }

    public class SubjectS
    {
        public List<MyArrayList3> myArrayList { get; set; }
    }

    public class MyHashMap5
    {
        public string value { get; set; }
        public int count { get; set; }
    }

    public class MyArrayList4
    {
        public MyHashMap5 myHashMap { get; set; }
    }

    public class GenreS
    {
        public List<MyArrayList4> myArrayList { get; set; }
    }

    public class Tags
    {
        public List<object> myArrayList { get; set; }
    }

    public class MyHashMap6
    {
        public string value { get; set; }
        public string text { get; set; }
        public Tags tags { get; set; }
    }

    public class MyArrayList5
    {
        public MyHashMap6 myHashMap { get; set; }
    }

    public class TchSubjectS
    {
        public List<MyArrayList5> myArrayList { get; set; }
    }

    public class Tags2
    {
        public List<object> myArrayList { get; set; }
    }

    public class MyHashMap7
    {
        public string value { get; set; }
        public string text { get; set; }
        public Tags2 tags { get; set; }
    }

    public class MyArrayList6
    {
        public MyHashMap7 myHashMap { get; set; }
    }

    public class TchThemeS
    {
        public List<MyArrayList6> myArrayList { get; set; }
    }

    public class Tags3
    {
        public List<object> myArrayList { get; set; }
    }

    public class MyHashMap8
    {
        public string value { get; set; }
        public string text { get; set; }
        public Tags3 tags { get; set; }
    }

    public class MyArrayList7
    {
        public MyHashMap8 myHashMap { get; set; }
    }

    public class TchPrintTypeS
    {
        public List<MyArrayList7> myArrayList { get; set; }
    }

    public class MyHashMap9
    {
        public string value { get; set; }
        public int count { get; set; }
    }

    public class MyArrayList8
    {
        public MyHashMap9 myHashMap { get; set; }
    }

    public class GuidedReadingLevelSs
    {
        public List<MyArrayList8> myArrayList { get; set; }
    }

    public class MyHashMap10
    {
        public string value { get; set; }
        public int count { get; set; }
    }

    public class MyArrayList9
    {
        public MyHashMap10 myHashMap { get; set; }
    }

    public class GradeSs
    {
        public List<MyArrayList9> myArrayList { get; set; }
    }

    public class MyHashMap
    {
        public GradeF Grade_f { get; set; }
        public GuidedReadingLevelF GuidedReadingLevel_f { get; set; }
        public SubjectS Subject_s { get; set; }
        public GenreS Genre_s { get; set; }
        public TchSubjectS TchSubject_s { get; set; }
        public TchThemeS TchTheme_s { get; set; }
        public TchPrintTypeS TchPrintType_s { get; set; }
        public GuidedReadingLevelSs GuidedReadingLevel_ss { get; set; }
        public GradeSs Grade_ss { get; set; }
    }

    public class Facets
    {
        public MyHashMap myHashMap { get; set; }
    }

    public class MyHashMap11
    {
    }
    
    public class Tags4
    {
        public List<object> myArrayList { get; set; }
    }

    public class Json
    {
        public List<SolrDocumentList> solrDocumentList { get; set; }
        public int total { get; set; }
        public string subscriptionStatus { get; set; }
    }
}
