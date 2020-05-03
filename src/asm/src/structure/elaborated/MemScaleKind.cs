//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    public enum MemScaleKind : byte
    {
        None  = 0,

        S1 = 1,

        S2 = 2,

        S4 = 4,

        S8 = 8
    }

}