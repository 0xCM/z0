//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct mem64 : IMemOp64<mem64>
    {
        public Fixed64 Value {get;}

        [MethodImpl(Inline)]
        public mem64(Fixed64 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W64;
    }
}