namespace Core.Interfaces
{
    public interface IResponceFormater
    {
        public Task Format(HttpContext httpContext, string text);
    }
}
