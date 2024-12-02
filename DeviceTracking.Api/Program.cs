using DeviceTracking.Api.Middleware;
using DeviceTracking.Business.Servives.Abstract.Device;
using DeviceTracking.Business.Servives.Abstract.Token;
using DeviceTracking.Business.Servives.Concrete.Device;
using DeviceTracking.Business.Servives.Concrete.Token;
using DeviceTracking.Dal.Abstract.Device.IRepositories;
using DeviceTracking.Dal.Concrete.EntityFramework.Context;
using DeviceTracking.Dal.Concrete.EntityFramework.Repositories.Device;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(DbContext), typeof(DeviceTrackingContext));
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICihazDal, EfCihazDal>();
builder.Services.AddScoped<IKullaniciDal, EfKullaniciDal>();
builder.Services.AddScoped<ICihazService, CihazService>();
builder.Services.AddScoped<IKullaniciService, KullaniciService>();
builder.Services.AddControllers(x => {
    x.Filters.Add<AuthFilter>();
});


//builder.Services.AddCors(o => o.AddPolicy($"DeviceCors", builder =>
//{
//    builder.AllowAnyOrigin()
//           .AllowAnyMethod()
//           .AllowAnyHeader();
//}));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();
app.UseMiddleware<RequestLog>();
app.Run();