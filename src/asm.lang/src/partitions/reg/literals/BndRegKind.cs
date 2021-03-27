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

    public enum BndRegKind : uint
    {
        DR0 = r0 | BND << ClassField | W128 << WidthField,

        DR1 = r1 | BND << ClassField | W128 << WidthField,

        DR2 = r2 | BND << ClassField | W128 << WidthField,

        DR3 = r3 | BND << ClassField | W128 << WidthField,
    }
}