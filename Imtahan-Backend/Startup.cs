using Imtahan_Backend.DAL;
using Imtahan_Backend.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan_Backend
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = _config.GetConnectionString("DefaultConnection");
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(op=> 
            {
                op.UseSqlServer(connectionString);
            });

            services.AddSession(op=> {
                op.IdleTimeout = TimeSpan.FromMinutes(20);
            });

            services.AddIdentity<AppUser, IdentityRole>(op=> 
            {
                op.User.RequireUniqueEmail = true;

                op.Password.RequireDigit = true;
                op.Password.RequiredLength = 6;
                op.Password.RequireLowercase = true;
                op.Password.RequireNonAlphanumeric = true;
                op.Password.RequireUppercase = true;

                op.Lockout.AllowedForNewUsers = true;
                op.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                op.Lockout.MaxFailedAccessAttempts = 3;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
