using ProjectOne.DataAccess.IService;
using ProjectOne.MiddelWare;
using ProjectOne.DataAccess.Service;
using ProjectOne.DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add context services 
builder.Services.AddDbContext<DBContexts>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Registering services
builder.Services.AddScoped<IAccountGenericReponsetory, AccountGenericReponsetory>();
builder.Services.AddScoped<ICategoryRepository, CategoryReposetory>();
builder.Services.AddScoped<ICategoryGenericReposetory, CategoryGenericReponsetory>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseMiddleware<MyMiddleWare>();
app.UserMyMiddelWare();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
