using OperationResult;
using TaskManager.Contracts.ServiceLibrary.DTO;

namespace TaskManager.Contracts.ServiceLibrary.ServiceContracts
{
    public interface ITaskManagerApplicationService
    {
        OperationResult<Tasks> CrateTask();
        OperationResult<Tasks> DeleteTask();
        OperationResult<Tasks> ModifyTask();
    }
}