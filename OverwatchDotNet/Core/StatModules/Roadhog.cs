using OverwatchAPI.Internal;
using System;
using System.Collections.Generic;

//-- A U T O   G E N E R A T E D --//

namespace OverwatchAPI.Data
{
	public class Roadhog : IStatGroup
	{
		public HeroSpecificStats HeroSpecific { get; private set; }
		public CombatStats Combat { get; private set; }
		public AssistsStats Assists { get; private set; }
		public BestStats Best { get; private set; }
		public AverageStats Average { get; private set; }
		public DeathsStats Deaths { get; private set; }
		public MatchAwardsStats MatchAwards { get; private set; }
		public GameStats Game { get; private set; }
		public MiscellaneousStats Miscellaneous { get; private set; }

		public void SendPage(IEnumerable<OverwatchDataTable> tableCollection)
		{
			foreach(var item in tableCollection)
			{
				var prop = GetType().GetProperty(item.Name);
				if (typeof(IStatModule).IsAssignableFrom(prop.GetType()))
				{
					IStatModule statModule = (IStatModule)Activator.CreateInstance(prop.GetType());
					statModule.SendTable(item);
					prop.SetValue(this, statModule);
				}
			}
		}

		public class HeroSpecificStats : IStatModule
		{
			public int EnemiesHookedMostinGame { get; private set; }
			public int EnemiesHooked { get; private set; }
			public int HooksAttempted { get; private set; }
			public int WholeHogKillsMostinGame { get; private set; }
			public int WholeHogKills { get; private set; }
			public int HookAccuracyBestinGame { get; private set; }
			public int MeleeFinalBlowsMostinGame { get; private set; }
			public float WholeHogKillsAverage { get; private set; }
			public float EnemiesHookedAverage { get; private set; }
			public int HookAccuracy { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				EnemiesHookedMostinGame = table.Stats["Enemies Hooked - Most in Game"].OWValToInt();
				EnemiesHooked = table.Stats["Enemies Hooked"].OWValToInt();
				HooksAttempted = table.Stats["Hooks Attempted"].OWValToInt();
				WholeHogKillsMostinGame = table.Stats["Whole Hog Kills - Most in Game"].OWValToInt();
				WholeHogKills = table.Stats["Whole Hog Kills"].OWValToInt();
				HookAccuracyBestinGame = table.Stats["Hook Accuracy - Best in Game"].OWValToInt();
				MeleeFinalBlowsMostinGame = table.Stats["Melee Final Blows - Most in Game"].OWValToInt();
				WholeHogKillsAverage = table.Stats["Whole Hog Kills - Average"].OWValToFloat();
				EnemiesHookedAverage = table.Stats["Enemies Hooked - Average"].OWValToFloat();
				HookAccuracy = table.Stats["Hook Accuracy"].OWValToInt();
			}
		}

		public class CombatStats : IStatModule
		{
			public int Eliminations { get; private set; }
			public int FinalBlows { get; private set; }
			public int SoloKills { get; private set; }
			public int ShotsFired { get; private set; }
			public int ShotsHit { get; private set; }
			public int CriticalHits { get; private set; }
			public int DamageDone { get; private set; }
			public int ObjectiveKills { get; private set; }
			public int Multikills { get; private set; }
			public int EnvironmentalKills { get; private set; }
			public int MeleeFinalBlows { get; private set; }
			public float CriticalHitsperMinute { get; private set; }
			public int CriticalHitAccuracy { get; private set; }
			public float EliminationsperLife { get; private set; }
			public int WeaponAccuracy { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Eliminations = table.Stats["Eliminations"].OWValToInt();
				FinalBlows = table.Stats["Final Blows"].OWValToInt();
				SoloKills = table.Stats["Solo Kills"].OWValToInt();
				ShotsFired = table.Stats["Shots Fired"].OWValToInt();
				ShotsHit = table.Stats["Shots Hit"].OWValToInt();
				CriticalHits = table.Stats["Critical Hits"].OWValToInt();
				DamageDone = table.Stats["Damage Done"].OWValToInt();
				ObjectiveKills = table.Stats["Objective Kills"].OWValToInt();
				Multikills = table.Stats["Multikills"].OWValToInt();
				EnvironmentalKills = table.Stats["Environmental Kills"].OWValToInt();
				MeleeFinalBlows = table.Stats["Melee Final Blows"].OWValToInt();
				CriticalHitsperMinute = table.Stats["Critical Hits per Minute"].OWValToFloat();
				CriticalHitAccuracy = table.Stats["Critical Hit Accuracy"].OWValToInt();
				EliminationsperLife = table.Stats["Eliminations per Life"].OWValToFloat();
				WeaponAccuracy = table.Stats["Weapon Accuracy"].OWValToInt();
			}
		}

		public class AssistsStats : IStatModule
		{
			public int HealingDone { get; private set; }
			public int TurretsDestroyed { get; private set; }
			public int SelfHealing { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				HealingDone = table.Stats["Healing Done"].OWValToInt();
				TurretsDestroyed = table.Stats["Turrets Destroyed"].OWValToInt();
				SelfHealing = table.Stats["Self Healing"].OWValToInt();
			}
		}

