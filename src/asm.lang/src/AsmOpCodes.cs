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

    using R = RepeatPrefixCode;
    using L = LockPrefixCode;
    using S = SizeOverrideCode;
    using REX = RexPrefixCode;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static byte part(AsmOpCode src, N0 n)
            => @as<AsmOpCode,byte>(src);

        [MethodImpl(Inline), Op]
        public static byte part(AsmOpCode src, N1 n)
            => uint8(@as<AsmOpCode,uint>(src) >> 8);

        [MethodImpl(Inline), Op]
        public static byte part(AsmOpCode src, N2 n)
            => uint8(@as<AsmOpCode,uint>(src) >> 16);

        [MethodImpl(Inline), Op]
        public static bit escaped(AsmOpCode src)
            => emath.oneof(src.Byte0, EscapeCode.x0f, EscapeCode.x66);

        [MethodImpl(Inline), Op]
        public static bit locked(AsmOpCode src)
            => emath.same(L.Lock, src.Byte0);

        [MethodImpl(Inline), Op]
        public static bit rep(AsmOpCode src)
            => emath.oneof(src.Byte0, R.REPE, R.REPNE);

        [MethodImpl(Inline), Op]
        public static bit sizeov(AsmOpCode src)
            => emath.oneof(src.Byte0, S.Address, S.Operand);

        [MethodImpl(Inline), Op]
        public static bit rex(AsmOpCode src)
            => emath.oneof(src.Byte0, REX.Rex40, REX.RexWRXB);

        [MethodImpl(Inline), Op]
        public static RegDigit digit(uint3 src)
            => new RegDigit(src);
    }
}