//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines segment register classifiers
    /// </summary>
    /// <remarks>Derived from SegRegBits.csv</remarks>
    public enum SegRegKind : byte
    {
        /// <summary>
        /// Code segment register; contains the segment offset address of the executing instruction in a code segment
        /// </summary>
        CS = 0,

        /// <summary>
        /// Data segment register; contains offset address of data/variables
        /// </summary>
        DS = 1,

        /// <summary>
        /// Stack segment register; contains the offset address of the stack segment
        /// </summary>
        SS = 2,

        /// <summary>
        /// Extra segment (1); contains offset address of arbitrary kind
        /// </summary>
        ES = 3,

        /// <summary>
        /// Extra segment (2); contains offset address of arbitrary kind
        /// </summary>
        FS = 4,

        /// <summary>
        /// Extra segment (3); contains offset address of arbitrary kind
        /// </summary>
        GS = 5
    }
}