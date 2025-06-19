namespace ProjectOne.MiddelWare
{
    public static class MyMiddleWareExtensions
    {
        public static IApplicationBuilder UserMyMiddelWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleWare>();
        }
    }
}
