namespace MyBackendContentHubOne.Models
{
    public class TyreProfileData
    {
        public TyreProfileList? data { get; set; }
    }

    public class TyreProfileList
    {
        public int total { get; set; }

        public List<TyreProfile>? results { get; set; }
    }

    public class TyreProfile
    {
        public string? id { get; set; }

        public string? name { get; set; }

        public int profile { get; set; }
    }
}
