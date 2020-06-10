//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct MemOp256 : IMemOp256<MemOp256>
    {
        public Fixed256 Value {get;}

        [MethodImpl(Inline)]
        public MemOp256(Fixed256 src)
        {
            Value = src;
        }

        public DataWidth Width => DataWidth.W256;
    }
}