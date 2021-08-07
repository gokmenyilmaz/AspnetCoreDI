using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDI
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

            services.AddTransient<IOtelService, OtelService>();

        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             app.UseRouting();

            app.Use((ctx, next)=>
            {
                var srv= ctx.RequestServices.GetRequiredService<IOtelService>();

                var srv2 = ctx.RequestServices.GetRequiredService<IOtelService>();


                return next();
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
