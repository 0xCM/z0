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

    public static class HexParser
    {
        const byte MinCode = 48;
        
        const byte MaxLoCode = 57;

        const byte MinHiCode = 65;

        const byte MaxCode = 70;

        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ulong> parse(string src)
            => hexoption(src)
                .MapValueOrElse(
                    value => ParseResult.Success(src,value), 
                    () => ParseResult.Fail<ulong>(src));                    

        public static HexDoc parse(FilePath src)
        {
            var dst = new List<OpExtractSegment>();
            foreach(var line in src.ReadLines())
                HexParser.hexline(line).OnSome(dst.Add);            
            return new HexDoc(dst.ToArray());
        }

        /// <summary>
        /// Parses the Hex digit if possible; otherwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static byte parse(char c)
        {
            var u = Char.ToUpperInvariant(c);
            if(islo(u))
                return (byte)((byte)u - MinCode);
            else if(ishi(u))
                return (byte)((byte)u - MinHiCode + 0xA);
            else
                throw AppErrors.BadArg(c);
        }

        /// <summary>
        /// Parses a hex byte
        /// </summary>
        /// <param name="src">hex text</param>
        public static byte parsebyte(string src)    
            => byte.Parse(clean(src), NumberStyles.HexNumber);

        /// <summary>
        /// Parses a delimited sequence of hex bytes
        /// </summary>
        /// <param name="src">The delimited hex</param>
        /// <param name="sep">The delimiter</param>
        public static IEnumerable<byte> parsebytes(string src, char sep = Chars.Comma)
            => src.Split(sep).Select(parsebyte);
 
        /// <summary>
        /// Parses a row of identified hex text
        /// </summary>
        /// <param name="formatted">The formatted text</param>
        /// <param name="idsep">A character that partitions the identifier and the code</param>
        /// <param name="bytesep">A character that partitions the code bytes</param>
        public static Option<OpExtractSegment> hexline(string formatted, char idsep = OpExtractSegment.DefaultIdSep, char bytesep = OpExtractSegment.DefaultByteSep)
        {
            try
            {
                var id = Identify.Op(formatted.TakeBefore(idsep).Trim());
                var bytes = formatted.TakeAfter(idsep).Split(bytesep, StringSplitOptions.RemoveEmptyEntries).Select(HexParser.parsebyte).ToArray();
                var encoded = MemoryExtract.Define(bytes);
                return OpExtractSegment.Define(id, encoded);                
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<MemoryRange> memrange(string src)    
             => from i0 in src.FirstIndexOf(text.lbracket()).ToOption()
                from i1 in src.FirstIndexOf(text.rbracket()).ToOption()
                let inner = src.Substring(i0 + 1, i1 - i0 - 1)
                let parts = inner.Split(text.comma()).Trim()
                where parts.Length == 2
                from start in HexParser.parse(parts[0]).ToOption()
                from end in HexParser.parse(parts[1]).ToOption()
                select MemoryRange.Define(start, end);

        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        static Option<ulong> hexoption(string src)
        {            
            if(ulong.TryParse(clean(src), NumberStyles.HexNumber, null,  out ulong value))
                return value;
            return default;
        }

        static string clean(string src)
            => src.Remove("0x").RemoveAny('h');

        [MethodImpl(Inline)]
        static bit islo(char c)
            => (byte)c >= MinCode && (byte)c <= MaxLoCode;

        [MethodImpl(Inline)]
        static bit ishi(char c)
            => (byte)c >= MinHiCode && (byte)c <= MaxCode;
    }
}
