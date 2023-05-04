namespace WebStoreBootstrap
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup (IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions d = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 2
                };
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsProduction() || env.IsStaging())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hola");
            });
        }

    }
}
