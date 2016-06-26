using OverwatchAPI.Internal;
using System;
using System.Collections.Generic;

//-- A U T O   G E N E R A T E D --//

namespace OverwatchAPI.Data
{
	public class Zarya : IStatGroup
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
				var prop = GetType().GetProperty(item.Name.Replace(" ", ""));
				if (prop != null && typeof(IStatModule).IsAssignableFrom(prop.PropertyType))
				{
					IStatModule statModule = (IStatModule)Activator.CreateInstance(prop.PropertyType);
					statModule.SendTable(item);
					prop.SetValue(this, statModule);
				}
			}
		}

		public class HeroSpecificStats : IStatModule
		{
			public float DamageBlocked { get; private set; }
			public float DamageBlockedMostinGame { get; private set; }
			public float LifetimeGravitonSurgeKills { get; private set; }
			public float GravitonSurgeKillsMostinGame { get; private set; }
			public float HighEnergyKillsMostinGame { get; private set; }
			public float HighEnergyKills { get; private set; }
			public float LifetimeEnergyAccumulation { get; private set; }
			public float EnergyMaximum { get; private set; }
			public float ProjectedBarriersApplied { get; private set; }
			public float AverageEnergyBestinGame { get; private set; }
			public float MeleeFinalBlowsMostinGame { get; private set; }
			public float ProjectedBarriersAppliedAverage { get; private set; }
			public float HighEnergyKillsAverage { get; private set; }
			public float GravitonSurgeKillsAverage { get; private set; }
			public float DamageBlockedAverage { get; private set; }
			public float LifetimeAverageEnergy { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Damage Blocked"))
					DamageBlocked = table.Stats["Damage Blocked"].OWValToFloat();
				else{ DamageBlocked = 0; }
				if(table.Stats.ContainsKey("Damage Blocked - Most in Game"))
					DamageBlockedMostinGame = table.Stats["Damage Blocked - Most in Game"].OWValToFloat();
				else{ DamageBlockedMostinGame = 0; }
				if(table.Stats.ContainsKey("Lifetime Graviton Surge Kills"))
					LifetimeGravitonSurgeKills = table.Stats["Lifetime Graviton Surge Kills"].OWValToFloat();
				else{ LifetimeGravitonSurgeKills = 0; }
				if(table.Stats.ContainsKey("Graviton Surge Kills - Most in Game"))
					GravitonSurgeKillsMostinGame = table.Stats["Graviton Surge Kills - Most in Game"].OWValToFloat();
				else{ GravitonSurgeKillsMostinGame = 0; }
				if(table.Stats.ContainsKey("High Energy Kills - Most in Game"))
					HighEnergyKillsMostinGame = table.Stats["High Energy Kills - Most in Game"].OWValToFloat();
				else{ HighEnergyKillsMostinGame = 0; }
				if(table.Stats.ContainsKey("High Energy Kills"))
					HighEnergyKills = table.Stats["High Energy Kills"].OWValToFloat();
				else{ HighEnergyKills = 0; }
				if(table.Stats.ContainsKey("Lifetime Energy Accumulation"))
					LifetimeEnergyAccumulation = table.Stats["Lifetime Energy Accumulation"].OWValToFloat();
				else{ LifetimeEnergyAccumulation = 0; }
				if(table.Stats.ContainsKey("Energy Maximum"))
					EnergyMaximum = table.Stats["Energy Maximum"].OWValToFloat();
				else{ EnergyMaximum = 0; }
				if(table.Stats.ContainsKey("Projected Barriers Applied"))
					ProjectedBarriersApplied = table.Stats["Projected Barriers Applied"].OWValToFloat();
				else{ ProjectedBarriersApplied = 0; }
				if(table.Stats.ContainsKey("Average Energy - Best in Game"))
					AverageEnergyBestinGame = table.Stats["Average Energy - Best in Game"].OWValToFloat();
				else{ AverageEnergyBestinGame = 0; }
				if(table.Stats.ContainsKey("Melee Final Blows - Most in Game"))
					MeleeFinalBlowsMostinGame = table.Stats["Melee Final Blows - Most in Game"].OWValToFloat();
				else{ MeleeFinalBlowsMostinGame = 0; }
				if(table.Stats.ContainsKey("Projected Barriers Applied - Average"))
					ProjectedBarriersAppliedAverage = table.Stats["Projected Barriers Applied - Average"].OWValToFloat();
				else{ ProjectedBarriersAppliedAverage = 0; }
				if(table.Stats.ContainsKey("High Energy Kills - Average"))
					HighEnergyKillsAverage = table.Stats["High Energy Kills - Average"].OWValToFloat();
				else{ HighEnergyKillsAverage = 0; }
				if(table.Stats.ContainsKey("Graviton Surge Kills - Average"))
					GravitonSurgeKillsAverage = table.Stats["Graviton Surge Kills - Average"].OWValToFloat();
				else{ GravitonSurgeKillsAverage = 0; }
				if(table.Stats.ContainsKey("Damage Blocked - Average"))
					DamageBlockedAverage = table.Stats["Damage Blocked - Average"].OWValToFloat();
				else{ DamageBlockedAverage = 0; }
				if(table.Stats.ContainsKey("Lifetime Average Energy"))
					LifetimeAverageEnergy = table.Stats["Lifetime Average Energy"].OWValToFloat();
				else{ LifetimeAverageEnergy = 0; }
			}
		}

		public class CombatStats : IStatModule
		{
			public float Eliminations { get; private set; }
			public float FinalBlows { get; private set; }
			public float SoloKills { get; private set; }
			public float ShotsFired { get; private set; }
			public float ShotsHit { get; private set; }
			public float DamageDone { get; private set; }
			public float ObjectiveKills { get; private set; }
			public float Multikills { get; private set; }
			public float EnvironmentalKills { get; private set; }
			public float MeleeFinalBlows { get; private set; }
			public float EliminationsperLife { get; private set; }
			public float WeaponAccuracy { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Eliminations"))
					Eliminations = table.Stats["Eliminations"].OWValToFloat();
				else{ Eliminations = 0; }
				if(table.Stats.ContainsKey("Final Blows"))
					FinalBlows = table.Stats["Final Blows"].OWValToFloat();
				else{ FinalBlows = 0; }
				if(table.Stats.ContainsKey("Solo Kills"))
					SoloKills = table.Stats["Solo Kills"].OWValToFloat();
				else{ SoloKills = 0; }
				if(table.Stats.ContainsKey("Shots Fired"))
					ShotsFired = table.Stats["Shots Fired"].OWValToFloat();
				else{ ShotsFired = 0; }
				if(table.Stats.ContainsKey("Shots Hit"))
					ShotsHit = table.Stats["Shots Hit"].OWValToFloat();
				else{ ShotsHit = 0; }
				if(table.Stats.ContainsKey("Damage Done"))
					DamageDone = table.Stats["Damage Done"].OWValToFloat();
				else{ DamageDone = 0; }
				if(table.Stats.ContainsKey("Objective Kills"))
					ObjectiveKills = table.Stats["Objective Kills"].OWValToFloat();
				else{ ObjectiveKills = 0; }
				if(table.Stats.ContainsKey("Multikills"))
					Multikills = table.Stats["Multikills"].OWValToFloat();
				else{ Multikills = 0; }
				if(table.Stats.ContainsKey("Environmental Kills"))
					EnvironmentalKills = table.Stats["Environmental Kills"].OWValToFloat();
				else{ EnvironmentalKills = 0; }
				if(table.Stats.ContainsKey("Melee Final Blows"))
					MeleeFinalBlows = table.Stats["Melee Final Blows"].OWValToFloat();
				else{ MeleeFinalBlows = 0; }
				if(table.Stats.ContainsKey("Eliminations per Life"))
					EliminationsperLife = table.Stats["Eliminations per Life"].OWValToFloat();
				else{ EliminationsperLife = 0; }
				if(table.Stats.ContainsKey("Weapon Accuracy"))
					WeaponAccuracy = table.Stats["Weapon Accuracy"].OWValToFloat();
				else{ WeaponAccuracy = 0; }
			}
		}

		public class AssistsStats : IStatModule
		{
			public float TeleporterPadsDestroyed { get; private set; }
			public float TurretsDestroyed { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Teleporter Pads Destroyed"))
					TeleporterPadsDestroyed = table.Stats["Teleporter Pads Destroyed"].OWValToFloat();
				else{ TeleporterPadsDestroyed = 0; }
				if(table.Stats.ContainsKey("Turrets Destroyed"))
					TurretsDestroyed = table.Stats["Turrets Destroyed"].OWValToFloat();
				else{ TurretsDestroyed = 0; }
			}
		}

		public class BestStats : IStatModule
		{
			public float EliminationsMostinLife { get; private set; }
			public float MostScorewithinoneLife { get; private set; }
			public float DamageDoneMostinLife { get; private set; }
			public float WeaponAccuracyBestinGame { get; private set; }
			public float KillStreakBest { get; private set; }
			public float DamageDoneMostinGame { get; private set; }
			public float EliminationsMostinGame { get; private set; }
			public float FinalBlowsMostinGame { get; private set; }
			public float ObjectiveKillsMostinGame { get; private set; }
			public float ObjectiveTimeMostinGame { get; private set; }
			public float SoloKillsMostinGame { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Eliminations - Most in Life"))
					EliminationsMostinLife = table.Stats["Eliminations - Most in Life"].OWValToFloat();
				else{ EliminationsMostinLife = 0; }
				if(table.Stats.ContainsKey("Most Score within one Life"))
					MostScorewithinoneLife = table.Stats["Most Score within one Life"].OWValToFloat();
				else{ MostScorewithinoneLife = 0; }
				if(table.Stats.ContainsKey("Damage Done - Most in Life"))
					DamageDoneMostinLife = table.Stats["Damage Done - Most in Life"].OWValToFloat();
				else{ DamageDoneMostinLife = 0; }
				if(table.Stats.ContainsKey("Weapon Accuracy - Best in Game"))
					WeaponAccuracyBestinGame = table.Stats["Weapon Accuracy - Best in Game"].OWValToFloat();
				else{ WeaponAccuracyBestinGame = 0; }
				if(table.Stats.ContainsKey("Kill Streak - Best"))
					KillStreakBest = table.Stats["Kill Streak - Best"].OWValToFloat();
				else{ KillStreakBest = 0; }
				if(table.Stats.ContainsKey("Damage Done - Most in Game"))
					DamageDoneMostinGame = table.Stats["Damage Done - Most in Game"].OWValToFloat();
				else{ DamageDoneMostinGame = 0; }
				if(table.Stats.ContainsKey("Eliminations - Most in Game"))
					EliminationsMostinGame = table.Stats["Eliminations - Most in Game"].OWValToFloat();
				else{ EliminationsMostinGame = 0; }
				if(table.Stats.ContainsKey("Final Blows - Most in Game"))
					FinalBlowsMostinGame = table.Stats["Final Blows - Most in Game"].OWValToFloat();
				else{ FinalBlowsMostinGame = 0; }
				if(table.Stats.ContainsKey("Objective Kills - Most in Game"))
					ObjectiveKillsMostinGame = table.Stats["Objective Kills - Most in Game"].OWValToFloat();
				else{ ObjectiveKillsMostinGame = 0; }
				if(table.Stats.ContainsKey("Objective Time - Most in Game"))
					ObjectiveTimeMostinGame = table.Stats["Objective Time - Most in Game"].OWValToFloat();
				else{ ObjectiveTimeMostinGame = 0; }
				if(table.Stats.ContainsKey("Solo Kills - Most in Game"))
					SoloKillsMostinGame = table.Stats["Solo Kills - Most in Game"].OWValToFloat();
				else{ SoloKillsMostinGame = 0; }
			}
		}

		public class AverageStats : IStatModule
		{
			public float DeathsAverage { get; private set; }
			public float SoloKillsAverage { get; private set; }
			public float ObjectiveTimeAverage { get; private set; }
			public float ObjectiveKillsAverage { get; private set; }
			public float FinalBlowsAverage { get; private set; }
			public float EliminationsAverage { get; private set; }
			public float DamageDoneAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Deaths - Average"))
					DeathsAverage = table.Stats["Deaths - Average"].OWValToFloat();
				else{ DeathsAverage = 0; }
				if(table.Stats.ContainsKey("Solo Kills - Average"))
					SoloKillsAverage = table.Stats["Solo Kills - Average"].OWValToFloat();
				else{ SoloKillsAverage = 0; }
				if(table.Stats.ContainsKey("Objective Time - Average"))
					ObjectiveTimeAverage = table.Stats["Objective Time - Average"].OWValToFloat();
				else{ ObjectiveTimeAverage = 0; }
				if(table.Stats.ContainsKey("Objective Kills - Average"))
					ObjectiveKillsAverage = table.Stats["Objective Kills - Average"].OWValToFloat();
				else{ ObjectiveKillsAverage = 0; }
				if(table.Stats.ContainsKey("Final Blows - Average"))
					FinalBlowsAverage = table.Stats["Final Blows - Average"].OWValToFloat();
				else{ FinalBlowsAverage = 0; }
				if(table.Stats.ContainsKey("Eliminations - Average"))
					EliminationsAverage = table.Stats["Eliminations - Average"].OWValToFloat();
				else{ EliminationsAverage = 0; }
				if(table.Stats.ContainsKey("Damage Done - Average"))
					DamageDoneAverage = table.Stats["Damage Done - Average"].OWValToFloat();
				else{ DamageDoneAverage = 0; }
			}
		}

		public class DeathsStats : IStatModule
		{
			public float Deaths { get; private set; }
			public float EnvironmentalDeaths { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Deaths"))
					Deaths = table.Stats["Deaths"].OWValToFloat();
				else{ Deaths = 0; }
				if(table.Stats.ContainsKey("Environmental Deaths"))
					EnvironmentalDeaths = table.Stats["Environmental Deaths"].OWValToFloat();
				else{ EnvironmentalDeaths = 0; }
			}
		}

		public class MatchAwardsStats : IStatModule
		{
			public float MedalsBronze { get; private set; }
			public float MedalsSilver { get; private set; }
			public float MedalsGold { get; private set; }
			public float Medals { get; private set; }
			public float Cards { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Medals - Bronze"))
					MedalsBronze = table.Stats["Medals - Bronze"].OWValToFloat();
				else{ MedalsBronze = 0; }
				if(table.Stats.ContainsKey("Medals - Silver"))
					MedalsSilver = table.Stats["Medals - Silver"].OWValToFloat();
				else{ MedalsSilver = 0; }
				if(table.Stats.ContainsKey("Medals - Gold"))
					MedalsGold = table.Stats["Medals - Gold"].OWValToFloat();
				else{ MedalsGold = 0; }
				if(table.Stats.ContainsKey("Medals"))
					Medals = table.Stats["Medals"].OWValToFloat();
				else{ Medals = 0; }
				if(table.Stats.ContainsKey("Cards"))
					Cards = table.Stats["Cards"].OWValToFloat();
				else{ Cards = 0; }
			}
		}

		public class GameStats : IStatModule
		{
			public TimeSpan TimePlayed { get; private set; }
			public float GamesPlayed { get; private set; }
			public float GamesWon { get; private set; }
			public float Score { get; private set; }
			public float ObjectiveTime { get; private set; }
			public float TimeSpentonFire { get; private set; }
			public float WinPercentage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Time Played"))
					TimePlayed = table.Stats["Time Played"].OWValToTimeSpan();
				else{ TimePlayed = TimeSpan.FromSeconds(0);; }
				if(table.Stats.ContainsKey("Games Played"))
					GamesPlayed = table.Stats["Games Played"].OWValToFloat();
				else{ GamesPlayed = 0; }
				if(table.Stats.ContainsKey("Games Won"))
					GamesWon = table.Stats["Games Won"].OWValToFloat();
				else{ GamesWon = 0; }
				if(table.Stats.ContainsKey("Score"))
					Score = table.Stats["Score"].OWValToFloat();
				else{ Score = 0; }
				if(table.Stats.ContainsKey("Objective Time"))
					ObjectiveTime = table.Stats["Objective Time"].OWValToFloat();
				else{ ObjectiveTime = 0; }
				if(table.Stats.ContainsKey("Time Spent on Fire"))
					TimeSpentonFire = table.Stats["Time Spent on Fire"].OWValToFloat();
				else{ TimeSpentonFire = 0; }
				if(table.Stats.ContainsKey("Win Percentage"))
					WinPercentage = table.Stats["Win Percentage"].OWValToFloat();
				else{ WinPercentage = 0; }
			}
		}

		public class MiscellaneousStats : IStatModule
		{
			public float MultikillBest { get; private set; }
			public float ProjectedBarriersAppliedMostinGame { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				if(table.Stats.ContainsKey("Multikill - Best"))
					MultikillBest = table.Stats["Multikill - Best"].OWValToFloat();
				else{ MultikillBest = 0; }
				if(table.Stats.ContainsKey("Projected Barriers Applied - Most in Game"))
					ProjectedBarriersAppliedMostinGame = table.Stats["Projected Barriers Applied - Most in Game"].OWValToFloat();
				else{ ProjectedBarriersAppliedMostinGame = 0; }
			}
		}
	}
}