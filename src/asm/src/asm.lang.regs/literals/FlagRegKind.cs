//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBits;
    using static RegIndex;
    using static RegClass;
    using static RegWidth;

    /// <summary>
    /// Defines flag register classifiers
    /// </summary>
    public enum FlagRegKind : uint
    {
        /// <summary>
        /// Indicates the 16-bit FLAGS register
        /// </summary>
        Flags = r0 | FLAG << ClassIndex | W16 << WidthIndex,

        /// <summary>
        /// Indicates the 32-bit EFLAGS register
        /// </summary>
        EFlags = r0 | FLAG << ClassIndex | W32 << WidthIndex,

        /// <summary>
        /// Indicates the 64-bit RFLAGS register
        /// </summary>
        RFlags = r0 | FLAG << ClassIndex | W64 << WidthIndex,
    }
}