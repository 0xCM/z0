//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;

    public interface ITextDocParser<T> : ITextParser<T>
    {
        ParseResult<T> Parse(TextDoc src);

        ParseResult<T> ITextParser<T>.Parse(string src)
            => TextDocParser.parse(src,Parse);
    }
}