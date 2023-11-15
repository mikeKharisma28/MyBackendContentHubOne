namespace MyBackendContentHubOne.Models
{
    public class TyreWidthData
    {
        public TyreWidthList? data { get; set; }
    }

    public class TyreWidthList
    {
        public int total { get; set; }

        public List<TyreWidth>? results { get; set; }
    }

    public class TyreWidth
    {
        public string? id { get; set; }

        public string? name { get; set; }

        public int width { get; set; }
    }
}
