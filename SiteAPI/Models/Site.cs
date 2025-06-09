using System.Drawing;
using System.Text.Json.Serialization;

namespace SiteAPI.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? BackgroundColorString { get; set; }
        public string? FontColorString { get; set; }
        public string? FontFamilyString { get; set; }
        public List<Element>? Elements { get; set; }
        public string? UserId { get; set; }
        public DateTime? Date { get; set; }
    }
}
