//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp8 : IMemOp8<MemOp8>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public MemOp8(Fixed8 src)
        {
            Value = src;
        }        

        public DataWidth Width => DataWidth.W8;
    }
}