//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.llvm;

    using static Root;
    using static core;

    using SZ = AsmPrefixCodes.SizeOverrideCode;
    using SG = AsmPrefixCodes.SegOverrideCode;

    using static AsmOpCodeTokens;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCode define(ushort sdmkey, MC.AsmId asmid, uint encoding, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, asmid, encoding, expr);

        [MethodImpl(Inline), Op]
        public static AsmOpCode define(ushort sdmkey, in CharBlock48 expr)
            => new AsmOpCode(sdmkey, 0, 0, expr);

        [Op]
        public static bit search(ReadOnlySpan<char> src, out ModRmToken dst)
        {
            dst = default;
            var count = src.Length;
            var level = 0;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                switch(level)
                {
                    case 0:
                        switch(c)
                        {
                            case '/':
                                level++;
                            break;
                        }
                    break;
                    case 1:
                    switch(c)
                    {
                        case 'r':
                            dst = ModRmToken.r;
                            return true;
                        case '0':
                            dst = ModRmToken.r0;
                            return true;
                        case '1':
                            dst = ModRmToken.r1;
                            return true;
                        case '2':
                            dst = ModRmToken.r2;
                            return true;
                        case '3':
                            dst = ModRmToken.r3;
                            return true;
                        case '4':
                            dst = ModRmToken.r4;
                            return true;
                        case '5':
                            dst = ModRmToken.r5;
                            return true;
                        case '6':
                            dst = ModRmToken.r6;
                            return true;
                        case '7':
                            dst = ModRmToken.r7;
                            return true;
                    }

                    break;
                }
            }
            return false;
        }

        [Op]
        public static ReadOnlySpan<Token<DispToken>> DispTokens()
            => Tokens.tokenize<DispToken>(DispTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<DispToken>> RexBTokens()
            => Tokens.tokenize<DispToken>(RexBTokenSpec);

        [Op]
        public static ReadOnlySpan<Token<LegacyPrefixToken>> LegacyPrefixTokens()
            => Tokens.tokenize<LegacyPrefixToken>(LegacyPrefixTokenSpec);

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