using Microsoft.AspNetCore.Mvc;
using SiteAPI.Data;

namespace SiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        private readonly ElementManager _elementManager;

        public ElementsController(ElementManager elementManager)
        {
            _elementManager = elementManager;
        }

        [HttpGet]
        public async Task<List<Models.Element>> GetElementsAsync()
        {
            var elements = await _elementManager.GetElements();
            return elements;
        }

        [HttpPost]
        public async Task PostCar([FromBody] Models.Element element)
        {
            await _elementManager.AddElement(element);
        }
    }
}
