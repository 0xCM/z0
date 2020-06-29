//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct m64 : IMemOp64<m64>
    {
        public ulong Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator m64(ulong src)
            => new m64(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(m64 src)
            => src.Content;

        [MethodImpl(Inline)]
        public m64(ulong src)
        {
            Content = src;
        }

        public DataWidth Width 
            => DataWidth.W64;
    }
}