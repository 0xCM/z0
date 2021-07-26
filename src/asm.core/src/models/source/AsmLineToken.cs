//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmLineToken<T>
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public AsmLineToken(T content, AsmLinePart kind)
        {
            Content = content;
        }

        public string Format()
            => Content.ToString();

        public override string ToString()
            => Format();
    }
}