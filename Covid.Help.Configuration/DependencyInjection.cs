using Covid.Help.Algorithm;
using Covid.Help.Map;
using Covid.Help.Models.Interfaces.Algorithm;
using Covid.Help.Models.Interfaces.Configuration;
using Covid.Help.Models.Interfaces.Map;
using Microsoft.Extensions.DependencyInjection;

namespace Covid.Help.Configuration
{
    public class DependencyInjection
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<ICall, Call>()
                .AddSingleton<IFormatMessage, FormatMessage>()
                .AddSingleton<IAppSettings, AppSettings>()
                .AddSingleton<ICallApiMap, CallApiMap>();
        }
    }
}