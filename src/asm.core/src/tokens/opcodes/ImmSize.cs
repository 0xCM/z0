//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmOpCodeTokens
    {
        public readonly struct ImmSize
        {
            public ImmSizeKind Token {get;}

            [MethodImpl(Inline)]
            public ImmSize(ImmSizeKind src)
            {
                Token = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator ImmSize(ImmSizeKind src)
                => new ImmSize(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmSizeKind(ImmSize src)
                => src.Token;

            [MethodImpl(Inline)]
            public static explicit operator byte(ImmSize src)
                => (byte)src.Token;
        }
    }
}