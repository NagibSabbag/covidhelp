using Covid.Help.Models.Responses;

namespace Covid.Help.Models.Interfaces.Map
{
    public interface ICallApiMap
    {
        string ConvertToXml(CallApiResponse callApiResponse, string responseBegin, string responseEnd);
    }
}