//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct MemOp128 : IMemOp128<MemOp128>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public MemOp128(Fixed128 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W128;
    }
}