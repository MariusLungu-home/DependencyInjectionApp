using BlazorServerDemo.Data;
using System.Runtime.CompilerServices;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static void AddServiceCollection(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IDemo, UtcDemo>();
        }
    }
}
