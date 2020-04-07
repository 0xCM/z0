//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IParser : IService
    {
        ParseResult Parse(string text);
    }    

    public interface IParser<T> : IParser
    {
        new ParseResult<T> Parse(string text);

        ParseResult IParser.Parse(string text)
            => Parse(text);
    }

    public interface IParser<P,T> : IParser<T>
        where P : IParser<P,T>, new()
    {
        
    }

}