//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBitFields;
    using static RegisterCode;
    using static RegisterClass;
    using static RegisterWidth;

    /// <summary>
    /// Defines <see cref='SEG'/> register classifiers
    /// </summary>
    public enum SegRegKind : uint
    {
        /// <summary>
        /// Code segment register; contains the segment offset address of the executing instruction in a code segment
        /// </summary>
        CS = r0 | SEG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Data segment register; contains offset address of data/variables
        /// </summary>
        DS = r1 | SEG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Stack segment register; contains the offset address of the stack segment
        /// </summary>
        SS = r2 | SEG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Extra segment (1); contains offset address of arbitrary kind
        /// </summary>
        ES = r3 | SEG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Extra segment (2); contains offset address of arbitrary kind
        /// </summary>
        FS = r4 | SEG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Extra segment (3); contains offset address of arbitrary kind
        /// </summary>
        GS = r5 | SEG << ClassIndex | W16 << WidthIndex,
    }
}