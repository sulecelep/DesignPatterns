using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.BusinessLayer.Concrete;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.EntityFramework;
using DesignPattern.DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICustomerDal,EfCustomerDal>();
builder.Services.AddScoped<ICustomerService,CustomerManager>();
builder.Services.AddScoped<IProcessDal, EfProcessDal>();
builder.Services.AddScoped<IProcessService, ProcessManager>();
builder.Services.AddScoped<IUowDal, UowDal>();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt=>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
