var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware 1
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div>Hello FPoly from the middleware 1</div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div>Returning from the middleware 1</div>");
});

// Middleware 2
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("<div>Hello FPoly from the middleware 2</div>");
    await next.Invoke();
    await context.Response.WriteAsync("<div>Returning from the middleware 2</div>");
});

// Middleware 3 - dùng Run để dừng chuỗi middleware tại đây
app.Run(async context =>
{
    await context.Response.WriteAsync("<div>Hello FPoly from the middleware 3</div>");
});

app.Run();
