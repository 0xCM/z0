//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ImmOp64 : IImmOp64<ImmOp64>
    {
        public ulong Data {get;}

        [MethodImpl(Inline)]
        public static implicit operator ImmOp64(ulong src)
            => new ImmOp64(src);

        [MethodImpl(Inline)]
        public ImmOp64(ulong value)
        {
            Data = value;
        }
        
        public DataWidth Width => DataWidth.W64;
    }
}