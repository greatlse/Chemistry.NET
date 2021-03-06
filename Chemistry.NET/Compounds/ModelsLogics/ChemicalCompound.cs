/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Compounds.Parsers.ChemicalCompounds;

namespace Chemistry.NET.Compounds.Models
{
    /// <summary>
    /// Represents the core Chemical Compound.
    /// </summary>
    public partial class ChemicalCompound
    {
        public IEnumerable<ElementStack> GetAtoms()
        {
            return StructureTree.GetAtoms();
        }

        public int GetTotalElectronsCount()
        {
            return StructureTree.GetTotalElectronsCount();
        }

        public int GetTotalProtonsCount()
        {
            return StructureTree.GetTotalProtonsCount();
        }

        public int GetTotalNeutronsCount()
        {
            return StructureTree.GetTotalNeutronsCount();
        }

        public bool AreAtomsCountEqual(ChemicalCompound compound)
        {
            return StructureTree.AreAtomsCountEqual(compound.StructureTree);
        }

        /// <summary>
        /// Static method for creating new Compounds.
        /// </summary>
        /// <param name="chemicalCompound"> Formula to parse </param>
        /// <param name="chemicalName"> Chemical name of the Compound </param>
        /// <param name="commonName"> Common name of the Compound </param>
        /// <param name="parser"> Parser uses to parse the Compound. By default it will use CondensedChemicalCompoundParser as a parser. </param>
        /// <returns></returns>
        public static ChemicalCompound New(string chemicalCompound, string chemicalName, IChemicalCompoundParser parser = null)
        {
            parser ??= new CondensedChemicalCompoundParser();

            var compound = parser.Read(chemicalCompound);
            compound.Formula = chemicalCompound;
            compound.ChemicalName = chemicalName;

            return compound;
        }
    }
}
