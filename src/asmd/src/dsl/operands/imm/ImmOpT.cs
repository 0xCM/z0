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
    
    public readonly struct ImmOp<T> : IImmOp<T>
        where T : unmanaged, IFixed
    {
        public T Value {get;}

        public DataWidth Width => (DataWidth)bitsize<T>();

        [MethodImpl(Inline)]
        public ImmOp(T value)
        {
            Value = value;
        }
    }
}