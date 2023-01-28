using GroceryAppSql.Business;
using GroceryAppSql.Business.Abstract;
using GroceryAppSql.DataAccess.Abstract;
using GroceryAppSql.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GroceryAppDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("GroceryAppSql.WebapiServices")));
builder.Services.AddTransient<IProductService, ProductManager>();
builder.Services.AddTransient<IProductRepository, ProductDal>();
builder.Services.AddTransient<ICartService, CartManager>();
builder.Services.AddTransient<ICartRepository, CartDal>();
builder.Services.AddTransient<IFavoriService, FavoriManager>();
builder.Services.AddTransient<IFavoriRepository, FavoriDal>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
