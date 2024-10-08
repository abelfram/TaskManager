using System.Web.Http;
using TaskManager.Contracts.ServiceLibrary.ServiceContracts;
using DTO = TaskManager.Contracts.ServiceLibrary.DTO;

namespace TaskManager.WebApi.Controllers
{
    //[ApiVersion("1.0")]
    [RoutePrefix("api/Users")]
    public class TaskController
    {
        #region .: Private Variables :.
        private readonly ITaskManagerApplicationService _taskManagerApplicationService;
        #endregion

        #region .: Constructor :.
        public TaskController(ITaskManagerApplicationService taskManagerApplicationService)
        {
            _taskManagerApplicationService = taskManagerApplicationService;
        }
        #endregion

        #region .: Public Methods :.


        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateTask()
        {
            return null;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult ModifyTask(DTO.Tasks task)
        {
            return null;
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult DeleteTask(int idTask) 
        {
            return null;
        }
        #endregion

       
    }
}
