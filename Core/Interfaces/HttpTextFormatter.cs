namespace Core.Interfaces
{
    public class HttpTextFormatter : IResponceFormater
    {
        private int _responseCouter = 0;

        public async Task Format(HttpContext httpContext, string text)
        {
            await httpContext.Response.WriteAsync($"Response {++_responseCouter} \n" + text);
        }
    }
}
