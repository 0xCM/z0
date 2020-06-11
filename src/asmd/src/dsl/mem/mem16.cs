//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct mem16 : IMemOp16<mem16>        
    {
        public Fixed16 Value {get;}


        [MethodImpl(Inline)]
        public mem16(Fixed16 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W16;
    }
}