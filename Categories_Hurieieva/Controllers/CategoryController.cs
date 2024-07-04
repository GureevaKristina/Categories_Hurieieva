using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Categories_Hurieieva.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost("process")]
        public async Task<IActionResult> ProcessCategories([FromBody] List<Category> categories)
        {
            var responses = new List<CattegoryAttributeResponse>();

            foreach (var category in categories)
            {
                foreach (var subCategory in category.SubCategories)
                {
                    var attributes = await GetPopularAttributesAsync(subCategory.CategoryId);
                    responses.Add(new CattegoryAttributeResponse
                    {
                        CategoryId = subCategory.CategoryId,
                        Attributes = attributes
                    });
                }
            }

            return Ok(responses);
        }

        private Task<List<string>> GetPopularAttributesAsync(int categoryId)
        {
            // Simulate fetching popular attributes for the given categoryId
            var attributes = new List<string> { "attribute1", "attribute2", "attribute3" };
            return Task.FromResult(attributes);
        }
    }
}
