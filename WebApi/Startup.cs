using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Data.Context;
using Repository;
using Implementation;
using Interfaces;

namespace SF.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IReaderRepository, ReaderRepository>();
            services.AddScoped<IReaderManager, ReaderManager>();
            services.AddDbContext<MRSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CSConnection")));
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                             new Microsoft.OpenApi.Models.OpenApiInfo
                             {
                                 Title = "Reader Scheduler",
                                 Version = "v1"
                             });
             });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                s.RoutePrefix = string.Empty;
                s.SwaggerEndpoint("./swagger/v1/swagger.json","CS V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
