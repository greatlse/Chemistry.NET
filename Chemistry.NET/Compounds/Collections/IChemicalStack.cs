/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;

namespace Chemistry.NET.Compounds.Collections
{
    /// <summary>
    /// Represents general definition of a Stack used throughout the library.
    /// </summary>
    public interface IChemicalStack
    {
        /// <summary>
        /// Number of items on the Stack.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Increases / Decreases the amount of items on the current Stack.
        /// </summary>
        /// <param name="count"></param>
        void IncreaseStackSize(int count = 1);
        /// <summary>
        /// Returns the number of electrons in the stack.
        /// </summary>
        /// <returns></returns>
        int GetTotalElectronsCount();
        /// <summary>
        /// Returns the number of protons in the stack.
        /// </summary>
        /// <returns></returns>
        int GetTotalProtonsCount();
        /// <summary>
        /// Returns the number of neutrons in the stack.
        /// </summary>
        /// <returns></returns>
        int GetTotalNeutronsCount();
        /// <summary>
        /// Returns the total amount of stacks on the current stack.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ElementStack> GetAtoms();
        /// <summary>
        /// Returns true if the count of atoms are equal; otherwise false.
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        bool AreAtomsCountEqual(IChemicalStack stack);
    }
}
