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

    public readonly struct MemOp<T> : IMemOp
        where T : IFixed
    {
        readonly T Value;

        public DataWidth Width => (DataWidth)bitsize<T>();

        [MethodImpl(Inline)]
        public MemOp(T value)
        {
            Value = value;
        }
    }
}