using Amazon.S3;
using justTesting.Models;
using justTesting.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting
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
            
            services.AddControllersWithViews();


            //These are for the elastic beanstalk

            //services.AddDbContext<MummyDataContext>(options =>
            //{
            //    options.UseSqlServer(Helpers.GetRDSConnectionString());
            //});

            //services.AddDbContext<IdentityContext>(options =>
            //{
            //    options.UseSqlServer(Helpers.GetRDSConnectionString());
            //});

            services.AddControllersWithViews();
            services.AddRazorPages();

            //These are for the local host

            services.AddDbContext<MummyDataContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:BurialDbConnection"]);
            });

            services.AddDbContext<IdentityContext>(opts =>
                opts.UseSqlServer(Configuration[
                    "ConnectionStrings:IdentityConnection"]));
            services.AddSingleton<IS3Service, S3Service>();
            services.AddAWSService<IAmazonS3>();

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>();

            services.Configure<IdentityOptions>(opts => {
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdmins",
                     policy => policy.RequireRole("Admins"));
            });
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
                app.UseExceptionHandler("/Home/Error");
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
                endpoints.MapControllerRoute(
                    "pagination",
                    "{pageNum}",
                    new { Controller = "Home", action = "BurialList" });

                endpoints.MapControllerRoute("controllers",
                    "controllers/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute("controllers",
                    "Roles/List");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();

            });
            IdentitySeedData.CreateAdminAccount(app.ApplicationServices, Configuration);
        }
    }
}
