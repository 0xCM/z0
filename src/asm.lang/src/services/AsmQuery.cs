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
    using static AsmInstructions;

    using REP = RepeatPrefixCode;
    using L = LockPrefixCode;
    using SZ = SizeOverrideCode;
    using SG = SegOverrideCode;

    [ApiHost]
    public readonly struct AsmQuery
    {
        const byte MinRexCode = 0x40;

        const byte MaxRexCode = 0x4F;

        [MethodImpl(Inline), Op]
        public static bit IsCallRel32(ReadOnlySpan<byte> src, uint offset)
            => (offset + 4) <= src.Length && skip(src, offset) == 0xE8;

        public static bit TestRel8(AsmHexCode src, Jmp jmp)
        {
            return false;
        }

        public static bit TestRel32(AsmHexCode src, Jmp jmp)
        {
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bit IsRexPrefix(byte src)
            => math.between(src, MinRexCode, MaxRexCode);

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(AsmOpCode src)
            => IsRexPrefix(src.Byte0);

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(AsmHexCode src)
            => IsRexPrefix(skip(src.Bytes,0));

        [MethodImpl(Inline), Op]
        public static bit HasRexPrefix(AsmOpCodeExpr src)
            => src.Content.StartsWith("REX");

        [MethodImpl(Inline), Op]
        public static bit HasRepeatPrefix(AsmOpCode src)
            => emath.oneof(src.Byte0, REP.REPE, REP.REPNE);

        [MethodImpl(Inline), Op]
        public static bit HasLockPrefix(AsmOpCode src)
            => emath.same(L.LOCK, src.Byte0);

        [MethodImpl(Inline), Op]
        public static bit HasSegOverride(AsmOpCode src)
            => emath.oneof(src.Byte0, SegOverrideCodes);

        [MethodImpl(Inline), Op]
        public static bit HasSizeOverride(AsmOpCode src)
            => emath.oneof(src.Byte0, SZ.ADSZ, SZ.OPSZ);

        static ReadOnlySpan<SG> SegOverrideCodes
            => new SG[]{SG.CS, SG.DS, SG.ES, SG.FS, SG.GS, SG.SS};
    }
}