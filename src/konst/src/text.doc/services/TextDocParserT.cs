    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TextDocParser<T> : ITextDocParser<T>
    {
        readonly Func<TextDoc,ParseResult<T>> F;

        [MethodImpl(Inline)]
        public TextDocParser(Func<TextDoc,ParseResult<T>> f)
            => F = f;

        public ParseResult<T> Parse(TextDoc src)
            => F(src);        
    }
}