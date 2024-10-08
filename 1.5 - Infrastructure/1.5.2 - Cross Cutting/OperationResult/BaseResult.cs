namespace TaskManager.Extensions
{
    public class BaseResult
    {
        public BaseResult(string message, int code, Exception exception = null)
        {
            Code = code;
            Message = message;
            Exception = exception;
        }

        public Exception Exception { get; private set; }
        public int Code { get; private set; }
        public string Message { get; private set; }
    }
}
