using Services;
using Entites;
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using RepositoryContract;
using Repositories;
using RepositryContract;
using Entites.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// yazaaaaaaaan
//// yaazaa test
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Defualt"));
});



builder.Services.AddScoped<ITourismPlacesRepository, TourismPlacesRepository>();

builder.Services.AddScoped<ITrendingEventsRepository, TrendingEventsRepository>();

builder.Services.AddScoped<IFAQsRepository, FAQsRepository>();

builder.Services.AddScoped<IAccountRepository, AccountRepository>();

builder.Services.AddScoped<ITourismService,TourismServices>();

builder.Services.AddScoped<ITrendingEventsServices, TrendingEventsServices>();

builder.Services.AddScoped<IFAQsService, FAQsServices>();

builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddScoped<IJwtService, JwtService>();



//Identity
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.Password.RequiredLength = 5;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = true;
    options.Password.RequireDigit = true;
})
 .AddRoles<ApplicationRole>()
 .AddEntityFrameworkStores<ApplicationDbContext>()
 .AddDefaultTokenProviders()
 .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()
 .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();


var app = builder.Build();

app.UseHsts();

app.UseStaticFiles();

// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
// New Feturere in ohter branch
// Feature one
//555555555555