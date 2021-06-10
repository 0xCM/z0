//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    using T = AsmOpCodeTokens;

    public readonly struct ImmSize
    {
        public const T.ImmSize ib = T.ImmSize.ib;

        public const T.ImmSize iw = T.ImmSize.iw;

        public const T.ImmSize id = T.ImmSize.id;

        public const T.ImmSize io = T.ImmSize.io;

        public T.ImmSize Token {get;}

        [MethodImpl(Inline)]
        public ImmSize(T.ImmSize src)
        {
            Token = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator ImmSize(T.ImmSize src)
            => new ImmSize(src);

        [MethodImpl(Inline)]
        public static implicit operator T.ImmSize(ImmSize src)
            => src.Token;
    }
}