using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Worker.Business.Abstract;
using Worker.Business.Concrete;
using Worker.Business.Helpers;
using Worker.DataAccess.Abstract;
using Worker.DataAccess.Concrete.EntityFramework;
using Worker.MvcUI.Middelewares;

namespace Worker.MvcUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();

            services.AddScoped<IWebSettingsService, WebSettingsManager>();
            services.AddScoped<IWebSettingsDal, EfWebSettingsDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IActivityService, ActivityManager>();
            services.AddScoped<IActivityDal, EfActivityDal>();

            services.AddScoped<IMailSender, MailSender>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseMvcWithDefaultRoute();
        }
    }
}
