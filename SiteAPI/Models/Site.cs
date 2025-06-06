namespace SiteAPI.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<Element>? Elements { get; set; }
        public string? UserId { get; set; }
        public DateTime? Date { get; set; }
    }
}
