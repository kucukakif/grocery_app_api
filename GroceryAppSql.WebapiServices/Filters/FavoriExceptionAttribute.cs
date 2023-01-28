using GroceryAppSql.Entities;
using GroceryAppSql.WebapiServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GroceryAppSql.WebapiServices.Filters
{
    public class FavoriExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            ServiceResponse<Favori> response = new ServiceResponse<Favori>
            {
                HasError = true,

            };
            response.Errors.Add("Bir hata oluştu: " + context.Exception.Message);

            context.Result = new BadRequestObjectResult(response);

        }
    }
}
