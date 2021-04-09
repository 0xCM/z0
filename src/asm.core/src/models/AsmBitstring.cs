//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstring : ITextual
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmBitstring(TextBlock content)
        {
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();
    }

}