using GroceryAppSql.Entities;
using GroceryAppSql.WebapiServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GroceryAppSql.WebapiServices.Filters
{
    public class FavoriValidateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ServiceResponse<Favori> response = new ServiceResponse<Favori>
                {
                    Errors = context.ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList(),
                    HasError = true,
                };

                context.Result = new BadRequestObjectResult(response);
            }
        }
    }
}
