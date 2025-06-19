namespace ProjectOne.MiddelWare
{
    public class MyMiddleWare
    {
        readonly RequestDelegate _next;
        public MyMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext) {
            //return httpContext.Response.WriteAsync("Hello Nguyen Duan!");
            httpContext.Response.Headers.Append("Hackerby", "NguyenDuan");
            return _next(httpContext);
        }
    }
}
