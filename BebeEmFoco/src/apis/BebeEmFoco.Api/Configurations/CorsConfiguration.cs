namespace BebeEmFoco.Api.Configurations
{
    public static class CorsConfiguration
    {
        public static void AddCorsConfiguration(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });
        }

        public static void UseCorsConfiguration(this WebApplication app)
        {
            app.UseCors("AllowAll");
        }
    }
}
