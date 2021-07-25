//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmLineToken<T> : IAsmLineToken
        where T : IAsmLineToken
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public AsmLineToken(T content, AsmLinePart kind)
        {
            Content = content;
        }

        public AsmLinePart TokenKind
        {
            [MethodImpl(Inline)]
            get => Content.TokenKind;
        }

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();
    }
}