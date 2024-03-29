﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class Item {
    [JsonProperty("Cost")]
    public int Cost { get; set; }

    [JsonProperty("id")]
    public int ID { get; set; }

    [JsonProperty("quantity")]
    public int Quantity { get; set; }
}
