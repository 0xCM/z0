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

    public readonly struct HexByteParser : IHexParser<byte>
    {    
        public static HexByteParser Service => default(HexByteParser);
        
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

        [MethodImpl(Inline)]
        public bool HasPreSpec(string src) 
            => src.TrimStart().StartsWith(HexSpecs.PreSpec);

        [MethodImpl(Inline)]
        public bool HasPostSpec(string src) 
            => src.TrimEnd().EndsWith(HexSpecs.PostSpec);

        /// <summary>
        /// Parses the Hex digit if possible; otherwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public ParseResult<byte> Parse(char c)
            => HexSpecs.Parse(c);

        /// <summary>
        /// Parses a space-delimited sequence of hex text
        /// </summary>
        /// <param name="src">The space-delimited hex</param>
        public ParseResult<byte[]> ParseData(string src)
        {
            try
            {
                return ParseResult.Success(src, 
                    src.SplitClean(Chars.Space)
                       .Select(x => byte.Parse(x, NumberStyles.HexNumber)));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<byte[]>(src,e);
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