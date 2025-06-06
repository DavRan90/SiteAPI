namespace SiteAPI.Models
{
    public class Menu : Element
    {
        public int Id { get; set; }
        public int NumberOfTitles { get; set; }
        public List<string> MenuTitles { get; set; }
        public List<string> MenuLink { get; set; }
    }
}