		public class BestStats : IStatModule
		{
			public int EliminationsMostinLife { get; private set; }
			public int MostScorewithinoneLife { get; private set; }
			public int DamageDoneMostinLife { get; private set; }
			public int HealingDoneMostinLife { get; private set; }
			public int WeaponAccuracyBestinGame { get; private set; }
			public int KillStreakBest { get; private set; }
			public int DamageDoneMostinGame { get; private set; }
			public int HealingDoneMostinGame { get; private set; }
			public int EliminationsMostinGame { get; private set; }
			public int FinalBlowsMostinGame { get; private set; }
			public int ObjectiveKillsMostinGame { get; private set; }
			public int ObjectiveTimeMostinGame { get; private set; }
			public int SoloKillsMostinGame { get; private set; }
			public int CriticalHitsMostinGame { get; private set; }
			public int CriticalHitsMostinLife { get; private set; }
			public int SelfHealingMostinGame { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				EliminationsMostinLife = table.Stats["Eliminations - Most in Life"].OWValToInt();
				MostScorewithinoneLife = table.Stats["Most Score within one Life"].OWValToInt();
				DamageDoneMostinLife = table.Stats["Damage Done - Most in Life"].OWValToInt();
				HealingDoneMostinLife = table.Stats["Healing Done - Most in Life"].OWValToInt();
				WeaponAccuracyBestinGame = table.Stats["Weapon Accuracy - Best in Game"].OWValToInt();
				KillStreakBest = table.Stats["Kill Streak - Best"].OWValToInt();
				DamageDoneMostinGame = table.Stats["Damage Done - Most in Game"].OWValToInt();
				HealingDoneMostinGame = table.Stats["Healing Done - Most in Game"].OWValToInt();
				EliminationsMostinGame = table.Stats["Eliminations - Most in Game"].OWValToInt();
				FinalBlowsMostinGame = table.Stats["Final Blows - Most in Game"].OWValToInt();
				ObjectiveKillsMostinGame = table.Stats["Objective Kills - Most in Game"].OWValToInt();
				ObjectiveTimeMostinGame = table.Stats["Objective Time - Most in Game"].OWValToInt();
				SoloKillsMostinGame = table.Stats["Solo Kills - Most in Game"].OWValToInt();
				CriticalHitsMostinGame = table.Stats["Critical Hits - Most in Game"].OWValToInt();
				CriticalHitsMostinLife = table.Stats["Critical Hits - Most in Life"].OWValToInt();
				SelfHealingMostinGame = table.Stats["Self Healing - Most in Game"].OWValToInt();
			}
		}

		public class AverageStats : IStatModule
		{
			public float SelfHealingAverage { get; private set; }
			public float DeathsAverage { get; private set; }
			public float SoloKillsAverage { get; private set; }
			public float ObjectiveTimeAverage { get; private set; }
			public float ObjectiveKillsAverage { get; private set; }
			public float HealingDoneAverage { get; private set; }
			public float FinalBlowsAverage { get; private set; }
			public float EliminationsAverage { get; private set; }
			public float DamageDoneAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				SelfHealingAverage = table.Stats["Self Healing - Average"].OWValToFloat();
				DeathsAverage = table.Stats["Deaths - Average"].OWValToFloat();
				SoloKillsAverage = table.Stats["Solo Kills - Average"].OWValToFloat();
				ObjectiveTimeAverage = table.Stats["Objective Time - Average"].OWValToFloat();
				ObjectiveKillsAverage = table.Stats["Objective Kills - Average"].OWValToFloat();
				HealingDoneAverage = table.Stats["Healing Done - Average"].OWValToFloat();
				FinalBlowsAverage = table.Stats["Final Blows - Average"].OWValToFloat();
				EliminationsAverage = table.Stats["Eliminations - Average"].OWValToFloat();
				DamageDoneAverage = table.Stats["Damage Done - Average"].OWValToFloat();
			}
		}

		public class DeathsStats : IStatModule
		{
			public int Deaths { get; private set; }
			public int EnvironmentalDeaths { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Deaths = table.Stats["Deaths"].OWValToInt();
				EnvironmentalDeaths = table.Stats["Environmental Deaths"].OWValToInt();
			}
		}

		public class MatchAwardsStats : IStatModule
		{
			public int MedalsBronze { get; private set; }
			public int MedalsSilver { get; private set; }
			public int MedalsGold { get; private set; }
			public int Medals { get; private set; }
			public int Cards { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				MedalsBronze = table.Stats["Medals - Bronze"].OWValToInt();
				MedalsSilver = table.Stats["Medals - Silver"].OWValToInt();
				MedalsGold = table.Stats["Medals - Gold"].OWValToInt();
				Medals = table.Stats["Medals"].OWValToInt();
				Cards = table.Stats["Cards"].OWValToInt();
			}
		}

		public class GameStats : IStatModule
		{
			public TimeSpan TimePlayed { get; private set; }
			public int GamesPlayed { get; private set; }
			public int GamesWon { get; private set; }
			public int Score { get; private set; }
			public int ObjectiveTime { get; private set; }
			public int TimeSpentonFire { get; private set; }
			public int WinPercentage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				TimePlayed = table.Stats["Time Played"].OWValToTimeSpan();
				GamesPlayed = table.Stats["Games Played"].OWValToInt();
				GamesWon = table.Stats["Games Won"].OWValToInt();
				Score = table.Stats["Score"].OWValToInt();
				ObjectiveTime = table.Stats["Objective Time"].OWValToInt();
				TimeSpentonFire = table.Stats["Time Spent on Fire"].OWValToInt();
				WinPercentage = table.Stats["Win Percentage"].OWValToInt();
			}
		}

		public class MiscellaneousStats : IStatModule
		{
			public int MultikillBest { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				MultikillBest = table.Stats["Multikill - Best"].OWValToInt();
			}
		}
	}
}