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

        public static ParseResult<IdentifiedCode> parseV2(string src)         
        {
            var parts = src.SplitClean(Chars.Pipe);
            var parser = Parsers.hex(true);
            if(parts.Length == 3)
            {
                var address = Parsers.hex().Parse(parts[0]).ValueOrDefault();   
                var uri = OpUriParser.Service.Parse(parts[1].Trim()).Require();
                var bytes = parts[2].SplitClean(HexSpecs.DataDelimiter).Select(parser.Succeed).ToArray();
                return z.parsed(src, new IdentifiedCode(address,uri,bytes));                
            }
            else if(parts.Length == 2)
            {
                var uri = OpUriParser.Service.Parse(src.TakeBefore(Chars.Space).Trim()).Require();
                var bytes = src.TakeAfter(Chars.Space)
                                     .SplitClean(HexSpecs.DataDelimiter)
                                     .Select(parser.Succeed)
                                     .ToArray();
                return z.parsed(src, new IdentifiedCode(0ul, uri, bytes));                
            }
            else
                return z.unparsed<IdentifiedCode>(src);
        }

        public static ParseResult<IdentifiedCode> parse(string src)         
        {
            return parseV2(src);
            // try
            // {
            //     var parser = Parsers.hex(true);
            //     var uri = OpUriParser.Service.Parse(src.TakeBefore(Chars.Space).Trim()).Require();
            //     var bytes = src.TakeAfter(Chars.Space)
            //                          .SplitClean(HexSpecs.DataDelimiter)
            //                          .Select(parser.Succeed)
            //                          .ToArray();
            //     return ParseResult.Success(src, new IdentifiedCode(uri, new BinaryCode(bytes)));
            // }
            // catch(Exception e)
            // {
            //     return ParseResult.Fail<IdentifiedCode>(src,e);
            // }
        }
    }
}