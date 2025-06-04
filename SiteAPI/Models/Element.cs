using Blog;

namespace SiteAPI.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int? Position { get; set; }
        public string? Content { get; set; }
        public ElementTypes ElementType { get; set; }
        public int? SiteId { get; set; }
    }
}
