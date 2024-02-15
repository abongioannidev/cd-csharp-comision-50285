using Clase15_Endpoints_Modificacion.Services;
using Clase15_Endpoints_Modificacion.database;
using Clase15_Endpoints_Modificacion.Services;
using Microsoft.EntityFrameworkCore;

namespace Clase15_Endpoints_Modificacion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<UsuarioService>();
            builder.Services.AddScoped<ProductoService>();

            builder.Services.AddDbContext<CoderContext>(options =>
            {
                options.UseSqlServer("Server=.; Database=coderhouse; Trusted_Connection=True;");
            });

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
        }
    }
}
