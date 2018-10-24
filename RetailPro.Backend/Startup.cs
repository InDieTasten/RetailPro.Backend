using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using RetailPro.Backend.Areas.UserSpace.Models;
using RetailPro.Backend.Areas.UserSpace.DbContexts;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Mvc.Internal;
using System.Linq;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.Net.Http.Headers;

namespace RetailPro.Backend
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
            services.AddDbContext<PlaceholderDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PlaceholderDbContext")));
            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UserDbContext")));
            services.AddDbContext<ContentDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ContentDbContext")));

            services.AddOData();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("beta", new Info { Title = "RetailPro.Backend", Version = "beta" });
            });

            services.AddMvc(options =>
            {
                // Workaround: https://github.com/OData/WebApi/issues/1177
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(o => o.SwaggerEndpoint("/swagger/beta/swagger.json", "RetailPro.Backend"));

            app.UseMvc(routeBuilder =>
            {
                // Workaround: https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/581
                routeBuilder.DefaultHandler = app.ApplicationServices.GetRequiredService<MvcRouteHandler>();

                routeBuilder.Select().Expand().Filter().OrderBy().MaxTop(200).Count();
                routeBuilder.MapODataServiceRoute("odata", "odata", GetEdmModel());

                // Workaround: https://github.com/OData/WebApi/issues/1175
                routeBuilder.EnableDependencyInjection();
            });
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<User>("Users");
            return builder.GetEdmModel();
        }
    }
}
