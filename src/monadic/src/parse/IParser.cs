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

    /// <summary>
    /// Characterizes a parser that yields values of a parametrically-identified type
    /// </summary>
    /// <typeparam name="T">The type of value that the parser can parse</typeparam>
    public interface IParser<T> : IParser
    {
        new ParseResult<T> Parse(string text);
        
        T Parse(string src, T @default)
            => Parse(src).ValueOrDefault(@default);
        
        ParseResult IParser.Parse(string text)
            => Parse(text);
    }

    public interface IDataParser<T> : IParser<T>
        where T : unmanaged
    {
        ParseResult<T[]> ParseData(string text);

        T Succeed(string src)
            => Parse(src, default(T));

        T[] ParseData(string text, T[] @default)
            => ParseData(text).ValueOrDefault(@default);
    }

    /// <summary>
    /// Characterizes a non-parametric parser that defines a parametric parse function
    /// </summary>
    public interface IParametricParser
    {
        /// <summary>
        /// Attemps to parse the source text as a parametrically-identified target type
        /// </summary>
        /// <param name="text">The source text</param>
        /// <typeparam name="T">The target type</typeparam>
        ParseResult<T> Parse<T>(string text);

        /// <summary>
        /// Returns a successfully parsed value, if possible; otherwise returns a caller-supplied default value
        /// </summary>
        /// <param name="src">The text to parse</param>
        /// <param name="@default">The value returned if the parse function fails</param>
        /// <typeparam name="T">The target type</typeparam>
        T Parse<T>(string src, T @default)
            => Parse<T>(src).ValueOrDefault(@default);
    }

    /// <summary>
    /// Characterizes a parser that cannot fail (in theory)
    /// </summary>
    /// <typeparam name="T">The parsed type</typeparam>
    /// <remarks>For this scheme to work, it is incumbent upon the reifying type to return a monoidal zero if malformed text is encountered</remarks>
    public interface IInfallibleParser<T> : IParser<T>, INullary<T>        
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