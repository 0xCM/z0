//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct mem8 : IMemOp8<mem8>
    {
        public Fixed8 Value {get;}

        [MethodImpl(Inline)]
        public mem8(Fixed8 src)
        {
            Value = src;
        }        

        public DataWidth Width => DataWidth.W8;
    }
}