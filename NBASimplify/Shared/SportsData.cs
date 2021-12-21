using System.Text.Json.Serialization;

namespace BlazorApp1.Shared
{
    public class PlayerStats
    {
        [JsonPropertyName("StatID")]
        public int id { get; set; }

        [JsonPropertyName("TeamID")]
        public int teamId { get; set; }

        [JsonPropertyName("PlayerID")]
        public int playerId { get; set; }

        [JsonPropertyName("SeasonType")]
        public int seasonType { get; set; }

        [JsonPropertyName("Season")]
        public int season { get; set; }

        [JsonPropertyName("Name")]
        public string? name { get; set; }

        [JsonPropertyName("Team")]
        public string? team { get; set; }

        [JsonPropertyName("Position")]
        public string? position { get; set; }

        [JsonPropertyName("Started")]
        public int gamesStarted { get; set; }

        [JsonPropertyName("GlobalTeamID")]
        public int globalId { get; set; }

        [JsonPropertyName("Updated")]
        public DateTime updated { get; set; }

        [JsonPropertyName("Games")]
        public int gamesPlayed { get; set; }

        [JsonPropertyName("FantasyPoints")]
        public double fantasyPoints { get; set; }

        [JsonPropertyName("Minutes")]
        public double minutesPlayed { get; set; }

        [JsonPropertyName("Seconds")]
        public double secondsPlayed { get; set; }

        [JsonPropertyName("FieldGoalsMade")]
        public double scoredFieldGoal { get; set; }

        [JsonPropertyName("FieldGoalsAttempted")]
        public double totalFieldGoal { get; set; }

        [JsonPropertyName("FieldGoalsPercentage")]
        public double percentFieldGoal { get; set; }

        [JsonPropertyName("EffectiveFieldGoalsPercentage")]
        public double efPercentFieldGoal { get; set; }

        [JsonPropertyName("TwoPointersMade")]
        public double scoredTwoPoint { get; set; }

        [JsonPropertyName("TwoPointersAttempted")]
        public double totalTwoPoint { get; set; }

        [JsonPropertyName("TwoPointersPercentage")]
        public double percentTwoPoint { get; set; }

        [JsonPropertyName("ThreePointersMade")]
        public double scoredThreePoint { get; set; }

        [JsonPropertyName("ThreePointersAttempted")]
        public double totalThreePoint { get; set; }

        [JsonPropertyName("ThreePointersPercentage")]
        public double percentThreePoint { get; set; }

        [JsonPropertyName("FreeThrowsMade")]
        public double scoredFreeThrows { get; set; }

        [JsonPropertyName("FreeThrowsAttempted")]
        public double totalFreeThrows { get; set; }

        [JsonPropertyName("FreeThrowsPercentage")]
        public double percentFreeThrows { get; set; }

        [JsonPropertyName("OffensiveRebounds")]
        public double offRebounds { get; set; }

        [JsonPropertyName("DefensiveRebounds")]
        public double defRebounds { get; set; }

        [JsonPropertyName("Rebounds")]
        public double totalRebounds { get; set; }

        [JsonPropertyName("OffensiveReboundsPercentage")]
        public double offReboundsPercent { get; set; }

        [JsonPropertyName("DefensiveReboundsPercentage")]
        public double defReboundsPercent { get; set; }

        [JsonPropertyName("TotalReboundsPercentage")]
        public double totalReboundsPercent { get; set; }

        [JsonPropertyName("Assists")]
        public double assists { get; set; }

        [JsonPropertyName("Steals")]
        public double steals { get; set; }

        [JsonPropertyName("BlockedShots")]
        public double blockedShots { get; set; }

        [JsonPropertyName("Turnovers")]
        public double turnOvers { get; set; }

        [JsonPropertyName("PersonalFouls")]
        public double personalFouls { get; set; }

        [JsonPropertyName("Points")]
        public double points { get; set; }

        [JsonPropertyName("TrueShootingAttempts")]
        public double trueShootingAttempts { get; set; }

        [JsonPropertyName("TrueShootingPercentage")]
        public double trueShootingPercent { get; set; }

        [JsonPropertyName("PlayerEfficiencyRating")]
        public double playerERating { get; set; }

        [JsonPropertyName("AssistsPercentage")]
        public double assistPercent { get; set; }

        [JsonPropertyName("StealsPercentage")]
        public double stealsPercent { get; set; }

        [JsonPropertyName("BlocksPercentage")]
        public double blocksPercent { get; set; }

        [JsonPropertyName("TurnOversPercentage")]
        public double turnOverPercent { get; set; }

        [JsonPropertyName("UsageRatePercentage")]
        public double useRatePercent { get; set; }

        [JsonPropertyName("FantasyPointsFanDuel")]
        public double fantasyFanDuel { get; set; }

        [JsonPropertyName("FantasyPointsDraftKings")]
        public double fantasyDraftKings { get; set; }

        [JsonPropertyName("FantasyPointsYahoo")]
        public double? fantasyYahoo { get; set; }

        [JsonPropertyName("PlusMinus")]
        public double? totalPlusMins { get; set; }

        [JsonPropertyName("DoubleDoubles")]
        public double? scoredDoubles { get; set; }

        [JsonPropertyName("TripleDoubles")]
        public double? scoredTriples { get; set; }

        [JsonPropertyName("FantasyPointsFantasyDraft")]
        public double? totalFantasyDraft { get; set; }

        [JsonPropertyName("IsClosed")]
        public bool? isClosed { get; set; }

        [JsonPropertyName("LineupConfirmed")]
        public bool? lineupConfirmed { get; set; }

        [JsonPropertyName("LineupStatus")]
        public string? lineUpStatus { get; set; }
    }
}