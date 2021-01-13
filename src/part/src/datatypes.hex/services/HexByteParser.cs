//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Part;
    using static HexFormatSpecs;
    using static HexCharData;
    using static root;

    public readonly struct HexByteParser : IHexParser<byte>
    {
        public static HexByteParser Service
            => default(HexByteParser);

        public ParseResult<byte> Parse(string src)
        {
            try
            {
                return parsed(src, ParseByte(src));
            }
            catch(Exception e)
            {
                return unparsed<byte>(src, e);
            }
        }

        [MethodImpl(Inline)]
        public bool HasPreSpec(string src)
            => src.TrimStart().StartsWith(PreSpec);

        [MethodImpl(Inline)]
        public bool HasPostSpec(string src)
            => src.TrimEnd().EndsWith(PostSpec);

        /// <summary>
        /// Parses a single hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(HexTest.scalar(c))
                return parsed(c, (byte)((byte)u - MinScalarCode));
            else if(HexTest.upper(c))
                return parsed(c, (byte)((byte)u - MinCharCodeU + 0xA));
            else
                return unparsed<byte>(c);
        }

        /// <summary>
        /// Parses a space-delimited sequence of hex text
        /// </summary>
        /// <param name="src">The space-delimited hex</param>
        public ParseResult<byte[]> ParseData(string src)
        {
            try
            {
                return parsed(src, src.SplitClean(Chars.Space).Select(x => byte.Parse(x, NumberStyles.HexNumber)));
            }
            catch(Exception e)
            {
                return unparsed<byte[]>(src,e);
            }
        }

        public byte Succeed(char c)
            => Parse(c).ValueOrDefault();

        public byte[] Succeed(string text)
            => ParseData(text).ValueOrDefault(Array.Empty<byte>());

        public byte[] ParseData(string text, byte[] @default)
            => ParseData(text).ValueOrDefault(@default);

        /// <summary>
        /// Parses a hex byte
        /// </summary>
        /// <param name="src">hex text</param>
        public byte ParseByte(string src)
            => byte.Parse(ClearSpecs(src), NumberStyles.HexNumber);

        ParseResult<char,byte> IParser<char,byte>.Parse(char src)
        {
            var result = Parse(src);
            return Parser.lift<char,byte>(result);
        }

        public ParseResult Parse(object src)
        {
            if(src is string s)
                return ParseData(s);
            else if(src is char c)
                return Parse(c);
            else
                throw Unsupported.define(src?.GetType() ?? typeof(void));
        }
    }
}