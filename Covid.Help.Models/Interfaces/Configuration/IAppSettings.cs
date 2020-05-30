using Covid.Help.Models.Configurations;

namespace Covid.Help.Models.Interfaces.Configuration
{
    public interface IAppSettings
    {
        CallEventsConfiguration CallEvents { get; }
    }
}