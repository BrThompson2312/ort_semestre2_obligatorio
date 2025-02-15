﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApp.Filtros
{
    public class FLogueado : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string email = context.HttpContext.Session.GetString("email");
            if (email == null)
            {
                context.Result = new RedirectResult("/Login/Index");
            }
        }
    }
}