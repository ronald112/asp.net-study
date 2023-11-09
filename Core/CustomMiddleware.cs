using Core.Interfaces;

namespace Core
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IResponceFormater _responceFormater;

        public CustomMiddleware(RequestDelegate next, IResponceFormater responceFormater)
        {
            this._next = next;
            this._responceFormater = responceFormater;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/middleware")
            {
                await _responceFormater.Format(context, "CustomMiddleware");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
