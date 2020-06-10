//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemOp16 : IMemOp16<MemOp16>        
    {
        public Fixed16 Value {get;}


        [MethodImpl(Inline)]
        public MemOp16(Fixed16 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W16;
    }
}