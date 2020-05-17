//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;

    using static Tabular;

    public enum OpCodeField : ulong
    {
        Id = 0 | 50ul << WidthOffset,

        CodeBytes = (0xFF & Id + 1) | 16ul << WidthOffset,

        Prefix = (0xFF & CodeBytes + 1) | 8ul << WidthOffset,

        Table = (0xFF & Prefix + 1) | 8ul << WidthOffset,

        Group = (0xFF & Table + 1) | 8ul << WidthOffset,

        Op1 = (0xFF & Group + 1) | 20ul << WidthOffset,

        Op2 = (0xFF & Op1 + 1) | 20ul << WidthOffset,

        Op3 = (0xFF & Op2 + 1) | 20ul << WidthOffset,

        Op4 = (0xFF & Op3 + 1) | 20ul << WidthOffset,

        OpSize = (0xFF & Op4 + 1) | 10ul << WidthOffset,

        AddressSize = (0xFF & OpSize + 1) | 14ul << WidthOffset,

        Flags = (0xFF & Op4 + 1),
    }
}