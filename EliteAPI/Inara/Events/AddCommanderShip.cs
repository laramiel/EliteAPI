﻿using Newtonsoft.Json;
namespace EliteAPI.Inara.Events
{
    public class AddCommanderShip : IInaraEventData
    {
        public AddCommanderShip(string shipType, long shipGameId)
        {
            ShipType = shipType;
            ShipGameId = shipGameId;
        }
        [JsonProperty("shipType")]
        public string ShipType { get; set; }
        [JsonProperty("shipGameID")]
        public long ShipGameId { get; set; }
    }
}
