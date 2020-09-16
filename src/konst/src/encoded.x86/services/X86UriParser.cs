//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct X86UriParser : ITextParser<X86UriHex>
    {
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        ParseResult<X86UriHex> ITextParser<X86UriHex>.Parse(string src)
            => parse(src);

        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="src">The formatted text</param>
        public static Option<X86UriHex> row(string src)
        {
            try
            {
                var parser = Parsers.hex(true);
                var uritext = src.TakeBefore(Chars.Space).Trim();
                var uri = ApiUriParser.operation(uritext);
                var bytes = src.TakeAfter(Chars.Space).SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed);
                if(uri)
                    return new X86UriHex(MemoryAddress.Empty, uri.Value, bytes);
                else
                    return Option.none<X86UriHex>();

            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        public static ParseResult<X86UriHex> parse(string src)
        {
            var parts = src.SplitClean(Chars.Pipe);
            var parser = Parsers.hex(true);
            if(parts.Length == 3)
            {
                var address = Parsers.hex().Parse(parts[0]).ValueOrDefault();
                var uri = ApiUriParser.operation(parts[1].Trim()).Require();
                var bytes = parts[2].SplitClean(HexFormatSpecs.DataDelimiter).Select(parser.Succeed).ToArray();
                return z.parsed(src, new X86UriHex(address,uri,bytes));
            }
            else if(parts.Length == 2)
            {
                var uri = ApiUriParser.Service.Parse(src.TakeBefore(Chars.Space).Trim()).Require();
                var bytes = src.TakeAfter(Chars.Space)
                                     .SplitClean(HexFormatSpecs.DataDelimiter)
                                     .Select(parser.Succeed)
                                     .ToArray();
                return z.parsed(src, new X86UriHex(0ul, uri, bytes));
            }
            else
                return z.unparsed<X86UriHex>(src);
        }
    }
}