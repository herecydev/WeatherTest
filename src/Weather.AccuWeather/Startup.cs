using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace Weather.AccuWeather
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSwagger();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            
            app.UseSwagger();
            app.UseSwaggerUi();

            app.UseWelcomePage();
        }
    }
}
