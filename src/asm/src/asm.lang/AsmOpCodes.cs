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

    using static AsmOpCodeModel;

    using R = RepeatPrefixCode;
    using L = LockPrefixCode;
    using S = SizeOverrideCode;
    using REX = RexPrefixCode;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static byte part(OpCodeEncoding src, N0 n)
            => @as<OpCodeEncoding,byte>(src);

        [MethodImpl(Inline), Op]
        public static byte part(OpCodeEncoding src, N1 n)
            => uint8(@as<OpCodeEncoding,uint>(src) >> 8);

        [MethodImpl(Inline), Op]
        public static byte part(OpCodeEncoding src, N2 n)
            => uint8(@as<OpCodeEncoding,uint>(src) >> 16);

        [MethodImpl(Inline), Op]
        public static bit escaped(OpCodeEncoding src)
            => emath.oneof(src.Byte0, EscapeCode.x0f, EscapeCode.x66);

        [MethodImpl(Inline), Op]
        public static bit locked(OpCodeEncoding src)
            => emath.eq(L.Lock, src.Byte0);

        [MethodImpl(Inline), Op]
        public static bit rep(OpCodeEncoding src)
            => emath.oneof(src.Byte0, R.REPE, R.REPNE);

        [MethodImpl(Inline), Op]
        public static bit sizeov(OpCodeEncoding src)
            => emath.oneof(src.Byte0, S.Address, S.Operand);

        [MethodImpl(Inline), Op]
        public static bit rex(OpCodeEncoding src)
            => emath.oneof(src.Byte0, REX.Rex40, REX.RexWRXB);

        [MethodImpl(Inline), Op]
        public static AsmRegDigit digit(uint3 src)
            => new AsmRegDigit(src);
    }
}