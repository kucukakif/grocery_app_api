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
    public class CartController : ControllerBase
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }
        [HttpGet]
        [CartException]
        public IActionResult Get()
        {
            var response = cartService.GetAll();
            return Ok(response);
        }
        [HttpGet("{id}")]
        [CartException]
        public IActionResult GetById(int id)
        {
            ServiceResponse<Cart> response = new ServiceResponse<Cart>
            {
                Entity = cartService.GetById(id),
                IsSuccessFul = true,
            };
            return Ok(response);
        }
        [HttpPost]
        [CartException]
        [CartValidate]
        public IActionResult Post([FromBody] CartModel model)
        {
            var cartList = cartService.GetAll().ToList();
            Cart cart = new Cart
            {
                Name = model.Name,
                Number = model.Number,
                Piece = model.Piece,
                Price = model.Price,
                PictureUrl = model.PictureUrl,
                Description = model.Description,
            };
            cartService.Add(cart);
            ServiceResponse<Cart> response = new ServiceResponse<Cart>
            {
                Entity = cart,
                IsSuccessFul = true,
            };
            return Ok(cart);
        }
        [HttpPut]
        [CartException]
        [CartValidate]
        public IActionResult Put(int id, [FromBody] CartModel model)
        {
            ServiceResponse<Cart> response = new ServiceResponse<Cart>();
            var cart = cartService.GetById(id);
            if (cart == null)
            {
                response.HasError = true;
                response.Errors.Add("Kategori bulunamadı!");
                return BadRequest(response);
            }
            else
            {
                cart.Name = model.Name;
                cart.Number = model.Number;
                cart.Piece = model.Piece;
                cart.Price = model.Price;
                cart.PictureUrl = model.PictureUrl;
                cart.Description = model.Description;
            }
            cartService.Update(cart);
            response.IsSuccessFul = true;

            return Ok(response);
        }
        [HttpDelete]
        [CartException]
        public IActionResult Delete(int id)
        {
            ServiceResponse<Cart> response = new ServiceResponse<Cart>();
            var cart = cartService.GetById(id);
            if (cart == null)
            {
                response.HasError = true;
                response.Errors.Add("Kategori bulunamadı!");
                return BadRequest(response);
            }
            cartService.Delete(cart);
            response.IsSuccessFul = true;
            return Ok(response);
        }
    }
}
