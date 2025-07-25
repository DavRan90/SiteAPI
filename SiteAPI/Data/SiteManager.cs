﻿using Microsoft.EntityFrameworkCore;
using SiteAPI.Models;

namespace SiteAPI.Data
{
    public class SiteManager
    {
        private readonly MyDbContext _context;

        public SiteManager(Models.MyDbContext context)
        {
            _context = context;
        }

        public async Task AddSiteAsync(Site site)
        {
            await _context.Sites.AddAsync(site);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Models.Site>> GetSites()
        {
            List<Models.Site> sites = await _context.Sites.ToListAsync();
            return sites;
        }
        public async Task UpdateSiteAsync(int id, Site site)
        {
            var existingSite = await _context.Sites.Where(s => s.Id == id).FirstOrDefaultAsync();
            if (existingSite != null)
            {
                existingSite.Id = site.Id;
                existingSite.Title = site.Title;
                existingSite.UserId = site.UserId;
                existingSite.Date = site.Date;
                existingSite.Elements = site.Elements;
                existingSite.BackgroundColorString = site.BackgroundColorString;
                existingSite.FontColorString = site.FontColorString;
                existingSite.FontFamilyString = site.FontFamilyString;
            }
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSiteAsync(int id)
        {
            var existingSite = await _context.Sites.Where(s => s.Id == id).FirstOrDefaultAsync();
            var existingElements = await _context.Elements.Where(e => e.SiteId == id).ToListAsync();
            foreach(var element in existingElements)
            {
                _context.Elements.Remove(element);
            }
            _context.Sites.Remove(existingSite);
            await _context.SaveChangesAsync();
        }
    }
}
