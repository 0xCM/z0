//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp64 : IMemOp64<MemOp64>
    {
        public Fixed64 Value {get;}

        [MethodImpl(Inline)]
        public MemOp64(Fixed64 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W64;
    }
}