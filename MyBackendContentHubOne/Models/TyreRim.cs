namespace MyBackendContentHubOne.Models
{
    public class TyreRimData
    {
        public TyreRimList? data { get; set; }
    }

    public class TyreRimList
    {
        public int total { get; set; }

        public List<TyreRim>? results { get; set; }
    }

    public class TyreRim
    {
        public string id { get; set; }

        public string name { get; set; }

        public int size { get; set; }
    }
}
