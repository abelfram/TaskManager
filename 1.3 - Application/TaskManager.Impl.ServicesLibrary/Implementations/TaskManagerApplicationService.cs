using OperationResult;
using System.Net;
using TaskManager.Contracts.ServiceLibrary.DTO;
using TaskManager.Contracts.ServiceLibrary.ServiceContracts;

namespace TaskManager.Impl.ServiceLibrary.Implementations
{
    public class TaskManagerApplicationService : ITaskManagerApplicationService
    {
        public OperationResult<Tasks> CrateTask()
        {
            var result = new OperationResult<Tasks>()
            {
                Result = new Tasks()
            };

            try
            {

                return result;
            }catch (Exception ex)
            {
                //result.AddError(ex.Message, (int)HttpStatusCode.InternalServerError, ex);
            }

        }

        public OperationResult<Tasks> DeleteTask()
        {
            throw new NotImplementedException();
        }

        public OperationResult<Tasks> ModifyTask()
        {
            throw new NotImplementedException();
        }
    }
}
