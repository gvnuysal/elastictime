namespace GvnAtlas.ElasticSearchAPI.Dtos
{
    public record ResponseDto<T>
    {
        public T? Data { get; set; }
        public List<string>? Errors { get; set; } 
        public int StatusCode { get; set; } = 200;
        public ResponseDto(T? data, string? message = null, bool isSuccess = true, int statusCode = 200)
        {
            Data = data; 
            StatusCode = statusCode;
        }
        public static ResponseDto<T> Success(T data, string? message = null, int statusCode = 200)
        {
            return new ResponseDto<T>(data, message, true, statusCode);
        }
        
        public static ResponseDto<T> Failure(string message, List<string> errors, int statusCode = 400)
        {
            return new ResponseDto<T>(default, message, false, statusCode) { Errors = errors };
        }
        public static ResponseDto<T> Failure(string message, int statusCode = 400)
        {
            return new ResponseDto<T>(default, message, false, statusCode) { Errors = new List<string> { message } };
        }
    } 
}
