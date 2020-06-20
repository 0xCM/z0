//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct mem128 : IMemOp128<mem128>
    {
        public Fixed128 Value {get;}

        [MethodImpl(Inline)]
        public mem128(Fixed128 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W128;
    }
}