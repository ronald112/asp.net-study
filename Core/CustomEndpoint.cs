using Core.Interfaces;

namespace Core
{
    public class CustomEndpoint
    {
        public static async Task Endpoint(HttpContext httpContext, IResponceFormater formater)
        {
            //IResponceFormater formater = httpContext.RequestServices.GetService<IResponceFormater>();

            await formater.Format(httpContext, "CustomEndpoint");
        }
    }
}
