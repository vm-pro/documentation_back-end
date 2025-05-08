
using Documentation_back_end.Data;
using Documentation_back_end.Data.Interfaces;
using Documentation_back_end.Service;
using Documentation_back_end.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Documentation_back_end
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //Add DbContext
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options=>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            //Add Cors policy
            var myAllowSpecificOrigins = "_myAllowSpecificOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: myAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
               
            });
            builder.Services.AddScoped<IHostService, HostService>();
            builder.Services.AddScoped<IHostRepo, HostRepo>();


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

            app.UseCors(myAllowSpecificOrigins);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
