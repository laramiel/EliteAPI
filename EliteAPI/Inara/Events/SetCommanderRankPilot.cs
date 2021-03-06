﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace EliteAPI.Inara.Events
{
    public class SetCommanderRankPilot : IInaraEventData
    {
        public SetCommanderRankPilot(RankType rankType)
        {
            RankType = rankType;
        }
        [JsonProperty("rankName")]
        public string RankName { get => RankType.ToString(); }
        private RankType RankType;
        [Range(0, 14)]
        [JsonProperty("rankValue")]
        public long RankValue { get; set; }
        [Range(0, 1)]
        [JsonProperty("rankProgress")]
        public decimal RankProgress { get; set; }
    }
    public enum RankType
    {
        Combat,
        Trade,
        Explore,
        CQC,
        Federation,
        Empire
    }
}
