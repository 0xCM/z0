//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classfies operations according to their immediate needs
    /// </summary>
    [Flags]
    public enum ImmediateClass : byte
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Classifies operations that accept one or more immediate values
        /// </summary>
        Imm8 = 1,

        /// <summary>
        /// Classifies operations that accept immediate values in the first parameter
        /// </summary>
        ImmSlot0 = 2,

        /// <summary>
        /// Classifies operations that accept immediate values in the second parameter
        /// </summary>
        ImmSlot1 = 4,

        /// <summary>
        /// Classifies operations that accept immediate values in the third parameter
        /// </summary>
        ImmSlot2 = 8,

        /// <summary>
        /// Classifies operations that accept immediate values in the fourth parameter
        /// </summary>
        ImmSlot3 = 16,

        /// <summary>
        /// Classifies operations that accept immediate values in the fifth parameter
        /// </summary>
        ImmSlot4 = 32,

        /// <summary>
        /// Classifies operations that immediate one immediate value
        /// </summary>
        ImmCount1 = 64,

        /// <summary>
        /// Classifies operations that immediate two immediate values
        /// </summary>
        ImmCount2 = 128,

        /// <summary>
        /// F:A -> byte -> A
        /// </summary>
        UnaryImm8 = Imm8 | ImmCount1 | ImmSlot1,

        /// <summary>
        /// F:A -> A -> byte -> A
        /// </summary>
        BinaryImm8 = Imm8 | ImmCount1 | ImmSlot2,

        /// <summary>
        /// F:A -> A -> A -> byte -> A
        /// </summary>
        TernaryImm8 = Imm8 | ImmCount1 | ImmSlot3,

        /// <summary>
        /// F:A -> byte -> byte -> A
        /// </summary>
        UnaryImm8x2 = Imm8 | ImmCount2 | ImmSlot1 | ImmSlot2,

        /// <summary>
        /// F:A -> A -> byte -> byte -> A
        /// </summary>
        BinaryImm8x2 = Imm8 | ImmCount2 | ImmSlot2 | ImmSlot3,

        /// <summary>
        /// F:A -> A -> A -> byte -> byte -> A
        /// </summary>
        TernaryImm8x2 = Imm8 | ImmCount2 | ImmSlot3 | ImmSlot4        
    }

    /// <summary>
    /// Identifies a parameter that accepts an immediate value
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class ImmAttribute : Attribute
    {

    }
}