using Covid.Help.Models.Interfaces.Service.Configurations;
using Microsoft.Extensions.Configuration;
using System;

namespace Covid.Help.Service.Configurations
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;

        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException($"{nameof(configuration)} can not be NULL");
        }

        public string CallProperties_Voice => _configuration.GetSection("CallProperties:Voice").Value;

        public string CallProperties_Init_Morning => _configuration.GetSection("CallProperties:Init:Morning").Value;
    }
}