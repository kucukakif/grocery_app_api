using GroceryAppSql.Entities;
using GroceryAppSql.WebapiServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GroceryAppSql.WebapiServices.Filters
{
    public class ProductValidateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ServiceResponse<Product> response = new ServiceResponse<Product>
                {
                    Errors = context.ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList(),
                    HasError = true,
                };

                context.Result = new BadRequestObjectResult(response);
            }
        }
    }
}
