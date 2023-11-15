namespace MyBackendContentHubOne.GraphQL
{
    public class TyreQueries
    {
        public static string AllTyreWidths = "{ data: allTyrewidth{ total results { id name width } } }";

        public static string AllTyreProfiles = "{ data: allTyreprofile{ total results { id name profile } } }";

        public static string AllTyreRims = "{ data: allTyrerim{ total results { id name size } } }";

        public static string AllTyres = "{ data: allTyre{ total results { id name type price width profile rimSize logo { results { id name fileName fileUrl description fileWidth fileHeight fileId fileSize fileType } } tyreImage { results { id name fileName fileUrl description fileWidth fileHeight fileId fileSize fileType } } } } }";
    }
}
