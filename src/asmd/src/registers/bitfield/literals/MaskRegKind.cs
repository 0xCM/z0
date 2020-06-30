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
    /// Defines classifiers for <see cref='Mask'/> registers of width <see cref='W64'/>
    /// </summary>
    public enum MaskRegKind : uint
    {
        K0 = r0 | Mask << ClassIndex | W64 << WidthIndex,

        K1 = r1 | Mask << ClassIndex | W64 << WidthIndex,

        K2 = r2 | Mask << ClassIndex | W64 << WidthIndex,

        K3 = r3 | Mask << ClassIndex | W64 << WidthIndex,

        K4 = r4 | Mask << ClassIndex | W64 << WidthIndex,

        K5 = r5 | Mask << ClassIndex | W64 << WidthIndex,

        K6 = r6 | Mask << ClassIndex | W64 << WidthIndex,

        K7 = r7 | Mask << ClassIndex | W64 << WidthIndex,
    }
}