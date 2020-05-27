using System.Collections.Generic;

namespace Covid.Help.Models.Responses
{
    public sealed class CallApiResponse
    {
        public List<CallUnitApiResponse> Response { get; set; }
    }
}