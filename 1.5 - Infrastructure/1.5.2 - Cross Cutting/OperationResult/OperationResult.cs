using TaskManager.Extensions;

namespace OperationResult
{
    public class OperationResult<TResult>
    {
        public OperationResult()
        {
            Errors = new List<BaseResult>();        
            Warnings = new List<BaseResult>();        
        }

        public TResult Result { get; set; }
        public List<BaseResult> Errors { get; set; }
        public List<BaseResult> Warnings { get; set;}
        public bool HasErrors => Errors != null && Warnings.Any();
        public bool HasWarnings => Warnings != null && Warnings.Any();

    }
}