using BlazorCheatSheet.Components;
using BlazorCheatSheet.Contracts.Repositories;
using BlazorCheatSheet.Contracts.Services;
using BlazorCheatSheet.Repositories;
using BlazorCheatSheet.Services;
using Microsoft.EntityFrameworkCore;
using BlazorCheatSheet.State;
using BlazorCheatSheet.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContextFactory<BlazorCheatSheet.Data.AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IYogaClassRepository, YogaClassRepository>();
builder.Services.AddScoped<IYogaClassTypeRepository, YogaClassTypeRepository>();
builder.Services.AddScoped<IYogaClassDataService, YogaClassDataService>();
builder.Services.AddScoped<IYogaClassTypeDataService, YogaClassTypeDataService>();
builder.Services.AddScoped<IYogaClassAttendanceRecordRepository, YogaClassAttendanceRecordRepository>();
builder.Services.AddScoped<IYogaClassAttendanceRecordDataService, YogaClassAttendanceRecordDataService>();

// application state
builder.Services.AddScoped<ApplicationState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorCheatSheet.Client._Imports).Assembly);

// minimal apis
app.MapGet("/api/attendance", async (IYogaClassAttendanceRecordDataService yogaClassAttendanceRecordDataService) => await yogaClassAttendanceRecordDataService.GetAllYogaClassAttendanceRecordsAsync());

app.Run();
