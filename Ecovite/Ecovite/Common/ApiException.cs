namespace Ecovite.Common
{
    public class ApiException : Exception
    {
        public int ErrorCode { get; set; }
        public string? ErrorId { get; set; }
        public ApiException(int errorCode, string errorMessage,string? errorId = null):base(errorMessage) {
        ErrorCode = errorCode;
            ErrorId = errorId;
        }
    }
}