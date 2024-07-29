var builder = WebApplication.CreateBuilder(args);

// Add Kendo UI services to the services container. [https://docs.telerik.com/aspnet-core/getting-started/first-steps#adding-the-telerik-nuget-feed-for-trial-license-users]

//Cannot Get Any Data to Load in Grid
//https://docs.telerik.com/kendo-ui/knowledge-base/grid-is-not-showing-data
builder.Services.AddMvc()
            .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddKendo();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Employee}");

app.Run();
