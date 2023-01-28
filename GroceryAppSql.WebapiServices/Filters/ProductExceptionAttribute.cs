using GroceryAppSql.Entities;
using GroceryAppSql.WebapiServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GroceryAppSql.WebapiServices.Filters
{
    public class ProductExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            ServiceResponse<Product> response = new ServiceResponse<Product>
            {
                HasError = true,

            };
            response.Errors.Add("Bir hata oluştu: " + context.Exception.Message);

            context.Result = new BadRequestObjectResult(response);

        }
    }
}
