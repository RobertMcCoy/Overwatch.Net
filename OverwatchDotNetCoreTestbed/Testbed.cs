using OverwatchAPICore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OverwatchDotNetCoreTestbed
{
    class Testbed
    {
        static void Main(string[] args)
        {
            new Task(new Testbed().RunDemo).Start();
            Console.ReadKey();
        }

        async void RunDemo()
        {
            List<OverwatchPlayer> playerCollection = new List<OverwatchPlayer>
            {
                new OverwatchPlayer("Jorohara#21710"),
                new OverwatchPlayer("SirDoombox#2603"),
                new OverwatchPlayer("VeLo InFerno"),
                new OverwatchPlayer("Rolingachu"),
                new OverwatchPlayer("DirtyBert#11920")
            };

            foreach (var player in playerCollection)
            {
                await player.DetectPlatform();
                await player.DetectRegionPC();
                await player.UpdateStats();
            }

            foreach (OverwatchPlayer player in playerCollection)
                WritePlayer(player);
        }

        void WritePlayer(OverwatchPlayer player)
        {
            Console.WriteLine($"{player.Username} | Platform: {player.Platform} | Level: {player.PlayerLevel} | Rank: {player.CompetitiveRank}");
            Console.WriteLine($"{player.ProfilePortraitURL}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Casual Stats:");
            foreach (var item in player.CasualStats.GetHero("AllHeroes").GetCategory("Game"))
                Console.WriteLine($"{item.Name}: {item.Value}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Competitive Stats:");
            foreach (var item in player.CompetitiveStats.GetHero("AllHeroes").GetCategory("Game"))
                Console.WriteLine($"{item.Name}: {item.Value}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"General Achievements: ");
            foreach (var item in player.Achievements.GetCategory("General"))
                Console.WriteLine($"{item.Name}: { item.IsUnlocked} ");
            Console.WriteLine("---------------------------\n\n");
        }
    }
}