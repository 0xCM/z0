//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct UriHexParser : IUriHexParser
    {
        public static ITextParser<IdentifiedCode> Service => default(UriHexParser);

        public static ParseResult<IdentifiedCode> parse(string src)         
        {
            try
            {
                var parser = Parsers.hex(true);
                var uri = OpUriParser.Service.Parse(src.TakeBefore(Chars.Space).Trim()).Require();
                var bytes = src.TakeAfter(Chars.Space)
                                     .SplitClean(HexSpecs.DataDelimiter)
                                     .Select(parser.Succeed)
                                     .ToArray();
                return ParseResult.Success(src, new IdentifiedCode(uri, new BinaryCode(bytes)));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<IdentifiedCode>(src,e);
            }
        }
    }
}