//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmInstructions;

    using REP = RepeatPrefixCode;
    using L = LockPrefixCode;
    using SZ = SizeOverrideCode;
    using SG = SegOverrideCode;
    using R = RexPrefixCode;

    [ApiHost]
    public readonly partial struct AsmQuery
    {
        [MethodImpl(Inline), Op]
        public static bit IsCallRel32(ReadOnlySpan<byte> src, uint offset)
            => skip(src,offset) == 0xE8 && (offset + 4) <= src.Length;

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
            => emath.between(src, R.Rex40, R.Rex4F);

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