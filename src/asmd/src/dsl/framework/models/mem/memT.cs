//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Memories;

    public readonly struct mem<T> : IMemOp
        where T : IFixed
    {
        readonly T Value;

        public BitSize Width 
            => bitsize<T>();

        [MethodImpl(Inline)]
        public mem(T value)
        {
            Value = value;
        }
    }
}