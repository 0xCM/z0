//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    using DW = DataWidth;

    [Flags]
    public enum OperandSize : uint
    {
        None = 0,

        W8 = DW.W8,

        W16 = DW.W16,

        W32 = DW.W32,

        W64 = DW.W64,

        W128 = DW.W128,

        W256 = DW.W256,

        W512 = DW.W512,
    }

}