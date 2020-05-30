using Covid.Help.Models.Interfaces.Algorithm;
using Covid.Help.Models.Interfaces.Configuration;
using Covid.Help.Models.Interfaces.Map;
using Covid.Help.Models.Requests;
using Covid.Help.Models.Responses;
using System.Collections.Generic;

namespace Covid.Help.Algorithm
{
    public class Call : ICall
    {
        private readonly ICallApiMap _callApiMap;
        private readonly IAppSettings _appSettings;

        public Call(ICallApiMap callApiMap, IAppSettings appSettings)
        {
            _callApiMap = callApiMap;
            _appSettings = appSettings;
        }

        public string Init(CallApiRequest callApiRequest)
        {
            var callApiResponse = new CallApiResponse
            {
                Response = new List<CallUnitApiResponse>
                {
                    new CallUnitApiResponse{ Say = new CallSayApiResponse
                    {
                        Voice = _appSettings.CallEvents.Voice,
                        Value = string.IsNullOrEmpty(callApiRequest.SpeechResult) ? _appSettings.CallEvents.Init.GoodMorning : callApiRequest.SpeechResult
                    }},
                    new CallUnitApiResponse{ Say = new CallSayApiResponse
                    {
                        Voice = _appSettings.CallEvents.Voice,
                        Value = _appSettings.CallEvents.Introduction.Hello
                    }}
                }
            };

            return _callApiMap.ConvertToXml(
                callApiResponse: callApiResponse,
                responseBegin: _appSettings.CallEvents.ResponseBegin,
                responseEnd: _appSettings.CallEvents.ResponseEnd);
        }
    }
}