﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetGroup.Extensions;
using Business;
using Business.Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository;
using Repository.Contracts;
using Swashbuckle.AspNetCore.Swagger;

namespace BetGroup
{
    public class Startup
    {
        private const string SwaggerUrl = "/swagger/v1/swagger.json";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "API do BetGroup",
                        Version = "v1",
                        Description = "API do BetGroup",
                        Contact = new Contact
                        {
                            Name = "Filipe Trancoso",
                            Email = "fhtrancoso@gmail.com"
                        }
                    });
            });

            services.ConfigureMySqlContext(Configuration);
            services.ConfigureBusiness();
            services.ConfigureRepository();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Ativando middlewares para uso do Swagger
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint(SwaggerUrl,
                        "API do BetGroup");
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
