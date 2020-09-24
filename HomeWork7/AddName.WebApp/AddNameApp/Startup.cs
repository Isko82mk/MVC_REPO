using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddName.WebApp.Services.Helpers;
using AddName.WebApp.Services.Interfaces;
using AddName.WebApp.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AddNameApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //DipendInjecConfig
            services.AddTransient<IHomeService,HomeService>();
           

            //DipendInjecModule
            DIRepositoryModule.RegisterRepositories(services);



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("Home/Error");
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseMvc(routes=> 
            {
                routes.MapRoute(
                    name:"default",
                    template:"{controller=Home}/{action=AddName}/{id?}");
            });
   
        }
    }
}
