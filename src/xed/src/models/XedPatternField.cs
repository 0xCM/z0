//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public enum XedPatternField : uint
    {
        Class = 0 | 20u << WidthOffset,

        Category = 1 | 14u << WidthOffset,

        Extension = 2 | 14u << WidthOffset,

        IsaSet = 3 | 14u << WidthOffset,

        BaseCode = 4 | 12u << WidthOffset,

        Mod = 5 | 10u << WidthOffset,

        Reg = 6 | 10u << WidthOffset,

        Pattern = 7 | 100u << WidthOffset,

        Operands = 9 | 0u << WidthOffset,
    }
}