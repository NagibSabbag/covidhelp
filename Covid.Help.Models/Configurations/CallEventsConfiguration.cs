namespace Covid.Help.Models.Configurations
{
    public sealed class CallEventsConfiguration
    {
        public CallEventsConfiguration(string voice, InitConfiguration initConfiguration, IntroductionConfiguration introductionConfiguration)
        {
            Voice = voice;
            Init = initConfiguration;
            Introduction = introductionConfiguration;
        }
        public string Voice { get; }
        public InitConfiguration Init { get; }
        public IntroductionConfiguration Introduction { get; }
    }
}