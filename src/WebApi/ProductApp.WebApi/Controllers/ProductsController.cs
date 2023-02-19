using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.DTOs;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await _productRepository.GetAllAsync();

            var result = allList.Select(i => new ProductViewDto()
            {
                Id = i.Id,
                Name = i.Name,
            }).ToList();

            return Ok(result);  
        }
    }
}

