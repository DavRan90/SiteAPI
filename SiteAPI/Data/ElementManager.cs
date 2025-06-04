using Microsoft.EntityFrameworkCore;
using SiteAPI.Models;

namespace SiteAPI.Data
{
    public class ElementManager
    {
        private readonly MyDbContext _context;

        public ElementManager(Models.MyDbContext context)
        {
            _context = context;
        }

        public async Task AddElement(Element element)
        {
            await _context.Elements.AddAsync(element);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Models.Element>> GetElements()
        {
            List<Models.Element> elements = await _context.Elements.ToListAsync();
            return elements;
        }
    }
}
