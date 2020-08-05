//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tokens
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    using T = AsmTokenKind;
    using I = AsmTokenId;
    using P = AsmTokenMeaning;
    using V = AsmTokenValues;

    [ApiDataType]
    public readonly struct AsmTokens
    {
        public static TokenModel None => TokenModel.Define(T.None, I.None, V.None, P.None);

        public static TokenModel bnd => TokenModel.Define(T.bnd, I.bnd, V.bnd, P.bnd);

        public static TokenModel DST => TokenModel.Define(T.DST, I.DST, V.DST, P.DST);

        public static TokenModel ᛁerᛁ => TokenModel.Define(T.ᛁerᛁ, I.ᛁerᛁ, V.ᛁerᛁ, P.ᛁerᛁ);

        public static TokenModel imm8 => TokenModel.Define(T.imm8, I.imm8, V.imm8, P.imm8);

        public static TokenModel imm16 => TokenModel.Define(T.imm16, I.imm16, V.imm16, P.imm16);

        public static TokenModel imm32 => TokenModel.Define(T.imm32, I.imm32, V.imm32, P.imm32);

        public static TokenModel imm64 => TokenModel.Define(T.imm64, I.imm64, V.imm64, P.imm64);

        public static TokenModel k1 => TokenModel.Define(T.k1, I.k1, V.k1, P.k1);

        public static TokenModel m => TokenModel.Define(T.m, I.m, V.m, P.m);

        public static TokenModel m8 => TokenModel.Define(T.m8, I.m8, V.m8, P.m8);

        public static TokenModel m16 => TokenModel.Define(T.m16, I.m16, V.m16, P.m16);

        public static TokenModel m32 => TokenModel.Define(T.m32, I.m32, V.m32, P.m32);

        public static TokenModel m64 => TokenModel.Define(T.m64, I.m64, V.m64, P.m64);

        public static TokenModel m128 => TokenModel.Define(T.m128, I.m128, V.m128, P.m128);

        public static TokenModel m16ᙾ16 => TokenModel.Define(T.m16ᙾ16, I.m16ᙾ16, V.m16ᙾ16, P.m16ᙾ16);

        public static TokenModel m16ᙾ32 => TokenModel.Define(T.m16ᙾ32, I.m16ᙾ32, V.m16ᙾ32, P.m16ᙾ32);

        public static TokenModel m16ᙾ64 => TokenModel.Define(T.m16ᙾ64, I.m16ᙾ64, V.m16ᙾ64, P.m16ᙾ64);

        public static TokenModel m16Ʌ32 => TokenModel.Define(T.m16Ʌ32, I.m16Ʌ32, V.m16Ʌ32, P.m16Ʌ32);

        public static TokenModel m16Ʌ16 => TokenModel.Define(T.m16Ʌ16, I.m16Ʌ16, V.m16Ʌ16, P.m16Ʌ16);

        public static TokenModel m32Ʌ32 => TokenModel.Define(T.m32Ʌ32, I.m32Ʌ32, V.m32Ʌ32, P.m32Ʌ32);

        public static TokenModel m16Ʌ64 => TokenModel.Define(T.m16Ʌ64, I.m16Ʌ64, V.m16Ʌ64, P.m16Ʌ64);

        public static TokenModel m32fp => TokenModel.Define(T.m32fp, I.m32fp, V.m32fp, P.m32fp);

        public static TokenModel m64fp => TokenModel.Define(T.m64fp, I.m64fp, V.m64fp, P.m64fp);

        public static TokenModel m80fp => TokenModel.Define(T.m80fp, I.m80fp, V.m80fp, P.m80fp);

        public static TokenModel m16int => TokenModel.Define(T.m16int, I.m16int, V.m16int, P.m16int);

        public static TokenModel m32int => TokenModel.Define(T.m32int, I.m32int, V.m32int, P.m32int);

        public static TokenModel m64int => TokenModel.Define(T.m64int, I.m64int, V.m64int, P.m64int);

        public static TokenModel mm => TokenModel.Define(T.mm, I.mm, V.mm, P.mm);

        public static TokenModel mmノm32 => TokenModel.Define(T.mmノm32, I.mmノm32, V.mmノm32, P.mmノm32);

        public static TokenModel mmノm64 => TokenModel.Define(T.mmノm64, I.mmノm64, V.mmノm64, P.mmノm64);

        public static TokenModel mib => TokenModel.Define(T.mib, I.mib, V.mib, P.mib);

        public static TokenModel moffs8 => TokenModel.Define(T.moffs8, I.moffs8, V.moffs8, P.moffs8);

        public static TokenModel moffs16 => TokenModel.Define(T.moffs16, I.moffs16, V.moffs16, P.moffs16);

        public static TokenModel moffs32 => TokenModel.Define(T.moffs32, I.moffs32, V.moffs32, P.moffs32);

        public static TokenModel moffs64 => TokenModel.Define(T.moffs64, I.moffs64, V.moffs64, P.moffs64);

        public static TokenModel ptr16ᙾ16 => TokenModel.Define(T.ptr16ᙾ16, I.ptr16ᙾ16, V.ptr16ᙾ16, P.ptr16ᙾ16);

        public static TokenModel ptr16ᙾ32 => TokenModel.Define(T.ptr16ᙾ32, I.ptr16ᙾ32, V.ptr16ᙾ32, P.ptr16ᙾ32);

        public static TokenModel r8  => TokenModel.Define(T.r8, I.r8, V.r8, P.r8);

        public static TokenModel r16 => TokenModel.Define(T.r16, I.r16, V.r16, P.r16);

        public static TokenModel r32 => TokenModel.Define(T.r32, I.r32, V.r32, P.r32);

        public static TokenModel r64 => TokenModel.Define(T.r64, I.r64, V.r64, P.r64);

        public static TokenModel rel8 => TokenModel.Define(T.rel8, I.rel8, V.rel8, P.rel8);
        
        public static TokenModel rel16 => TokenModel.Define(T.rel16, I.rel16, V.rel16, P.rel16);
        
        public static TokenModel rel32 => TokenModel.Define(T.rel32, I.rel32, V.rel32, P.rel32);
        
        public static TokenModel rノm8 => TokenModel.Define(T.rノm8, I.rノm8, V.rノm8, P.rノm8);
        
        public static TokenModel rノm16 => TokenModel.Define(T.rノm16, I.rノm16, V.rノm16, P.rノm16);
        
        public static TokenModel rノm32 => TokenModel.Define(T.rノm32, I.rノm32, V.rノm32, P.rノm32);
        
        public static TokenModel rノm64 => TokenModel.Define(T.rノm64, I.rノm64, V.rノm64, P.rノm64);
        
        public static TokenModel Sreg => TokenModel.Define(T.Sreg, I.Sreg, V.Sreg, P.Sreg);
        
        public static TokenModel ᛁsaeᛁ => TokenModel.Define(T.ᛁsaeᛁ, I.ᛁsaeᛁ, V.ᛁsaeᛁ, P.ᛁsaeᛁ);
        
        public static TokenModel SRC => TokenModel.Define(T.SRC, I.SRC, V.SRC, P.SRC);
        
        public static TokenModel SRC1 => TokenModel.Define(T.SRC1, I.SRC1, V.SRC1, P.SRC1);
        
        public static TokenModel SRC2 => TokenModel.Define(T.SRC2, I.SRC2, V.SRC2, P.SRC2);
        
        public static TokenModel SRC3 => TokenModel.Define(T.SRC3, I.SRC3, V.SRC3, P.SRC3);

        public static TokenModel ST  => TokenModel.Define(T.ST, I.ST, V.ST, P.ST);

        public static TokenModel STᐸ0ᐳ => TokenModel.Define(T.STᐸ0ᐳ, I.STᐸ0ᐳ, V.STᐸ0ᐳ, P.STᐸ0ᐳ);

        public static TokenModel xmm => TokenModel.Define(T.xmm, I.xmm, V.xmm, P.xmm);

        public static TokenModel xmmノ32 => TokenModel.Define(T.xmmノ32, I.xmmノ32, V.xmmノ32, P.xmmノ32);

        public static TokenModel xmmノ64 => TokenModel.Define(T.xmmノ64, I.xmmノ64, V.xmmノ64, P.xmmノ64);

        public static TokenModel xmmノ128 => TokenModel.Define(T.xmmノ128, I.xmmノ128, V.xmmノ128, P.xmmノ128);

        public static TokenModel ᐸXMM0ᐳ => TokenModel.Define(T.ᐸXMM0ᐳ, I.ᐸXMM0ᐳ, V.ᐸXMM0ᐳ, P.ᐸXMM0ᐳ);

        public static TokenModel ymm => TokenModel.Define(T.ymm, I.ymm, V.ymm, P.ymm);

        public static TokenModel m256 => TokenModel.Define(T.m256, I.m256, V.m256, P.m256);

        public static TokenModel ymmノm256 => TokenModel.Define(T.ymmノm256, I.ymmノm256, V.ymmノm256, P.ymmノm256);

        public static TokenModel ᐸYMM0ᐳ => TokenModel.Define(T.ᐸYMM0ᐳ, I.ᐸYMM0ᐳ, V.ᐸYMM0ᐳ, P.ᐸYMM0ᐳ);

        public static TokenModel zmm => TokenModel.Define(T.zmm, I.zmm, V.zmm, P.zmm);

        public static TokenModel m512 => TokenModel.Define(T.m512, I.m512, V.m512, P.m512);

        public static TokenModel zmmノm512 => TokenModel.Define(T.zmmノm512, I.zmmノm512, V.zmmノm512, P.zmmノm512);

        public static TokenModel mV => TokenModel.Define(T.mV, I.mV, V.mV, P.mV);

        public static TokenModel m32bcst => TokenModel.Define(T.m32bcst, I.m32bcst, V.m32bcst, P.m32bcst);

        public static TokenModel m64bcst => TokenModel.Define(T.m64bcst, I.m64bcst, V.m64bcst, P.m64bcst);

        public static TokenModel zmmノm512ノm32bcst => TokenModel.Define(T.zmmノm512ノm32bcst, I.zmmノm512ノm32bcst, V.zmmノm512ノm32bcst, P.zmmノm512ノm32bcst);

        public static TokenModel zmmノm512ノm64bcst => TokenModel.Define(T.zmmノm512ノm64bcst, I.zmmノm512ノm64bcst, V.zmmノm512ノm64bcst, P.zmmノm512ノm64bcst);

        public static TokenModel ᐸZMM0ᐳ => TokenModel.Define(T.ᐸZMM0ᐳ, I.ᐸZMM0ᐳ, V.ᐸZMM0ᐳ, P.ᐸZMM0ᐳ);  
    }
}