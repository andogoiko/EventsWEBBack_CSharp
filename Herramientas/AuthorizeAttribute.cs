using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

using proyectoFinal.Models;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AutohorrizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (Usuario)context.HttpContext.Items["Usuario"];
        if (user == null)
        {
            // no logeado
            context.Result = new JsonResult(
                new { 
                    message = "Unauthorrorized" 
                }) 
                { 
                    StatusCode = StatusCodes.Status401Unauthorized 
                };
        }
    }
}