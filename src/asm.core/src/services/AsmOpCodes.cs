//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using SZ = AsmPrefixCodes.SizeOverrideCode;
    using SG = AsmPrefixCodes.SegOverrideCode;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static bit IsCallRel32(ReadOnlySpan<byte> src, uint offset)
            => (offset + 4) <= src.Length && skip(src, offset) == 0xE8;

        [MethodImpl(Inline), Op]
        public static bit HasSegOverride(AsmOpCode src)
            => emath.oneof(src.Lead, SegOverrideCodes);

        [MethodImpl(Inline), Op]
        public static bit HasSizeOverride(AsmOpCode src)
            => emath.oneof(src.Lead, SZ.ADSZ, SZ.OPSZ);

        static ReadOnlySpan<SG> SegOverrideCodes
            => new SG[]{SG.CS, SG.DS, SG.ES, SG.FS, SG.GS, SG.SS};

        const string LegacyPrefixTokens =
            "66\0" +
            "F2\0" +
            "F3\0" +
            "0F\0" +
            "0F38\0";

        const string ModRMTokens =
            "/r\0" +
            "/0\0" +
            "/1\0" +
            "/2\0" +
            "/3\0" +
            "/4\0" +
            "/5\0" +
            "/6\0" +
            "/7\0";

        const string RexPrefixTokens =
            "REX\0" +
            "REX.W\0" +
            "REX.R\0" +
            "REX.X\0" +
            "REX.B\0";

        const string EVexTokens =
            "EVEX\0" +
            "VEX\0" +
            "LZ\0" +
            "LIG\0" +
            "WIG\0" +
            "W0\0" +
            "W1\0" +
            "W128\0" +
            "W256\0" +
            "W512\0";

        const string SegOverrideTokens =
            "CS\0" +
            "SS\0" +
            "DS\0" +
            "ES\0" +
            "FS\0" +
            "GS\0";

        const string ImmSizeTokens =
            "ib\0" +
            "iw\0" +
            "id\0" +
            "io\0";

        static string[] FpuDigitTokens = new string[]
        {
            "+0\0" +
            "+1\0" +
            "+2\0" +
            "+3\0" +
            "+4\0" +
            "+5\0" +
            "+6\0" +
            "+7\0"
        };

        const string MaskTokens =
            "{k1}\0" +
            "{k1}{z}\0";

        const string ExclusionTokens =
            "NP\0" +
            "NFx\0";
    }
}