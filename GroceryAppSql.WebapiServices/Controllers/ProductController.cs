using GroceryAppSql.Business.Abstract;
using GroceryAppSql.Entities;
using GroceryAppSql.WebapiServices.Filters;
using GroceryAppSql.WebapiServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryAppSql.WebapiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        [ProductException]
        public IActionResult Get()
        {
            var response = productService.GetAll();
            return Ok(response);
        }
        [HttpGet("{id}")]
        [ProductException]
        public IActionResult GetById(int id)
        {
            ServiceResponse<Product> response = new ServiceResponse<Product>
            {
                Entity = productService.GetById(id),
                IsSuccessFul = true,
            };
            return Ok(response);
        }
        [HttpPost]
        [ProductException]
        [ProductValidate]
        public IActionResult Post([FromBody] ProductModel model)
        {
            Product product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                PictureUrl = model.PictureUrl,
                Categori = model.Categori,
                Description = model.Description,
                isFavori = model.isFavori,
                Piece = model.Piece,
            };
            productService.Add(product);
            ServiceResponse<Product> response = new ServiceResponse<Product>
            {
                Entity = product,
                IsSuccessFul = true,
            };
            return Ok();
        }
        [HttpPut]
        [ProductException]
        [ProductValidate]
        public IActionResult Put(int id,[FromRoute] ProductModel model)
        {
            ServiceResponse<Product> response = new ServiceResponse<Product>();
            var product = productService.GetById(id);
            if(product == null)
            {
                response.HasError = true;
                response.Errors.Add("Kategori bulunamadı!");
                return BadRequest(response);
            }
            else
            {
                product.Name = model.Name;
                product.Price = model.Price;
                product.PictureUrl = model.PictureUrl;
                product.Categori = model.Categori;
                product.Description = model.Description;
                product.isFavori = model.isFavori;
                product.Piece = model.Piece;
            }
            productService.Update(product);
            response.IsSuccessFul = true;

            return Ok(response);
        }
        [HttpDelete]
        //[ProductException]
        public IActionResult Delete(int id)
        {
            ServiceResponse<Product> response = new ServiceResponse<Product>();
            var product = productService.GetById(id);
            productService.Delete(product);
            return Ok(product);
        }
    }
}
