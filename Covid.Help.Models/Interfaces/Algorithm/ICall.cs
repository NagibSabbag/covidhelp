using Covid.Help.Models.Requests;

namespace Covid.Help.Models.Interfaces.Algorithm
{
    public interface ICall
    {
        string Init(CallApiRequest callApiRequest);
    }
}