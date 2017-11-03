using System;
using System.Text;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Blog.Core.Repositories;
using Blog.Infrastructure.Commands;
using Blog.Infrastructure.IoC;
using Blog.Infrastructure.Mappers;
using Blog.Infrastructure.Repositories;
using Blog.Infrastructure.Services;
using Blog.Infrastructure.IoC.Modules;

namespace Blog.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        // public Startup(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // dodawanie powiązań klas i interfejsow do kontenera IoC
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();
            services.AddSingleton(AutoMapperConfiguration.Init());
            services.AddMvc();

            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule<CommandModule>();
            ApplicationContainer = builder.Build();

            // to jest konieczne dlatego, żeby contener dziala
            return new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
