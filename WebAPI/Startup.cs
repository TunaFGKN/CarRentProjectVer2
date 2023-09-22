﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add serices to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICarService,CarManager>();
            services.AddSingleton<ICarDal,EfCarDal>();

            services.AddSingleton<IColorService,ColorManager>();
            services.AddSingleton<IColorDal,EfColorDal>();

            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IBrandDal, EfBrandDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {

        }
    }
}