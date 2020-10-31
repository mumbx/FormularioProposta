using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioProposta.Services.Filters
{   

        public class LoginAttribute : ActionFilterAttribute
        {

            public override void OnActionExecuting(ActionExecutingContext context)
            {
                //Verificar se a sessão existe
                if (context.HttpContext.Session.GetString("Login") == null)
                {
                    //redirecionar
                    context.Result = new RedirectToActionResult("Login", "home", null);
                }
            }

        }
    }



