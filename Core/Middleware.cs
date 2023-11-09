namespace Core
{
    public class Middleware
    {
        private readonly RequestDelegate next;

        public Middleware()
        {
            
        }

        public Middleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
            {
                if (!context.Response.HasStarted)
                {
                    context.Response.ContentType = "text/plain";

                }
                await context.Response.WriteAsync("Class-based Middleware\n");
            }

            if (next != null)
            {
                await next.Invoke(context);
            }
        }
    }
}
