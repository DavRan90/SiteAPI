using Microsoft.EntityFrameworkCore;
using SiteAPI.Models;

namespace SiteAPI.Data
{
    public class ElementManager
    {
        private readonly MyDbContext _context;
        private static List<Models.Element> Elements { get; set; } = new List<Models.Element>();

        public ElementManager(Models.MyDbContext context)
        {
            Elements = context.Elements.ToList();
            _context = context;
        }

        public static List<Models.Element> GetElements()
        {
            return Elements;
        }

        public async Task AddElement(Element element)
        {
            await _context.Elements.AddAsync(element);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateElementAsync(int id, Element element)
        {
            var existingElement = await _context.Elements.Where(e => e.Id == id).FirstOrDefaultAsync();
            if (existingElement != null)
            {
                existingElement.MenuTitles = element.MenuTitles;
                existingElement.Id = element.Id;
                existingElement.Position = element.Position;
                existingElement.Content = element.Content;
                existingElement.SiteId = element.SiteId;
                existingElement.ElementType = element.ElementType;
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteElementAsync(int id)
        {
            var existingElement = await _context.Elements.Where(e => e.Id == id).FirstOrDefaultAsync();
            _context.Elements.Remove(existingElement);
            await _context.SaveChangesAsync();
        }
    }
}
