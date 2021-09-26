using System.Threading.Tasks;
using DuyuruProjesi.Core.Models;
using DuyuruProjesi.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace DuyuruProjesi.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IService<Category> _service;

        public CategoryController(IService<Category> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _service.GetAllAsync();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Category category)
        {
            var newCategory = await _service.AddAsync(category);

            return Created(string.Empty, newCategory);
        }
    }
}