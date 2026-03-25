namespace COMP003B.Assignment2
{
    /* Samuel Iannazzo
     * COMP003B: ASP.NET Core
     * Jonathan Cruz
     * The purpose of this application is to demonstraight my understanding of how 
     * to properly use the request pipeline with middleware, controllers, views,
     * layout design as well as views that we have learned this chapter 
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseMiddleware<COMP003B.Assignment2.Middleware.RequestTrackerMiddleware>();

            app.UseWelcomePage("/welcome");

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
