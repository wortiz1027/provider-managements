using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Steeltoe.Discovery.Client;
using Steeltoe.Management.CloudFoundry;
using Steeltoe.Management.Endpoint;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Steeltoe.Management.Endpoint.Metrics;

namespace Api
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
            services.AddCloudFoundryActuators(Configuration);
            services.AddDiscoveryClient(Configuration);
            //services.AddRabbitConnection(Configuration);            
            services.AddAllActuators(Configuration);
            services.AddControllers();
            services.AddDbContext<ProvidersContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ProvidersConnection"))
            );
            //services.AddInfoActuator(Configuration);
            //services.AddHealthActuator(Configuration);
            services.AddPrometheusActuator(Configuration);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();            
            app.UseRouting();
            app.UseAuthorization();
            app.UseDiscoveryClient();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            
        }
    }
}
