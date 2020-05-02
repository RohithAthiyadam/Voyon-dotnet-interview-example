using Voyon.DotNet.Interview.Core.Models;
using Voyon.DotNet.Interview.Core.Repositories;
using Voyon.DotNet.Interview.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Voyon.DotNet.Interview.Logic.BL
{
    public class TaskLogic : ITaskLogic
    {
        private readonly ITaskRepository _tasksRepository;
        private readonly IUserRepository _usersRepository;

        public TaskLogic(ITaskRepository tasksRepository, IUserRepository usersRepository)
        {
            _tasksRepository = tasksRepository;
            _usersRepository = usersRepository;
        }

        public bool Add(TaskViewModel task)
        {
            return _tasksRepository.Create(new Task
            {
                //Id = new Guid(task.Id), //Will update in Repository( Guid.NewGuid() )
                Title = task.Title,
                Description = task.Description,
                IsFinished = task.IsFinished,
                AssignedUserId = new Guid(task.AssignedUser.Id)//,
                 
                //CreatedBy = task.AssignedUser.Id
            });
        }

        public bool Delete(string id, TaskViewModel task)
        {
            return _tasksRepository.Delete(new Guid(id), new Task
            {
                Id = new Guid(task.Id) // or Id = new Guid(id)
            });
        }

        public bool Edit(string id, TaskViewModel task) //Delete & new entry
        {
            //HttpCookie currentUserCookie = new HttpCookie("CurrentUser");
            //var user = HttpContext.Current.Session["CurrentUser"];            
            //var userid = HttpContext.Current.Request.Cookies["CurrentUser"];

            return _tasksRepository.Update(new Guid(id), new Task
            {
                Id = new Guid(task.Id), 
                Title = task.Title,
                Description = task.Description,
                IsFinished = task.IsFinished, // true,
                AssignedUserId = new Guid(task.AssignedUser.Id)
            });
        }

        public TaskViewModel Get(string id)
        {
            var taskModel = _tasksRepository.Get(new Guid(id));

            if (taskModel != null) 
            {
                return new TaskViewModel
                {
                    Id = taskModel.Id.ToString(), 
                    Title = taskModel.Title,
                    Description = taskModel.Description,
                    IsFinished = taskModel.IsFinished,
                    AssignedUser = new UserViewModel
                    {
                        Id = taskModel.AssignedUserId.ToString(),
                        Username = _usersRepository.Get(taskModel.AssignedUserId).Username
                    }
                };
            }
            else
                return new TaskViewModel { };
        }

        public IEnumerable<TaskViewModel> Get()
        {
            var user = HttpContext.Current.Response.Cookies["CurrentUser"];
    
            var tasks = _tasksRepository.Get(); 
            return tasks.Select(t => new TaskViewModel  
            {
                Id = t.Id.ToString(),
                Title = t.Title,
                Description = t.Description,
                IsFinished = t.IsFinished,
                AssignedUser = new UserViewModel
                {
                    Id = t.AssignedUserId.ToString(),
                    Username = _usersRepository.Get(t.AssignedUserId).Username
                }
            });
        }
    }
}
