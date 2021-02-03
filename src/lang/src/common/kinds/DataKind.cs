//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using static Pow2x16;

    [System.Flags]
    public enum DataKind : ushort
    {
        /// <summary>
        /// Classifies unsigned integer types
        /// </summary>
        Unsigned = 0,

        /// <summary>
        /// Classifies the bit type
        /// </summary>
        Bit = P2ᐞ00,

        /// <summary>
        /// Classifies sequential types
        /// </summary>
        Seq = P2ᐞ11,

        /// <summary>
        /// Classifies character types
        /// </summary>
        Char = P2ᐞ12,

        /// <summary>
        /// Classifies string types
        /// </summary>
        String = P2ᐞ13,

        /// <summary>
        /// Classifies floating-point types
        /// </summary>
        Float = P2ᐞ14,

        /// <summary>
        /// Classifies signed integer types
        /// </summary>
        Signed = P2ᐞ15,
    }
}