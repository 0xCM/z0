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
        // {
        //     using var stream = text.stream(src);
        //     using var reader = new StreamReader(stream);
        //     return TextDocParser.parse(reader).TryMap(Parse).ValueOrDefault(ParseResult.Fail<T>(src));            
        // }
    }
}