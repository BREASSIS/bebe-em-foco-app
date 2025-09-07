namespace BebeEmFoco.Api.Configurations
{
    public static class LoggingConfiguration
    {
        public static void AddLoggingConfiguration(this IServiceCollection services)
        {
            services.AddLogging(builder =>
            {
                builder.ClearProviders();
                builder.AddConsole();
                builder.AddDebug();
            });
        }
    }
}
