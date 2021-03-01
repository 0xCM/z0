//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public enum XedSummaryField : uint
    {
        Class = 0 | 20u << WidthOffset,

        Category = 1 | 14u << WidthOffset,

        Extension = 2 | 14u << WidthOffset,

        IsaSet = 3 | 14u << WidthOffset,

        IForm = 4 | 32u << WidthOffset,

        BaseCode = 5 | 12u << WidthOffset,

        Mod = 6 | 10u << WidthOffset,

        Reg = 7 | 10u << WidthOffset,

        Pattern = 8 | 100u << WidthOffset,

        Operands = 9 | 0u << WidthOffset,
    }
}