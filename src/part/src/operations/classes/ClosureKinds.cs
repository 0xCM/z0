//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum NatClosureKind : byte
    {
        None = 0,

        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set naturals
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of naturals
        /// </summary>
        Range = 2,

        /// <summary>
        /// Indicates closure is specified for an inclusive power-of-two range specified by a min/max pair
        /// </summary>
        Powers2 = 3,

        /// <summary>
        /// Indicates closure is specified for explicit pairs of natural numbers
        /// </summary>
        ExplicitPairs,
    }

    public enum ImmClosureKind : byte
    {
        None = 0,

        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set of immediates
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for a range of immediates
        /// </summary>
        Range = 2,

        /// <summary>
        /// Indicates closure is specified for an inclusive range of powers of 2
        /// </summary>
        Powers2 = 3,
    }

    public enum WidthClosureKind : byte
    {
        None = 0,

        /// <summary>
        /// Indicates closure is specified for an explicitly-specified set naturals
        /// </summary>
        Individuals = 1,

        /// <summary>
        /// Indicates closure is specified for a continuous power-of-two sequence
        /// </summary>
        Range = 2,
    }

    public enum TypeClosureKind : byte
    {
        None = 0,

        Numeric = 1,

        Natural = 2,

        Imm8 = 3,

        Width = 4,

        Fixed = 5,

        NaturalPairs = 6,

        Opaque = 7,
    }
}