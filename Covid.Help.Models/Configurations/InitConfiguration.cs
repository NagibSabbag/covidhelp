namespace Covid.Help.Models.Configurations
{
    public sealed class InitConfiguration
    {
        public InitConfiguration(string goodMorning, string goodAfternoon, string goodEvening)
        {
            GoodMorning = goodMorning;
            GoodAfternoon = goodAfternoon;
            GoodEvening = goodEvening;
        }

        public string GoodMorning { get; }
        public string GoodAfternoon { get; }
        public string GoodEvening { get; }
    }
}