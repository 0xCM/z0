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
        Class = 0 | 20ul << FieldWidthOffset,

        Category = 1 | 14ul << FieldWidthOffset,

        Extension = 2 | 14ul << FieldWidthOffset,

        IsaSet = 3 | 14ul << FieldWidthOffset,

        BaseCode = 4 | 12ul << FieldWidthOffset,
        
        Mod = 5 | 10ul << FieldWidthOffset,
        
        Reg = 6 | 10ul << FieldWidthOffset,

        Pattern = 7 | 100ul << FieldWidthOffset,

        Operands = 9 | 0ul << FieldWidthOffset,        
    }
}