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

    public enum FpuRegKind : uint
    {
        ST0 = r0 | ST << ClassField | W80 << WidthField,

        ST1 = r1 | ST << ClassField | W80 << WidthField,

        ST2 = r2 | ST << ClassField | W80 << WidthField,

        ST3 = r3 | ST << ClassField | W80 << WidthField,

        ST4 = r4 | ST << ClassField | W80 << WidthField,

        ST5 = r5 | ST << ClassField | W80 << WidthField,

        ST6 = r6 | ST << ClassField | W80 << WidthField,

        ST7 = r7 | ST << ClassField | W80 << WidthField,
    }
}