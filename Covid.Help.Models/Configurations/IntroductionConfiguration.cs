namespace Covid.Help.Models.Configurations
{
    public sealed class IntroductionConfiguration
    {
        public IntroductionConfiguration(string hello)
        {
            Hello = hello;
        }
        public string Hello { get; }
    }
}