//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Konst;
    using static HexSpecs;
    using static core;

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
            => src.TrimStart().StartsWith(HexSpecs.PreSpec);

        [MethodImpl(Inline)]
        public bool HasPostSpec(string src) 
            => src.TrimEnd().EndsWith(HexSpecs.PostSpec);

        /// <summary>
        /// Parses a single hex digit
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(Hex.isNumber(c))
                return parsed(c, (byte)((byte)u - Hex.MinScalarCode));
            else if(Hex.isUpper(c))
                return parsed(c, (byte)((byte)u - Hex.MinCharCodeU + 0xA));
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
                return parsed(src, 
                    src.SplitClean(Chars.Space)
                       .Select(x => byte.Parse(x, NumberStyles.HexNumber)));
            }
            catch(Exception e)
            {
                return unparsed<byte[]>(src,e);
            }
        }

        public byte[] ParseData(string text, byte[] @default)
            => ParseData(text).ValueOrDefault(@default);

        /// <summary>
        /// Parses a hex byte
        /// </summary>
        /// <param name="src">hex text</param>
        public byte ParseByte(string src)    
            => byte.Parse(ClearSpecs(src), NumberStyles.HexNumber);
    }
}