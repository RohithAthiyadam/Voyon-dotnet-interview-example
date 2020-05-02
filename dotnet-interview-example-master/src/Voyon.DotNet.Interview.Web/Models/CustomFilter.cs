using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Voyon.DotNet.Interview.Web.Models
{
    public class CustomFilter : ActionFilterAttribute
    {
        public string id { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Use logined userId , take _tasksRepository.Get  && compare with AssignedUserId  

            //if not assigned,  redirect to list page
            //context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
            //{
            //    controller = "Task",
            //    action = "Index"

            //}));
        }
    }
}