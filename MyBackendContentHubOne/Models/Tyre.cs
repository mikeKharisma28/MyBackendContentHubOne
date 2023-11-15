namespace MyBackendContentHubOne.Models
{
    public class TyreData
    {
        public TyreList? data { get; set; }
    }

    public class TyreList
    {
        public int total { get; set; }

        public List<Tyre> results { get; set; }

    }

    public class Tyre
    {
        public string id { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public decimal price { get; set; }

        public decimal width { get; set; }

        public decimal profile { get; set; }

        public decimal rimSize { get; set; }

        public MediaResults logo { get; set; }

        public MediaResults tyreImage { get; set; }
    }
}
