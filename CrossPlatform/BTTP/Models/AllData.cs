﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BTTP
{
    public class AllData
    {
        [JsonProperty("daily_calories")]
        public List<Calorie> Calories { get; set; }
        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }
        [JsonProperty("heart_rates")]
        public List<HeartRate> HeartRates { get; set; }
        [JsonProperty("daily_distances")]
        public List<Distance> Distances { get; set; }
    }
}
