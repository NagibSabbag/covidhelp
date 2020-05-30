using Covid.Help.Models.Interfaces.Algorithm;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Covid.Help.Algorithm
{
    public class FormatMessage : IFormatMessage
    {
        public IList<string> Result { get; }

        public FormatMessage(string message)
        {
            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç,.\s]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            var resultMessage = rgx.Replace(message, replacement);

            Result = resultMessage.Split(' ').ToList().ConvertAll(d => d.ToLower().Trim());
        }
    }
}