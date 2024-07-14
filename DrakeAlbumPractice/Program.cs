using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DrakeDiscographyPractice.Data;
namespace DrakeAlbumPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DrakeDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DrakeDbContext") ?? throw new InvalidOperationException("Connection string 'DrakeDbContext' not found.")));

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
