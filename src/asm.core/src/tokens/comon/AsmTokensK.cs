//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmTokens<K>
        where K : unmanaged
    {
        public Symbols<K> Symbols {get;}

        [MethodImpl(Inline)]
        public AsmTokens(Symbols<K> src)
        {
            Symbols = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmTokens<K>(Symbols<K> src)
            => new AsmTokens<K>(src);
    }
}