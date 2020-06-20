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
        public static ITextParser<UriHex> Service => default(UriHexParser);

        public static ParseResult<UriHex> parse(string src)         
        {
            try
            {
                var parser = Parsers.hex(true);
                var uri = OpUriParser.Service.Parse(src.TakeBefore(Chars.Space).Trim()).ToOption().Require();
                var bytes = src.TakeAfter(Chars.Space)
                                     .SplitClean(HexSpecs.DataDelimiter)
                                     .Select(parser.Succeed)
                                     .ToArray();
                return ParseResult.Success(src, new UriHex(uri, new BinaryCode(bytes)));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<UriHex>(src,e);
            }
        }
    }
}