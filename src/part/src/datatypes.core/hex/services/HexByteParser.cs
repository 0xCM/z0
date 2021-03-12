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
    using static TextRules;
    using static root;
    using static memory;

    using P = TextRules.Parse;

    [ApiHost]
    public readonly struct HexByteParser : IHexParser<byte>
    {
        public static HexByteParser Service
            => default(HexByteParser);

        /// <summary>
        /// Parses a single hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline), Op]
        public static bool parse(char c, out byte dst)
        {
            if(HexDigitTest.scalar(c))
            {
                dst = (byte)((byte)c - MinScalarCode);
                return true;
            }
            else if(HexDigitTest.upper(c))
            {
                dst = (byte)((byte)c - MinCharCodeU + 0xA);
                return true;
            }
            else if(HexDigitTest.lower(c))
            {
                dst = (byte)((byte)c - MinCharCodeL + 0xa);
                return true;
            }
            dst = byte.MaxValue;
            return false;
        }


        [Op]
        public static bool parse(string src, out byte[] dst)
        {
            try
            {
                var s0 = text.trim(src);
                var len = s0.Length;
                if(HexFormat.HasPreSpec(s0))
                    s0 = text.slice(s0, len - PreSpec.Length);
                else if(HexFormat.HasPostSpec(s0))
                    s0 = text.slice(s0, 0, len - PostSpec.Length);
                var blocks = P.split(s0, Chars.Space);
                dst = blocks.Select(x => byte.Parse(x, NumberStyles.HexNumber));
                return true;
            }
            catch(Exception)
            {
                dst = Array.Empty<byte>();
                return false;
            }
        }


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

        public int Parse(string src, Span<byte> dst)
        {
            const char Null = (char)0;
            try
            {
                var input = span(src);
                var maxbytes = dst.Length;
                var j=0;
                var count = input.Length;
                var c0 = Null;
                var c1 = Null;
                for(var i=0; i<count; i++)
                {
                    if(j == maxbytes)
                        return j;

                    ref readonly var c = ref skip(input,i);
                    if(Query.whitespace(c))
                    {
                        if(c0 != Null || c1 != Null)
                        {
                            if(Parse(c0, c1, out seek(dst,j)))
                                j++;
                            c0 = Null;
                            c1 = Null;
                        }
                    }

                    else
                    {
                        if(c0 == Null)
                            c0 = c;
                        else if(c1 == Null)
                            c1 = c;
                        else
                        {
                            if(Parse(c0, c1, out seek(dst,j)))
                                j++;
                            c0 = Null;
                            c1 = Null;
                        }
                    }
                }

                return j;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        [Op]
        public bool Parse(char c0, char c1, out byte dst)
        {
            if(parse(c0, out var d0) && parse(c1, out var d1))
            {
                dst = (byte)(d0 | (d1 << 8));
                return true;
            }
            dst = 0;
            return false;
        }


        /// <summary>
        /// Parses a single hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [Op]
        public ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(HexDigitTest.scalar(c))
                return parsed(c, (byte)((byte)u - MinScalarCode));
            else if(HexDigitTest.upper(c))
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