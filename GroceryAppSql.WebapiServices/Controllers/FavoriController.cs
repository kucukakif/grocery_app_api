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
    public class FavoriController : ControllerBase
    {
        private readonly IFavoriService favoriService;

        public FavoriController(IFavoriService favoriService)
        {
            this.favoriService = favoriService;
        }
        [HttpGet]
        [FavoriException]
        public IActionResult Get()
        {
            var response = favoriService.GetAll();
            return Ok(response);
        }
        [HttpGet("{id}")]
        [FavoriException]
        public IActionResult GetById(int id)
        {
            ServiceResponse<Favori> response = new ServiceResponse<Favori>
            {
                Entity = favoriService.GetById(id),
                IsSuccessFul = true,
            };
            return Ok(response);
        }
        [HttpPost]
        [FavoriException]
        [FavoriValidate]
        public IActionResult Post([FromBody] FavoriModel model)
        {
            Favori favori = new Favori
            {
                Number = model.Number,
            };
            favoriService.Add(favori);
            ServiceResponse<Favori> response = new ServiceResponse<Favori>
            {
                Entity = favori,
                IsSuccessFul = true,
            };
            return Ok();
        }
        [HttpPut]
        [FavoriException]
        [FavoriValidate]
        public IActionResult Put(int id, [FromBody] FavoriModel model)
        {
            ServiceResponse<Favori> response = new ServiceResponse<Favori>();
            var favori = favoriService.GetById(id);
            if (favori == null)
            {
                response.HasError = true;
                response.Errors.Add("Kategori bulunamadı!");
                return BadRequest(response);
            }
            else
            {
                favori.Number = model.Number;
            }
            favoriService.Update(favori);
            response.IsSuccessFul = true;

            return Ok(response);
        }
        [HttpDelete]
        [FavoriException]
        public IActionResult Delete(int id)
        {
            ServiceResponse<Favori> response = new ServiceResponse<Favori>();
            var favori = favoriService.GetById(id);
            favoriService.Delete(favori);
            return Ok(response);
        }
    }
}
