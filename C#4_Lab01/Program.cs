using C_4_Lab01.Models;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký AppSettings
builder.Services.Configure<AppSettings>(builder.Configuration);

// Đăng ký các dịch vụ khác
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Cấu hình middleware
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
    pattern: "{controller=Book}/{action=Index}/{id?}");

app.Run();
