using Microsoft.AspNetCore.Mvc;
using SiteAPI.Data;

namespace SiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        private readonly ElementManager _elementManager;

        public ElementController(ElementManager elementManager)
        {
            _elementManager = elementManager;
        }

        [HttpGet]
        public List<Models.Element> GetAllElements()
        {
            //if (Data.ElementManager.GetElements().Count == 0)
            //{
                
            //}
            return Data.ElementManager.GetElements();
        }
        //public async Task<List<Models.Element>> GetElementsAsync()
        //{
        //    var elements = await _elementManager.GetElements();
        //    return elements;
        //}

        [HttpPut("{id}")]
        public async Task PutElement(int id, [FromBody] Models.Element element)
        {
            await _elementManager.UpdateElementAsync(id, element);
        }

        [HttpPost]
        public async Task PostElement([FromBody] Models.Element element)
        {
            await _elementManager.AddElement(element);
        }
    }
}
