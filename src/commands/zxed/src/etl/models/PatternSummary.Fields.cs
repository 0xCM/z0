//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;

    using static Tabular;

    public enum PatternField : ulong
    {
        Class = 0 | 20ul << WidthOffset,

        Category = 1 | 14ul << WidthOffset,

        Extension = 2 | 14ul << WidthOffset,

        IsaSet = 3 | 14ul << WidthOffset,

        BaseCode = 4 | 12ul << WidthOffset,
        
        Mod = 5 | 10ul << WidthOffset,
        
        Reg = 6 | 10ul << WidthOffset,

        Pattern = 7 | 100ul << WidthOffset,

        Operands = 9 | 0ul << WidthOffset,        
    }
}