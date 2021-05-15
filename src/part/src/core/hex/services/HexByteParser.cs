//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static HexFormatSpecs;
    using static root;
    using static core;

    [ApiHost]
    public readonly struct HexByteParser : IHexParser<byte>
    {
        public static HexByteParser Service
            => default(HexByteParser);

        [Op]
        public static bool parse(string src, out BinaryCode dst)
        {
            try
            {
                var s0 = text.trim(src);
                var len = s0.Length;
                if(HexFormat.HasPreSpec(s0))
                    s0 = text.slice(s0, len - PreSpec.Length);
                else if(HexFormat.HasPostSpec(s0))
                    s0 = text.slice(s0, 0, len - PostSpec.Length);
                var blocks = text.split(s0, Chars.Space).View;
                var count = blocks.Length;
                var buffer = alloc<byte>(count);
                ref var target = ref first(buffer);
                for(var i=0; i<count; i++)
                    seek(target,count-1-i) = byte.Parse(skip(blocks,i), NumberStyles.HexNumber);
                dst = buffer;

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

        /// <summary>
        /// Parses a single hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [Op]
        public ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(Hex.scalar(c))
                return parsed(c, (byte)((byte)u - MinScalarCode));
            else if(Hex.upper(c))
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

        /// <summary>
        /// Parses a space-delimited sequence of hex text
        /// </summary>
        /// <param name="src">The space-delimited hex</param>
        public static Outcome ParseData(string src, out Index<byte> dst)
        {
            try
            {
                dst = src.SplitClean(Chars.Space).Select(x => byte.Parse(x, NumberStyles.HexNumber));
                return true;
            }
            catch(Exception e)
            {
                dst = Index<byte>.Empty;
                return (e,$"Input:{src}");
            }
        }

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