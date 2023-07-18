using Microsoft.EntityFrameworkCore;

using WTOPMDb.Data;

namespace WTOPMDb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connection = @"Data Source=WTOPMPC\SQLEXPRESS;Initial Catalog=WTOPMData;Integrated Security=True;Pooling=False;Encrypt=False";
            // Add services to the container.

            builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(connection));
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
            }

            app.UseStaticFiles();
            app.UseRouting();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}