//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using llvm;

    using static Root;
    using static core;
    using static AsmOpCodeTokens;

    using SZ = AsmPrefixCodes.SizeOverrideCode;
    using SG = AsmPrefixCodes.SegOverrideCode;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static AsmOpCodeBits bits()
            => new AsmOpCodeBits(0);

         [MethodImpl(Inline), Op, Closures(Closure)]
         public static AsmOcToken<K> token<K>(AsmOcTokenKind kind, K value)
            where K : unmanaged
                => new AsmOcToken<K>(kind,value);
         [Op]
         public static ReadOnlySpan<Token<DispToken>> DispTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<DispToken>(out data);

         [Op]
         public static ReadOnlySpan<Token<AsmId>> AsmIdTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<AsmId>(out data);

        [Op]
        public static ReadOnlySpan<Token<DispToken>> ImmSizeTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<DispToken>(out data);

        [Op]
        public static ReadOnlySpan<Token<DispToken>> RexBTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<DispToken>(out data);

        [Op]
        public static ReadOnlySpan<Token<ModRmToken>> ModRmTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<ModRmToken>(out data);

        public static ReadOnlySpan<Token> OpCodeTokens()
            => AsmTokens.OpCodes.create().View;

        [Op]
        public static ReadOnlySpan<Token<RexToken>> RexTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<RexToken>(out data);

        [Op]
        public static ReadOnlySpan<Token<MaskToken>> MaskTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<MaskToken>(out data);

        [Op]
        public static ReadOnlySpan<Token<VexToken>> VexTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<VexToken>(out data);

        [Op]
        public static ReadOnlySpan<Token<OpCodeOperator>> OperatorTokens(out ReadOnlySpan<byte> data)
            => Tokens.tokenize<OpCodeOperator>(out data);

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
   }
}