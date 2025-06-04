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

        [HttpPost]
        public async Task PostCar([FromBody] Models.Site site)
        {
            await _siteManager.AddElement(site);
        }
    }
}
