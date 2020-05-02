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

    /// <summary>
    /// Characterizes a parser that cannot fail (in theory)
    /// </summary>
    /// <typeparam name="T">The parsed type</typeparam>
    /// <remarks>For this scheme to work, it is incumbent upon the reifying type to return a monoidal zero if malformed text is encountered</remarks>
    public interface ISuccessfulParser<T> : IParser<T>, INullary<T>        
    {
        new T Parse(string text);

        ParseResult IParser.Parse(string text)
            => ParseResult.Success(text, Parse(text));

        ParseResult<T> IParser<T>.Parse(string text)
            => ParseResult.Success(text, Parse(text));
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

    public class ParserAttribute : Attribute
    {

        

    }
}