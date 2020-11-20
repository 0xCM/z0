//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using T = AsmTokenKind;
    using I = AsmTokenIdentifier;
    using P = AsmTokenMeaning;
    using V = AsmTokenValues;

    [ApiType]
    public readonly struct AsmTokens
    {
        public static TokenRecord None => Tokens.record(T.None, I.None, V.None, P.None);

        public static TokenRecord bnd => Tokens.record(T.bnd, I.bnd, V.bnd, P.bnd);

        public static TokenRecord DST => Tokens.record(T.DST, I.DST, V.DST, P.DST);

        public static TokenRecord ᛁerᛁ => Tokens.record(T.ᛁerᛁ, I.ᛁerᛁ, V.ᛁerᛁ, P.ᛁerᛁ);

        public static TokenRecord imm8 => Tokens.record(T.imm8, I.imm8, V.imm8, P.imm8);

        public static TokenRecord imm16 => Tokens.record(T.imm16, I.imm16, V.imm16, P.imm16);

        public static TokenRecord imm32 => Tokens.record(T.imm32, I.imm32, V.imm32, P.imm32);

        public static TokenRecord imm64 => Tokens.record(T.imm64, I.imm64, V.imm64, P.imm64);

        public static TokenRecord k1 => Tokens.record(T.k1, I.k1, V.k1, P.k1);

        public static TokenRecord m => Tokens.record(T.m, I.m, V.m, P.m);

        public static TokenRecord m8 => Tokens.record(T.m8, I.m8, V.m8, P.m8);

        public static TokenRecord m16 => Tokens.record(T.m16, I.m16, V.m16, P.m16);

        public static TokenRecord m32 => Tokens.record(T.m32, I.m32, V.m32, P.m32);

        public static TokenRecord m64 => Tokens.record(T.m64, I.m64, V.m64, P.m64);

        public static TokenRecord m128 => Tokens.record(T.m128, I.m128, V.m128, P.m128);

        public static TokenRecord m16ᙾ16 => Tokens.record(T.m16ᙾ16, I.m16ᙾ16, V.m16ᙾ16, P.m16ᙾ16);

        public static TokenRecord m16ᙾ32 => Tokens.record(T.m16ᙾ32, I.m16ᙾ32, V.m16ᙾ32, P.m16ᙾ32);

        public static TokenRecord m16ᙾ64 => Tokens.record(T.m16ᙾ64, I.m16ᙾ64, V.m16ᙾ64, P.m16ᙾ64);

        public static TokenRecord m16Ʌ32 => Tokens.record(T.m16Ʌ32, I.m16Ʌ32, V.m16Ʌ32, P.m16Ʌ32);

        public static TokenRecord m16Ʌ16 => Tokens.record(T.m16Ʌ16, I.m16Ʌ16, V.m16Ʌ16, P.m16Ʌ16);

        public static TokenRecord m32Ʌ32 => Tokens.record(T.m32Ʌ32, I.m32Ʌ32, V.m32Ʌ32, P.m32Ʌ32);

        public static TokenRecord m16Ʌ64 => Tokens.record(T.m16Ʌ64, I.m16Ʌ64, V.m16Ʌ64, P.m16Ʌ64);

        public static TokenRecord m32fp => Tokens.record(T.m32fp, I.m32fp, V.m32fp, P.m32fp);

        public static TokenRecord m64fp => Tokens.record(T.m64fp, I.m64fp, V.m64fp, P.m64fp);

        public static TokenRecord m80fp => Tokens.record(T.m80fp, I.m80fp, V.m80fp, P.m80fp);

        public static TokenRecord m16int => Tokens.record(T.m16int, I.m16int, V.m16int, P.m16int);

        public static TokenRecord m32int => Tokens.record(T.m32int, I.m32int, V.m32int, P.m32int);

        public static TokenRecord m64int => Tokens.record(T.m64int, I.m64int, V.m64int, P.m64int);

        public static TokenRecord mm => Tokens.record(T.mm, I.mm, V.mm, P.mm);

        public static TokenRecord mmノm32 => Tokens.record(T.mmノm32, I.mmノm32, V.mmノm32, P.mmノm32);

        public static TokenRecord mmノm64 => Tokens.record(T.mmノm64, I.mmノm64, V.mmノm64, P.mmノm64);

        public static TokenRecord mib => Tokens.record(T.mib, I.mib, V.mib, P.mib);

        public static TokenRecord moffs8 => Tokens.record(T.moffs8, I.moffs8, V.moffs8, P.moffs8);

        public static TokenRecord moffs16 => Tokens.record(T.moffs16, I.moffs16, V.moffs16, P.moffs16);

        public static TokenRecord moffs32 => Tokens.record(T.moffs32, I.moffs32, V.moffs32, P.moffs32);

        public static TokenRecord moffs64 => Tokens.record(T.moffs64, I.moffs64, V.moffs64, P.moffs64);

        public static TokenRecord ptr16ᙾ16 => Tokens.record(T.ptr16ᙾ16, I.ptr16ᙾ16, V.ptr16ᙾ16, P.ptr16ᙾ16);

        public static TokenRecord ptr16ᙾ32 => Tokens.record(T.ptr16ᙾ32, I.ptr16ᙾ32, V.ptr16ᙾ32, P.ptr16ᙾ32);

        public static TokenRecord r8  => Tokens.record(T.r8, I.r8, V.r8, P.r8);

        public static TokenRecord r16 => Tokens.record(T.r16, I.r16, V.r16, P.r16);

        public static TokenRecord r32 => Tokens.record(T.r32, I.r32, V.r32, P.r32);

        public static TokenRecord r64 => Tokens.record(T.r64, I.r64, V.r64, P.r64);

        public static TokenRecord rel8 => Tokens.record(T.rel8, I.rel8, V.rel8, P.rel8);

        public static TokenRecord rel16 => Tokens.record(T.rel16, I.rel16, V.rel16, P.rel16);

        public static TokenRecord rel32 => Tokens.record(T.rel32, I.rel32, V.rel32, P.rel32);

        public static TokenRecord rノm8 => Tokens.record(T.rノm8, I.rノm8, V.rノm8, P.rノm8);

        public static TokenRecord rノm16 => Tokens.record(T.rノm16, I.rノm16, V.rノm16, P.rノm16);

        public static TokenRecord rノm32 => Tokens.record(T.rノm32, I.rノm32, V.rノm32, P.rノm32);

        public static TokenRecord rノm64 => Tokens.record(T.rノm64, I.rノm64, V.rノm64, P.rノm64);

        public static TokenRecord Sreg => Tokens.record(T.Sreg, I.Sreg, V.Sreg, P.Sreg);

        public static TokenRecord ᛁsaeᛁ => Tokens.record(T.ᛁsaeᛁ, I.ᛁsaeᛁ, V.ᛁsaeᛁ, P.ᛁsaeᛁ);

        public static TokenRecord SRC => Tokens.record(T.SRC, I.SRC, V.SRC, P.SRC);

        public static TokenRecord SRC1 => Tokens.record(T.SRC1, I.SRC1, V.SRC1, P.SRC1);

        public static TokenRecord SRC2 => Tokens.record(T.SRC2, I.SRC2, V.SRC2, P.SRC2);

        public static TokenRecord SRC3 => Tokens.record(T.SRC3, I.SRC3, V.SRC3, P.SRC3);

        public static TokenRecord ST  => Tokens.record(T.ST, I.ST, V.ST, P.ST);

        public static TokenRecord STᐸ0ᐳ => Tokens.record(T.STᐸ0ᐳ, I.STᐸ0ᐳ, V.STᐸ0ᐳ, P.STᐸ0ᐳ);

        public static TokenRecord xmm => Tokens.record(T.xmm, I.xmm, V.xmm, P.xmm);

        public static TokenRecord xmmノ32 => Tokens.record(T.xmmノ32, I.xmmノ32, V.xmmノ32, P.xmmノ32);

        public static TokenRecord xmmノ64 => Tokens.record(T.xmmノ64, I.xmmノ64, V.xmmノ64, P.xmmノ64);

        public static TokenRecord xmmノ128 => Tokens.record(T.xmmノ128, I.xmmノ128, V.xmmノ128, P.xmmノ128);

        public static TokenRecord ᐸXMM0ᐳ => Tokens.record(T.ᐸXMM0ᐳ, I.ᐸXMM0ᐳ, V.ᐸXMM0ᐳ, P.ᐸXMM0ᐳ);

        public static TokenRecord ymm => Tokens.record(T.ymm, I.ymm, V.ymm, P.ymm);

        public static TokenRecord m256 => Tokens.record(T.m256, I.m256, V.m256, P.m256);

        public static TokenRecord ymmノm256 => Tokens.record(T.ymmノm256, I.ymmノm256, V.ymmノm256, P.ymmノm256);

        public static TokenRecord ᐸYMM0ᐳ => Tokens.record(T.ᐸYMM0ᐳ, I.ᐸYMM0ᐳ, V.ᐸYMM0ᐳ, P.ᐸYMM0ᐳ);

        public static TokenRecord zmm => Tokens.record(T.zmm, I.zmm, V.zmm, P.zmm);

        public static TokenRecord m512 => Tokens.record(T.m512, I.m512, V.m512, P.m512);

        public static TokenRecord zmmノm512 => Tokens.record(T.zmmノm512, I.zmmノm512, V.zmmノm512, P.zmmノm512);

        public static TokenRecord mV => Tokens.record(T.mV, I.mV, V.mV, P.mV);

        public static TokenRecord m32bcst => Tokens.record(T.m32bcst, I.m32bcst, V.m32bcst, P.m32bcst);

        public static TokenRecord m64bcst => Tokens.record(T.m64bcst, I.m64bcst, V.m64bcst, P.m64bcst);

        public static TokenRecord zmmノm512ノm32bcst => Tokens.record(T.zmmノm512ノm32bcst, I.zmmノm512ノm32bcst, V.zmmノm512ノm32bcst, P.zmmノm512ノm32bcst);

        public static TokenRecord zmmノm512ノm64bcst => Tokens.record(T.zmmノm512ノm64bcst, I.zmmノm512ノm64bcst, V.zmmノm512ノm64bcst, P.zmmノm512ノm64bcst);

        public static TokenRecord ᐸZMM0ᐳ => Tokens.record(T.ᐸZMM0ᐳ, I.ᐸZMM0ᐳ, V.ᐸZMM0ᐳ, P.ᐸZMM0ᐳ);
    }
}