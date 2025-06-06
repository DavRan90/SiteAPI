using Microsoft.AspNetCore.Mvc;
using SiteAPI.Data;

namespace SiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : Controller
    {
        private readonly SiteManager _siteManager;

        public SitesController(SiteManager siteManager)
        {
            _siteManager = siteManager;
        }

        [HttpGet]
        public async Task<List<Models.Site>> GetSitesAsync()
        {
            var sites = await _siteManager.GetSites();
            return sites;
        }

        [HttpPut("{id}")]
        public async Task PutElement(int id, [FromBody] Models.Site site)
        {
            await _siteManager.UpdateSiteAsync(id, site);
        }

        [HttpPost]
        public async Task AddSite([FromBody] Models.Site site)
        {
            await _siteManager.AddSiteAsync(site);
        }
        [HttpDelete("{id}")]
        public async Task DeleteSite(int id)
        {
            await _siteManager.DeleteSiteAsync(id);
        }
    }
}
