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

app.UseRouting();

app.UseAuthorization();



// set a custom route / old convetion for doing that; see the ByReleaseDate method in movies controller for better solution
//app.MapControllerRoute(
//    name: "MoviesByReleaseDate",
//    pattern: "{movies}/{released}/{year}/{month}",
//    defaults: new {controller = "Movies", action = "ByReleaseDate"},
//    new { year = @"\d{4}", month = @"\d{2}" }); //specify the year should be in 4 digit format and month is 2 digit
//    // the format in the fourth argument presented is just the regEx and you could change it to your specific patarn

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
