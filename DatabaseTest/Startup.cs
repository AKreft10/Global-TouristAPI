using DatabaseTest.Entity;
using DatabaseTest.Middleware;
using DatabaseTest.Services;
using DatabaseTest.Services.ApiDataServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTest
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
            services.AddAutoMapper(this.GetType().Assembly);
            services.AddControllers();
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddDbContext<DatabaseContext>();
            services.AddScoped<DbSeeder>();
            services.AddScoped<ExceptionMiddleware>();
            services.AddScoped<IPlaceService, PlaceService>();
            services.AddScoped<IAccommodationService, AccommodationService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IDistanceService, DistanceService>();
            services.AddScoped<IBingMapsDistanceService, BingMapsDistanceService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DbSeeder seeder)
        {
            seeder.SeedData();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DatabaseTest"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
