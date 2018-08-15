using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebStoreCursoMVC.Controllers
{
    public class ReporteLog : ActionFilterAttribute
    {
        //Antes de ejecutarse la acción.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            logger(filterContext.RouteData, "OnActionExecuting");
        }
        //Después de ejecutarse la acción.
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            logger(filterContext.RouteData, "OnActionExecuted");
        }
        //Antes de que se ejecute el resultado de la acción.
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            logger(filterContext.RouteData, "OnResultExecuting");
        }
        //Después de que se ejecute el resultado de la acción.
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            logger(filterContext.RouteData, "OnResultExecuted");
        }


        private void logger(RouteData ruta, string Evento)
        {
            var controlador = ruta.Values["controller"];
            var accion = ruta.Values["action"];
            string mensaje = string.Format("Controlador: {0}; Acción: {1}", controlador, accion);

            Debug.WriteLine("Evento: " + Evento);
            Debug.WriteLine(mensaje, "Valores de acción:");

            foreach (var item in ruta.Values)
            {
                Debug.WriteLine("--> Llave: {0}; Valor: {1}", item.Key, item.Value);
            }
        }
    }
}