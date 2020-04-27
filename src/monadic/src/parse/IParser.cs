//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public interface IParser
    {
        ParseResult Parse(string text);
    }    

    public interface IParser<T> : IParser
    {
        new ParseResult<T> Parse(string text);

        ParseResult IParser.Parse(string text)
            => Parse(text);
    }

    public interface IStreamParser<P,T> : IParser<T>
        where P : IParser<T>
    {
        IEnumerable<ParseResult<T>> Parse(IEnumerable<string> src)
            => src.Select(Parse);
    }

    public interface IArrayParser<P,T> : IStreamParser<P,T>
        where P : IParser<T>
    {
        ParseResult<T>[] Parse(params string[] src)
            => (this as IStreamParser<P,T>).Parse(src).ToArray();
    }

    public interface IParser<P,T> : IParser<T>
        where P : IParser<P,T>, new()
    {
        
    }

}