using Covid.Help.Models.Interfaces.Algorithm;
using Covid.Help.Models.Interfaces.Configuration;
using Covid.Help.Models.Interfaces.Map;
using Covid.Help.Models.Requests;
using Covid.Help.Models.Responses;
using System;
using System.Collections.Generic;

namespace Covid.Help.Algorithm
{
    public class Call : ICall
    {
        private readonly ICallApiMap _callApiMap;
        private readonly IAppSettings _appSettings;
        private readonly IAction _action;

        public Call(ICallApiMap callApiMap, IAppSettings appSettings, IAction action)
        {
            _callApiMap = callApiMap;
            _appSettings = appSettings;
            _action = action;
        }

        public string Init(CallApiRequest callApiRequest)
        {
            var callApiResponse = new CallApiResponse();
            var callUnitApiResponse = new List<CallUnitApiResponse>();

            if (String.IsNullOrEmpty(callApiRequest.SpeechResult))
                callUnitApiResponse.Add(new CallUnitApiResponse { Say = _action.SayHello(DateTime.Now) });
            else
                callUnitApiResponse.Add(new CallUnitApiResponse { Say = _action.SayScreening(callApiRequest.SpeechResult) });

            callApiResponse.Response = callUnitApiResponse;

            return _callApiMap.ConvertToXml(
                callApiResponse: callApiResponse,
                responseBegin: _appSettings.CallEvents.ResponseBegin,
                responseEnd: _appSettings.CallEvents.ResponseEnd);
        }
    }
}