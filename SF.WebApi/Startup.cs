using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SF.Data.Context;
using SF_Data.Repository;
using SF_Manager.Implementation;
using SF_Manager.Interfaces;

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
            services.AddScoped<IVoluntarioRepository, VoluntarioRepository>();
            services.AddScoped<IVoluntarioManager, VoluntarioManager>();
            services.AddDbContext<SFContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SFConnection")));
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                             new Microsoft.OpenApi.Models.OpenApiInfo
                             {
                                 Title = "Sítio Ispinho & Fulô",
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
                s.SwaggerEndpoint("./swagger/v1/swagger.json","SF V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
