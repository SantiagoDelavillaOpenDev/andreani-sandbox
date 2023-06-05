using System.Reflection;
using andreani_sandbox.Helpers;
using Microsoft.OpenApi.Models;

namespace andreani_sandbox
{
    public class Startup
    {

        //private readonly string _CORS = "MyCors";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddCors(options =>
            // {
            //     options.AddPolicy(name: _CORS, builder =>
            //     {
            //         builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
            //             .AllowAnyHeader().AllowAnyMethod();
            //     });
            // });
            
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            services.AddControllers()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.SuppressModelStateInvalidFilter = true;
                });


            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Prueba Andreani-Sandbox Document API's",
                    Description = $"Prueba api \r\n\r\n � Copyright {DateTime.Now.Year}. All rights reserved."
                });
                
                swagger.DocumentFilter<BasePathDocumentFilter>();
    
                swagger.EnableAnnotations();
                
                // Agregar esquema de seguridad JWT
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = "Bearer"
                });
        
                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });

                #region XMl Documentation
                    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    swagger.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
                #endregion
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(o =>
            {
                o.SwaggerEndpoint("/swagger/v1/swagger.json", "AndreaniSandbox");
            });
        }
    }
}
