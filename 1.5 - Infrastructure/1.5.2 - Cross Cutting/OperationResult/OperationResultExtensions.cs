using OperationResult;

namespace TaskManager.Extensions
{
    public static class OperationResultExtensions
    {
        public static OperationResult<TResult> AddResult<TResult>(
            this OperationResult<TResult> operationResult,
            TResult result)
        {
            if (operationResult == null) 
                throw new ArgumentNullException(nameof(operationResult), "builderContext cannot be null");

            operationResult.Result = result;

            return operationResult;
        }

        public static OperationResult<TResult> AddWarning<TResult>(
            this OperationResult<TResult> operationResult,
            string warningMessage,
            int warningCode)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult), "builderContext cannot be null");

            operationResult.Warnings.Add(new BaseResult(warningMessage, warningCode));

            return operationResult;
        }

        public static OperationResult<TResult> AddError<TResult>(
            this OperationResult<TResult> operationResult,
            string errorMessage,
            int errorCode,
            Exception exception = null)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult), "builderContext cannot be null");

            operationResult.Errors.Add(new BaseResult(errorMessage, errorCode, exception));

            return operationResult;
        }
    }
}
