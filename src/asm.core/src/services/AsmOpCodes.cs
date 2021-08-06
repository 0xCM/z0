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

    using static AsmOpCodeTokens;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [Op]
        public static ReadOnlySpan<Token<DispToken>> DispTokens()
            => Tokens.tokenize<DispToken>(DispTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<DispToken>> RexBTokens()
            => Tokens.tokenize<DispToken>(RexBTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<ModRmToken>> ModRmTokens()
            => Tokens.tokenize<ModRmToken>(ModRMTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<RexToken>> RexTokens()
            => Tokens.tokenize<RexToken>(RexTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<VexToken>> VexTokens()
            => Tokens.tokenize<VexToken>(VexTokenSpec);

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

        const string LegacyPrefixTokenSpec =
            "66\0" +
            "F2\0" +
            "F3\0" +
            "0F\0" +
            "0F38\0";

        const string ModRMTokenSpec =
            "/r\0" +
            "/0\0" +
            "/1\0" +
            "/2\0" +
            "/3\0" +
            "/4\0" +
            "/5\0" +
            "/6\0" +
            "/7\0";

        const string RexTokenSpec =
            "REX\0" +
            "REX.W\0" +
            "REX.R\0" +
            "REX.X\0" +
            "REX.B\0";

        const string VexTokenSpec =
            "VEX\0" +
            "LZ\0" +
            "LIG\0" +
            "WIG\0" +
            "W0\0" +
            "W1\0" +
            "W128\0" +
            "W256\0";

        const string EVexTokenSpec =
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

        const string SegOverrideTokenSpec =
            "CS\0" +
            "SS\0" +
            "DS\0" +
            "ES\0" +
            "FS\0" +
            "GS\0";

        const string ImmSizeTokenSpec =
            "ib\0" +
            "iw\0" +
            "id\0" +
            "io\0";

        const string FpuDigitTokenSpec =
            "+0\0" +
            "+1\0" +
            "+2\0" +
            "+3\0" +
            "+4\0" +
            "+5\0" +
            "+6\0" +
            "+7\0";

        const string MaskTokenSpec =
            "{k1}\0" +
            "{k1}{z}\0";

        const string ExclusionTokens =
            "NP\0" +
            "NFx\0";

        const string RexBTokenSpec =
            "+rb\0" +
            "+rw\0" +
            "+rd\0" +
            "+ro\0" +
            "N.A.\0" +
            "N.E\0";

        const string DispTokenSpec =
            "cb\0" +
            "cw\0" +
            "cd\0" +
            "cp\0" +
            "co\0" +
            "ct\0";
    }
}