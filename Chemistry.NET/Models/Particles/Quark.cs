/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Quark : Fermion
    {
        public Quark(string name, string symbol, double mass, double charge, double spin, int generation)
         : base(name, symbol, mass, charge, spin, generation)
        {
        }
    }
}
