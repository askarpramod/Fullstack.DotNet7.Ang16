using CodeP.DotNet7.API.Data;
using CodeP.DotNet7.API.Models.Domain;
using CodeP.DotNet7.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CodeP.DotNet7.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public CategoriesController(ApplicationDBContext context)
        {
            this.context = context;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {

            //MAp Dto to Domain MOdel 
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

            //Dpmain Model to DTO
            var response = new CreateCategoryResponseDto
            {

                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };
            return Ok(response);
        }
    }
}
