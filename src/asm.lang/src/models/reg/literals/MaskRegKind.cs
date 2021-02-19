//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmRegBits;
    using static RegIndex;
    using static RegClass;
    using static RegWidth;

    /// <summary>
    /// Defines classifiers for <see cref='Mask'/> registers of width <see cref='W64'/>
    /// </summary>
    public enum MaskRegKind : uint
    {
        K0 = r0 | Mask << ClassField | W64 << WidthField,

        K1 = r1 | Mask << ClassField | W64 << WidthField,

        K2 = r2 | Mask << ClassField | W64 << WidthField,

        K3 = r3 | Mask << ClassField | W64 << WidthField,

        K4 = r4 | Mask << ClassField | W64 << WidthField,

        K5 = r5 | Mask << ClassField | W64 << WidthField,

        K6 = r6 | Mask << ClassField | W64 << WidthField,

        K7 = r7 | Mask << ClassField | W64 << WidthField,
    }
}