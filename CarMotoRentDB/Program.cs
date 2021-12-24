using CarMotoRentDB.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            User user1 = new User { FirstName = "Max" };
            User user2 = new User { FirstName = "Sqwe" };
            db.Users.AddRange(user1, user2);
            db.SaveChanges();
            var user = db.Users.Where(user => user.FirstName == "Max").First();
            await context.Response.WriteAsync($"Hello, {user.FirstName}!");
        }
        await context.Response.WriteAsync("\nHello World!");
    });
});
app.Run();

