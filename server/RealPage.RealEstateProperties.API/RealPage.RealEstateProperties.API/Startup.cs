using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RealPage.RealEstateProperties.Business;
using RealPage.RealEstateProperties.Business.Interfaces;
using RealPage.RealEstateProperties.Data.Context;
using RealPage.RealEstateProperties.Data.Context.Interfaces;
using RealPage.RealEstateProperties.Data.Repositories;
using RealPage.RealEstateProperties.Data.Repositories.Interfaces;

namespace RealPage.RealEstateProperties.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            #region Swagger Dependencies
            services.AddSwaggerGen(swagger =>
            {
                //This is to generate the Default UI of Swagger Documentation
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Real Page - Real State Properties",
                    Description = "ASP.NET Core 3.1 Web API"
                });
            });
            #endregion
            #region Project Dependencies
            services.AddTransient<IRealStatePropertiesContext, RealStatePropertiesContext>();
            services.AddTransient<IPropertyTypeRepository, PropertyTypeRepository>();
            services.AddTransient<IPropertyTypeBusiness, PropertyTypeBusiness>();
            services.AddTransient<IPropertyRepository, PropertyRepository>();
            services.AddTransient<IPropertyBusiness, PropertyBusiness>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Swagger Configuration in API
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API");

            });
        }
    }
}
