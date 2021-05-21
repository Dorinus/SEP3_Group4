using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TierOne;
using TierOne.Areas.Identity;
using TierOne.Data;
using TierOne.Data.Migrations;

namespace TierOne
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services
                .AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>
                >();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<IUserManager, UserManager>();
            services.AddSingleton<IProductManager, ProductManager>();
            services.AddSingleton<ICategoryManager, CategoryManager>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            
            
            services.AddAuthorization(options =>
            {
                
                options.AddPolicy("user", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "user","manager", "admin"));
                options.AddPolicy("manager", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "admin","manager"));
                options.AddPolicy("admin", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "admin"));
                
                options.AddPolicy("onlyUser", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "user"));
                options.AddPolicy("onlyManager", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "manager"));
                options.AddPolicy("onlyAdmin", a => a.RequireAuthenticatedUser().RequireClaim("UserType", "admin"));
                
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}