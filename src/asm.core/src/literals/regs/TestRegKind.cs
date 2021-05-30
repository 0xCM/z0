//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegFacets;
    using static RegIndex;
    using static RegClass;
    using static RegWidth;

    public enum TestRegKind : uint
    {
        TR0 = r0 | Mask << ClassField | W64 << WidthField,

        TR1 = r1 | Mask << ClassField | W64 << WidthField,

        TR2 = r2 | Mask << ClassField | W64 << WidthField,

        TR3 = r3 | Mask << ClassField | W64 << WidthField,

        TR4 = r4 | Mask << ClassField | W64 << WidthField,

        TR5 = r5 | Mask << ClassField | W64 << WidthField,

        TR6 = r6 | Mask << ClassField | W64 << WidthField,

        TR7 = r7 | Mask << ClassField | W64 << WidthField,
    }
}