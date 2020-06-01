using Covid.Help.Models.Interfaces.Algorithm;
using Covid.Help.Models.Interfaces.Configuration;
using Covid.Help.Models.Responses;
using System;

namespace Covid.Help.Algorithm
{
    public class Action : IAction
    {
        private readonly IAppSettings _appSettings;

        public Action(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public CallSayApiResponse SayHello(DateTime dataReference)
        {
            string helloReference;
            if (dataReference.Hour < 12)
                helloReference = _appSettings.CallEvents.Init.GoodMorning;
            else if (dataReference.Hour < 17)
                helloReference = _appSettings.CallEvents.Init.GoodAfternoon;
            else
                helloReference = _appSettings.CallEvents.Init.GoodEvening;

            helloReference += " " + _appSettings.CallEvents.Introduction.Hello;

            return this.SendSayAction(helloReference);
        }

        public CallSayApiResponse SayScreening(string symptoms)
        {
            string screeningReference;
            screeningReference = symptoms;

            return this.SendSayAction(screeningReference);
        }

        private CallSayApiResponse SendSayAction(string message)
        {
            return new CallSayApiResponse
            {
                Voice = _appSettings.CallEvents.Voice,
                Value = message
            };
        }
    }
}