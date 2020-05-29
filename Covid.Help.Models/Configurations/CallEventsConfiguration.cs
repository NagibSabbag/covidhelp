namespace Covid.Help.Models.Configurations
{
    public sealed class CallEventsConfiguration
    {
        public CallEventsConfiguration(string voice, string responseBegin, string responseEnd, InitConfiguration initConfiguration, IntroductionConfiguration introductionConfiguration)
        {
            ResponseBegin = responseBegin;
            ResponseEnd = responseEnd;
            Voice = voice;
            Init = initConfiguration;
            Introduction = introductionConfiguration;
        }

        public string ResponseBegin { get; }
        public string ResponseEnd { get; }
        public string Voice { get; }
        public InitConfiguration Init { get; }
        public IntroductionConfiguration Introduction { get; }
    }
}