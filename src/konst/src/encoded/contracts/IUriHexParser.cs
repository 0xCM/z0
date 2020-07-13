//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IUriHexParser : ITextParser<IdentifiedCode>
    {
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        ParseResult<IdentifiedCode> ITextParser<IdentifiedCode>.Parse(string src)
            => UriHexParser.parse(src);
    }
}