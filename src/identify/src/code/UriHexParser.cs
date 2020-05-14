//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct UriHexParser : IParser<UriHex>
    {
        public static IParser<UriHex> Service => default(UriHexParser);
        
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        public ParseResult<UriHex> Parse(string src)
        {
            try
            {
                var parser = HexParsers.Bytes;
                var uri = OpUri.Parse(src.TakeBefore(Chars.Space).Trim()).ToOption().Require();
                var bytes = src.TakeAfter(Chars.Space)
                                     .Split(HexSpecs.DataDelimiter, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(parser.Succeed)
                                     .ToArray();
                return ParseResult.Success(src, new UriHex(uri, BinaryCode.Define(bytes)));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<UriHex>(src,e);
            }
        }
    }
}