using System;

namespace ReZeLos.Data
{
    public enum Tier
    {
        SS,
        S,
        A,
        B,
        Unknown,
    }

    public enum Color
    {
        Yellow,
        Purple,
        Red,
        Green,
        Blue,
    }

    public record Character
    {
        public string Version { get; init; }
        public string Name { get; init; }
        public Color Color { get; init; }
        public Tier Tier { get; init; }
        public Tier ArenaTier { get; init; }
        public double LeaderRating { get; init; }
        public double MemberRating { get; init; }
        public int HP { get; init; }
        public int Attack { get; init; }
        public int Defense { get; init; }
        public int Speed { get; init; }
        public int CriticalRate { get; init; }
        public int CriticalDamage { get; init; }
        public int DebuffSuccess { get; init; }
        public int DebuffResistance { get; init; }
    }
}
