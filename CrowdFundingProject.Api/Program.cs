using CrowdFundingProject.Bll.Services;
using CrowdFundingProject.Dal.Services;
using System.Data.Common;
using System.Data.SqlClient;

namespace CrowdFundingProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            ConfigureServices(builder.Services, builder.Configuration);

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
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddScoped<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("CrowdFundingProjectDb")));
            services.AddScoped<AuthService_Dal>();
            services.AddScoped<AuthService_Bll>();
        }
    }
}