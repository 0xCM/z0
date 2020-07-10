//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextParser
    {
        ParseResult Parse(string text);
    }    

    /// <summary>
    /// Characterizes a parser that yields values of a parametrically-identified type
    /// </summary>
    /// <typeparam name="T">The type of value that the parser can parse</typeparam>
    public interface ITextParser<T> : ITextParser
    {
        new ParseResult<T> Parse(string src);
        
        T Parse(string src, T @default)
            => Parse(src).ValueOrDefault(@default);
        
        ParseResult ITextParser.Parse(string src)
            => Parse(src);
    }
}