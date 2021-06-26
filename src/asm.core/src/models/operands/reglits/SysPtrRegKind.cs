//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegFacets;
    using static RegIndexCode;
    using static RegClass;
    using static RegWidth;

    public enum SysPtrRegKind : uint
    {
        GDTR = r0 | SPTR << ClassField | W64 << WidthField,

        LDTR = r1 | SPTR << ClassField | W64 << WidthField,

        IDTR = r2 | SPTR << ClassField | W64 << WidthField,
    }
}