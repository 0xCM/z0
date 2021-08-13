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
        public static Outcome parse64u(string src, out ulong dst)
            => ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out dst);

        public static Outcome parse32u(string src, out uint dst)
            => uint.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out dst);

        public static Outcome parse16u(string src, out ushort dst)
            => ushort.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out dst);

        public static Outcome parse8u(string src, out byte dst)
            => byte.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out dst);

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

        public static ParseResult<ulong> parse64u(string src)
        {
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return ParseResult.parsed(src,value);
            else
                return ParseResult.unparsed<ulong>(src);
        }
    }
}