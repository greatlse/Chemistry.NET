/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Compounds.Models;
using Chemistry.NET.Elements.Models;
using Chemistry.NET.Particles.Models;
using Isos = Chemistry.NET.Elements.Models.Isotopes; 

namespace Chemistry.NET.Common
{
    public static class Container
    {
        // --== Properties ==--
        
        public static IList<Particle> Particles { get; } = GetAll<Particle>(typeof(Particles.Models.Particles));
        public static IList<ElectronShell> ElectronShells { get; } = GetAll<ElectronShell>(typeof(ElectronShells));
        public static IList<Element> Elements { get; } = GetAll<Element>(typeof(Elements.Models.Elements));
        public static IList<ElementType> ElementTypes { get; } = GetAll<ElementType>(typeof(ElementTypes));
        public static IList<PeriodicTableElement> PeriodicTableElements { get; } = GetAll<PeriodicTableElement>(typeof(PeriodicTable));
        public static IList<PeriodicTableGroup> PeriodicTableGroups { get; } = GetAll<PeriodicTableGroup>(typeof(PeriodicTableGroups));
        public static IList<PhysicalState> PhysicalStates { get; } = GetAll<PhysicalState>(typeof(PhysicalStates));
        public static IList<ElementStructure> ElementStructures { get; } = GetAll<ElementStructure>(typeof(ElementStructures));
        public static IList<Isotope> Isotopes { get; } = GetAll<Isotope>(typeof(Isotopes)); 
        public static IList<ChemicalCompound> CommonCompounds { get; } = GetAll<ChemicalCompound>(typeof(CommonCompounds));

        public static IList<Isotope> MonoisotopicElements { get; } = new List<Isotope>
        {
            Isos.Be9, Isos.F19, Isos.Na23, Isos.Al27, Isos.P31, 
            Isos.Sc45, Isos.V51, Isos.Mn55, Isos.Co59, Isos.As75, 
            Isos.Rb85, Isos.Y89, Isos.Nb93, Isos.Rh103, Isos.In113,
            Isos.I127, Isos.Cs133, Isos.La139, Isos.Pr141, Isos.Eu153, 
            Isos.Tb159, Isos.Ho165, Isos.Tm169, Isos.Lu175, Isos.Re185, 
            Isos.Au197
        };

        public static IList<Isotope> MononuclidicElements { get; } = new List<Isotope>
        {
            Isos.Be9, Isos.F19, Isos.Na23, Isos.Al27, Isos.P31,
            Isos.Sc45, Isos.Mn55, Isos.Co59, Isos.As75, Isos.Y89,
            Isos.Nb93, Isos.Rh103, Isos.I127, Isos.Cs133, Isos.Pr141,
            Isos.Tb159, Isos.Ho165, Isos.Tm169, Isos.Au197, Isos.Bi209,
            Isos.Pa231
        };

        public static IList<Isotope> AlphaNuclides { get; } = new List<Isotope>
        {
            Isos.He4, Isos.Be8, Isos.C12, Isos.O16, Isos.Ne20,
            Isos.Mg24, Isos.Si28, Isos.S32, Isos.Ar36, Isos.Ca40, 
            Isos.Ti44, Isos.Cr48, Isos.Fe52, Isos.Ni56, Isos.Zn60
        };
        
        // --== Methods ==--

        private static IList<TModel> GetAll<TModel>(Type type)
        {
            return type.GetProperties().Select(obj => (TModel) obj.GetValue(null)).ToList();
        }
    }
}
