using Covid.Help.Models.Responses;
using System;

namespace Covid.Help.Models.Interfaces.Algorithm
{
    public interface IAction
    {
        CallSayApiResponse SayHello(DateTime dataReference);
        CallSayApiResponse SayScreening(string symptoms);
    }
}