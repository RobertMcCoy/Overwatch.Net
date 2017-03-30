using System.Text.RegularExpressions;

namespace OverwatchAPICore
{
    public static class OverwatchAPICoreHelpers
    {
        public static bool IsValidBattletag(string battletag)
        {
            return new Regex(@"\w+#\d+").IsMatch(battletag);
        }

        public static string ProfileURL(string username, Region region, Platform platform)
        {
            if (platform == Platform.pc)
            {
                return $"https://playoverwatch.com/en-gb/career/{platform}/{region}/{username.Replace("#", "-")}";
            }
            else
                return $"https://playoverwatch.com/en-gb/career/{platform}/{username}";
        }
    }
}
