using Blazored.Modal;
using Library.Domain.Mapping;
using Library.Domain.MappingInterfaces;
using Library.Domain.Repositorys;
using Library.Domain.ServiceInterfaces;
using Library.Domain.Services;
using Library.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Library.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddBlazoredModal();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            // Kopplar alla mapping services.
            services.AddScoped<ILibraryItemMapping, LibraryItemMapping>();
            services.AddScoped<ICategoryMapping, CategoryMapping>();

            // Kopplar alla services för databas typer från vårt domain.
            services.AddScoped<ILibraryItemService, LibraryItemService>();
            services.AddScoped<ICategoryService, CategoryService>();

            // Kopplar databsen i infrastructure till vår domain.
            services.AddScoped<ILibraryItemRepository, LibraryItemRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
