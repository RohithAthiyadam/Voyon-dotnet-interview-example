using Voyon.DotNet.Interview.Logic.BL;
using System.Web.Mvc;
using Voyon.DotNet.Interview.Logic.Models;
using System.Web;
using Voyon.DotNet.Interview.Web.Models;

namespace Voyon.DotNet.Interview.Web.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly ITaskLogic _taskLogic;

        public TaskController(ITaskLogic taskLogic)
        {
            _taskLogic = taskLogic;
        }
                
        public ActionResult Index()
        {
            return View(_taskLogic.Get());
        }

        [CustomFilter] //check action assigned to logined user
        public ActionResult Edit(string Id)
        {
            return View(_taskLogic.Get(Id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TaskViewModel taskViewModel)
        {
            if (_taskLogic.Edit(taskViewModel.Id, taskViewModel))
                return RedirectToAction("Index");
            else
                return View(_taskLogic.Get(taskViewModel.Id));
        }

    }
}