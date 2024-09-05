namespace MVC_Demo02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/Manar", () => "Hello Manar !");
            //app.MapGet("/Login", Login);

            app.MapControllerRoute
                (
                name:"Default",
                pattern:"/{controller}/{action}/{id ?}"

                );
            app.Run();
        }
        //static string Login()
        //{
        //    return "Please Login";
        //}
    }
}
