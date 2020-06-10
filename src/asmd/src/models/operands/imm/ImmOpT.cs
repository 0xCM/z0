//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static ImmOps;

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