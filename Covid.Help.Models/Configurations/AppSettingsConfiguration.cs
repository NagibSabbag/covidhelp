namespace Covid.Help.Models.Configurations
{
    public sealed class AppSettingsConfiguration
    {
        public AppSettingsConfiguration(CallEventsConfiguration callEventsConfiguration)
        {
            CallEvents = callEventsConfiguration;
        }
        public CallEventsConfiguration CallEvents { get; }
    }
}