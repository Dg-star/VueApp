namespace VueApp1.Server.Classes
{
    public class Organization
    {
        public int organization_id { get; set; }
        public string parent { get; set; }
        public string name { get; set; }
        public int status_id { get; set; }
        public int INN { get; set; }
        public int KPP { get; set; }
        public int OGRN { get; set; }
    }
}
