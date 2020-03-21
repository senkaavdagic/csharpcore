using Microsoft.AspNetCore.Mvc;
using Library;
using System.Collections.Generic;
using System.Linq;
namespace NorthwindService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly Northwind db;
        public CategoriesController(Northwind db){
            this.db = db;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IEnumerable<Category> Get() {
            var categories = db.Categories.ToArray();
            return categories;
        }
        [HttpGet("{id}", Name=nameof(GetCategory))]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(404)]
        public Category GetCategory(int id){
            var category = db.Categories.Find(id);
            return category;
        }
    }
}