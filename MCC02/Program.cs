namespace MCC02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddControllers();
            var app = builder.Build();
            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(name: "Default", 
                pattern: "{Controller=home}/{Action=index}/{id?}");

            app.Run();
        }
    }
}
