using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Notepad.Data.Interfaces;
using Notepad.Data.Models;
using Notepad.Data.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace Notepad
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllRecipes, MockRecipe>();
            services.AddTransient<IAllProductsLists, MockProduct>();
            services.AddTransient<IAllToDoLists, MockAction>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
