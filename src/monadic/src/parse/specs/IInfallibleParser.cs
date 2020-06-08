//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a parser that cannot fail (in theory)
    /// </summary>
    /// <typeparam name="T">The parsed type</typeparam>
    /// <remarks>For this scheme to work, it is incumbent upon the reifying type to return a monoidal zero if malformed text is encountered</remarks>
    public interface IInfallibleParser<T> : ITextParser<T>, INullary<T>        
    {
        new T Parse(string text);

        ParseResult ITextParser.Parse(string text)
            => ParseResult.Success(text, Parse(text));

        ParseResult<T> ITextParser<T>.Parse(string text)
            => ParseResult.Success(text, Parse(text));
    }
}