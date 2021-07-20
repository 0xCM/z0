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

    using REP = AsmCodes.RepeatPrefix;
    using L = AsmCodes.LockPrefixCode;
    using SZ = AsmCodes.SizeOverrideCode;
    using SG = AsmCodes.SegOverride;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        const byte MinRexCode = 0x40;

        const byte MaxRexCode = 0x4F;

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(in AsmOpCodeExpr src)
            => src.Data.Contains("REX", StringComparison.InvariantCultureIgnoreCase);

        [MethodImpl(Inline), Op]
        public static bit IsCallRel32(ReadOnlySpan<byte> src, uint offset)
            => (offset + 4) <= src.Length && skip(src, offset) == 0xE8;

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(AsmOpCode src)
            => IsRexPrefix(src.Lead);

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(AsmHexCode src)
            => IsRexPrefix(skip(src.Bytes,0));

        [MethodImpl(Inline), Op]
        public static bit IsRexPrefix(byte src)
            => math.between(src, MinRexCode, MaxRexCode);

        [MethodImpl(Inline), Op]
        public static bit HasRepeatPrefix(AsmOpCode src)
            => emath.oneof(src.Lead, REP.REPNZ, REP.REPZ);

        [MethodImpl(Inline), Op]
        public static bit HasLockPrefix(AsmOpCode src)
            => emath.same(L.LOCK, src.Lead);

        [MethodImpl(Inline), Op]
        public static bit HasSegOverride(AsmOpCode src)
            => emath.oneof(src.Lead, SegOverrideCodes);

        [MethodImpl(Inline), Op]
        public static bit HasSizeOverride(AsmOpCode src)
            => emath.oneof(src.Lead, SZ.ADSZ, SZ.OPSZ);

        static ReadOnlySpan<SG> SegOverrideCodes
            => new SG[]{SG.CS, SG.DS, SG.ES, SG.FS, SG.GS, SG.SS};

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(DispToken disp)
        //     => new AsmOpCode((uint)disp);

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(EscapePrefix escape, byte a)
        //     => new AsmOpCode((uint32(a) << 8) | ((uint)escape));

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(EscapePrefix escape, byte a, byte b)
        //     => new AsmOpCode((uint32(a) << 16) | (uint32(b) << 8) | escape);

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a)
        //     => new AsmOpCode((uint32(a) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a, byte b)
        //     => new AsmOpCode((uint32(a) << 24) | (uint32(b) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        // /// <summary>
        // /// Example: XOR r/m32, imm8 | 83 /6 ib
        // /// Example: AND r/m8,imm8 | 80 /4 ib
        // /// </summary>
        // /// <param name="b0">The first opcode byte</param>
        // /// <param name="ext">The register field digit</param>
        // /// <param name="iz">The imm size</param>
        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(byte b0, ModRmDigit ext, ImmSize iz)
        //     => opcode(b0, (byte)ext, (byte)iz, TokenKind.RexBExtension | TokenKind.ImmSize);

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(byte b0, ImmSize iz)
        //     => opcode(b0,(byte)iz, 0, TokenKind.ImmSize);

        // [MethodImpl(Inline), Op]
        // public static AsmOpCode opcode(byte b0, byte b1, byte b2, TokenKind b3)
        //     => new AsmOpCode(
        //         bw32(b0) |
        //         (bw32(b1) << 8) |
        //         (bw32(b2) << 16) |
        //         (bw32(b3) << 24)
        //         );
    }
}