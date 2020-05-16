//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public enum OperationMode : byte
    {
        None = 0,

        Legacy = 1,

        Compatibility = 2,

        Mode64 = 3,
    }
}
