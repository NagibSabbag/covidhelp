﻿using Covid.Help.Models.Configurations;
using Covid.Help.Models.Interfaces.Service.Configurations;
using Microsoft.Extensions.Configuration;

namespace Covid.Help.Service.Configurations
{
    public class AppSettings : IAppSettings
    {
        public AppSettings(IConfiguration configuration)
        {
            CallEvents = new CallEventsConfiguration(
                voice: configuration.GetSection("CallEvents:Voice").Value,
                initConfiguration: new InitConfiguration(
                    goodMorning: configuration.GetSection("CallEvents:Init:GoodMorning").Value,
                    goodAfternoon: configuration.GetSection("CallEvents:Init:GoodAfternoon").Value,
                    goodEvening: configuration.GetSection("CallEvents:Init:GoodEvening").Value),
                introductionConfiguration: new IntroductionConfiguration(
                    hello: configuration.GetSection("CallEvents:Introduction:Hello").Value));
        }

        public CallEventsConfiguration CallEvents { get; }
    }
}