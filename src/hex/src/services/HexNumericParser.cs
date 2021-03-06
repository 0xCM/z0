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

    [ApiHost]
    public readonly struct HexNumericParser
    {
        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ulong> parse64u(string src)
        {
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return ParseResult.parsed(src,value);
            else
                return ParseResult.unparsed<ulong>(src);
        }

        public static Outcome parse64u(string src, out ulong dst)
        {
            var result = parse64u(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        public static Outcome parse32u(string src, out uint dst)
        {
            var result = parse32u(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        public static Outcome parse16u(string src, out ushort dst)
        {
            var result = parse16u(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        public static Outcome parse8u(string src, out byte dst)
        {
            var result = parse8u(src);
            if(result)
            {
                dst = result.Value;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<uint> parse32u(string src)
        {
            if(uint.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out uint value))
                return ParseResult.parsed(src,value);
            else
                return ParseResult.unparsed<uint>(src);
        }

        /// <summary>
        /// Attempts to parse a hex string as a uint16
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ushort> parse16u(string src)
        {
            if(ushort.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ushort value))
                return ParseResult.parsed(src,value);
            else
                return ParseResult.unparsed<ushort>(src);
        }

        /// <summary>
        /// Attempts to parse a hex string as a uint8
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<byte> parse8u(string src)
        {
            if(byte.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out byte value))
                return ParseResult.parsed(src,value);
            else
                return ParseResult.unparsed<byte>(src);
        }

        public static Outcome parse(string src, out Hex8 dst)
        {
            var outcome = parse8u(src, out var x);
            dst = x;
            return outcome;
        }

        public static Outcome parse(string src, out Hex16 dst)
        {
            var outcome = parse16u(src, out var x);
            dst = x;
            return outcome;
        }

        public static Outcome parse(string src, out Hex32 dst)
        {
            var outcome = parse32u(src, out var x);
            dst = x;
            return outcome;
        }

        public static Outcome parse(string src, out Hex64 dst)
        {
            var outcome = parse64u(src, out var x);
            dst = x;
            return outcome;
        }
    }
}