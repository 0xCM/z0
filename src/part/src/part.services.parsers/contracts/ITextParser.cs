//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a parser that yields values of a parametrically-identified type
    /// </summary>
    /// <typeparam name="T">The type of value that the parser can parse</typeparam>
    public interface ITextParser<T> : IParser<string,T>
    {
        new ParseResult<T> Parse(string src);

        ParseResult<string,T> IParser<string,T>.Parse(string src)
            => Parse(src);
    }
}