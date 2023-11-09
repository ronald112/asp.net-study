namespace Core.Interfaces
{
    public class HtmlTextFormater : IResponceFormater
    {
        private int _responseCouter = 0;
        public async Task Format(HttpContext httpContext, string text)
        {
            httpContext.Response.ContentType = "text/html";
            await httpContext.Response.WriteAsync($"Formatted Response {++_responseCouter} \n + <h2>{text}</h2>");
        }
    }
}
