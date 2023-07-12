global using SIBLEYBLAYOPERA.Models;
global using SIBLEYBLAYOPERA.Data;
global using SIBLEYBLAYOPERA.Services;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Migrations;
using SIBLEYBLAYOPERA.Services.StaffLog1Service;
using SIBLEYBLAYOPERA.Services.StaffLog2Service;
using SIBLEYBLAYOPERA.Services.ProcurementsService;
using SIBLEYBLAYOPERA.Services.DepartmentalProcurementsService;
using SIBLEYBLAYOPERA.Services.TaxExpendituresLogService;
using SIBLEYBLAYOPERA.Services.EventsLogService;
using SIBLEYBLAYOPERA.Services.CollaborationsService;
using SIBLEYBLAYOPERA.Services.BookingsService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SIBLEYBLAYOPERA.Services.UsersService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
        ValidateIssuer = false,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration.GetSection("AppSettings:Token").Value!))
    };
});
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IStaffLog1Service, StaffLog1Service>();
builder.Services.AddScoped<IStaffLog2Service, StaffLog2Service>();
builder.Services.AddScoped<IProcurementsService, ProcurementsService>();
builder.Services.AddScoped<IDepartmentalProcurementsService, DepartmentalProcurementsService>();
builder.Services.AddScoped<ITaxExpendituresLogService, TaxExpendituresLogService>();
builder.Services.AddScoped<IEventsLogService, EventsLogService>();
builder.Services.AddScoped<ICollaborationsService, CollaborationsService>();
builder.Services.AddScoped<IBookingsService, BookingsService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
