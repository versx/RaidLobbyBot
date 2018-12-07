﻿namespace T.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Pokemon
    {
        //Parse id
        //public string TemplateId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("types")]
        public List<PokemonType> Types { get; set; }

        [JsonProperty("baseStats")]
        public BaseStats BaseStats { get; set; }

        [JsonProperty("quickMoves")]
        public List<string> QuickMoves { get; set; }

        [JsonProperty("cinematicMoves")]
        public List<string> CinematicMoves { get; set; }

        [JsonProperty("evolutions")]
        public List<string> Evolutions { get; set; }

        [JsonProperty("familyId")]
        public string FamilyId { get; set; }

        [JsonProperty("candyToEvolve")]
        public int CandyToEvolve { get; set; }

        [JsonProperty("kmBuddyDistance")]
        public double KmBuddyDistance { get; set; }

        [JsonProperty("evolutionBranch")]
        public List<EvolutionBranch> EvolutionBranch { get; set; }
    }

    public class BaseStats
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("defense")]
        public int Defense { get; set; }

        [JsonProperty("stamina")]
        public int Stamina { get; set; }

        [JsonProperty("captureRate")]
        public double CaptureRate { get; set; }

        [JsonProperty("fleeRate")]
        public double FleeRate { get; set; }

        [JsonProperty("legendary")]
        public bool Legendary { get; set; }

        [JsonProperty("generation")]
        public int Generation { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }

    public class EvolutionBranch
    {
        [JsonProperty("evolution")]
        public string Evolution { get; set; }

        [JsonProperty("candy_cost")]
        public int CandyCost { get; set; }
    }
}