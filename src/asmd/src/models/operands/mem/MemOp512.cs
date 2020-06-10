//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public readonly struct MemOp512 : IMemOp512<MemOp512>
    {
        public Fixed512 Value {get;}

        [MethodImpl(Inline)]
        public MemOp512(Fixed512 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W512;
    }
}