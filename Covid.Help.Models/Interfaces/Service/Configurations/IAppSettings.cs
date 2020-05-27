using Covid.Help.Models.Configurations;

namespace Covid.Help.Models.Interfaces.Service.Configurations
{
    public interface IAppSettings
    {
        CallEventsConfiguration CallEvents { get; }
    }
}