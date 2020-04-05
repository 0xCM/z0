//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using static Seed;
    using static HexSpecs;

    public readonly struct HexByteParser : IParser<byte>
    {    
        public static HexByteParser Default
        {
            [MethodImpl(Inline)]
            get => default(HexByteParser);
        }

        public ParseResult<byte> Parse(string src) 
        {
            try
            { 
                return ParseResult.Success(src, ParseByte(src));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<byte>(src, e);
            }
        }

        /// <summary>
        /// Parses a hex byte
        /// </summary>
        /// <param name="src">hex text</param>
        public byte ParseByte(string src)    
            => byte.Parse(ClearSpecs(src), NumberStyles.HexNumber);

        /// <summary>
        /// Parses a delimited sequence of hex bytes
        /// </summary>
        /// <param name="src">The delimited hex</param>
        /// <param name="sep">The delimiter</param>
        public IEnumerable<byte> ParseBytes(string src, char sep = Chars.Comma)
            => src.Split(sep).Select(ParseByte); 

        /// <summary>
        /// Parses the Hex digit if possible; otherwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public ParseResult<byte> Parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(IsScalar(c))
                return ParseResult.Success(c, (byte)((byte)u - MinScalarCode));
            else if(IsUpperChar(c))
                return ParseResult.Success(c,  (byte)((byte)u - MinCharCodeU + 0xA));
            else
                return ParseResult.Fail<byte>(c);
        }

    }
}    
