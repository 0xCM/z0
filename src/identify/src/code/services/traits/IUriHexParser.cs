//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IUriHexParser : ITextParser<UriHex>
    {
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        ParseResult<UriHex> ITextParser<UriHex>.Parse(string src)
            => UriHexParser.parse(src);
    }
}