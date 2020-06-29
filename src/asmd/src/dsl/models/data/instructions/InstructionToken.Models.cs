//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static InstructionTokenModels;

    using T = InstructionTokenKind;
    using I = InstructionTokenId;
    using P = InstructionTokenMeaning;
    using V = InstructionTokenValues;

    readonly partial struct InstructionTokenInfo
    {
        public static TokenInfo[] Models
            => new TokenInfo[TokenCount]{ 
                None, bnd, DST, ᛁerᛁ,  imm8, imm16, imm32, imm64, k1, m, m8, 
                m16, m32, m64, m128, m16ᙾ16, m16ᙾ32, m16ᙾ64, m16Ʌ32, m16Ʌ16,
                m32Ʌ32, m16Ʌ64, m32fp, m64fp, m80fp, m16int, m32int, m64int,
                mm, mmノm32, mmノm64, mib, moffs8, moffs16, moffs32, moffs64,
                ptr16ᙾ16, ptr16ᙾ32, r8, r16, r32, r64, rel8, rel16, rel32,
                rノm8, rノm16, rノm32,  rノm64, Sreg, ᛁsaeᛁ, SRC, SRC1, SRC2,
                SRC3, ST, STᐸ0ᐳ, xmm, xmmノ32, xmmノ64, xmmノ128, ᐸXMM0ᐳ,
                ymm, m256, ymmノm256, ᐸYMM0ᐳ, zmm, m512, zmmノm512,
                mV, m32bcst, m64bcst, zmmノm512ノm32bcst, zmmノm512ノm64bcst,
                ᐸZMM0ᐳ,
            };                
    }

    readonly struct InstructionTokenModels
    {
        public static TokenInfo None => TokenInfo.Define(T.None, I.None, V.None, P.None);

        public static TokenInfo bnd => TokenInfo.Define(T.bnd, I.bnd, V.bnd, P.bnd);

        public static TokenInfo DST => TokenInfo.Define(T.DST, I.DST, V.DST, P.DST);

        public static TokenInfo ᛁerᛁ => TokenInfo.Define(T.ᛁerᛁ, I.ᛁerᛁ, V.ᛁerᛁ, P.ᛁerᛁ);

        public static TokenInfo imm8 => TokenInfo.Define(T.imm8, I.imm8, V.imm8, P.imm8);

        public static TokenInfo imm16 => TokenInfo.Define(T.imm16, I.imm16, V.imm16, P.imm16);

        public static TokenInfo imm32 => TokenInfo.Define(T.imm32, I.imm32, V.imm32, P.imm32);

        public static TokenInfo imm64 => TokenInfo.Define(T.imm64, I.imm64, V.imm64, P.imm64);

        public static TokenInfo k1 => TokenInfo.Define(T.k1, I.k1, V.k1, P.k1);

        public static TokenInfo m => TokenInfo.Define(T.m, I.m, V.m, P.m);

        public static TokenInfo m8 => TokenInfo.Define(T.m8, I.m8, V.m8, P.m8);

        public static TokenInfo m16 => TokenInfo.Define(T.m16, I.m16, V.m16, P.m16);

        public static TokenInfo m32 => TokenInfo.Define(T.m32, I.m32, V.m32, P.m32);

        public static TokenInfo m64 => TokenInfo.Define(T.m64, I.m64, V.m64, P.m64);

        public static TokenInfo m128 => TokenInfo.Define(T.m128, I.m128, V.m128, P.m128);

        public static TokenInfo m16ᙾ16 => TokenInfo.Define(T.m16ᙾ16, I.m16ᙾ16, V.m16ᙾ16, P.m16ᙾ16);

        public static TokenInfo m16ᙾ32 => TokenInfo.Define(T.m16ᙾ32, I.m16ᙾ32, V.m16ᙾ32, P.m16ᙾ32);

        public static TokenInfo m16ᙾ64 => TokenInfo.Define(T.m16ᙾ64, I.m16ᙾ64, V.m16ᙾ64, P.m16ᙾ64);

        public static TokenInfo m16Ʌ32 => TokenInfo.Define(T.m16Ʌ32, I.m16Ʌ32, V.m16Ʌ32, P.m16Ʌ32);

        public static TokenInfo m16Ʌ16 => TokenInfo.Define(T.m16Ʌ16, I.m16Ʌ16, V.m16Ʌ16, P.m16Ʌ16);

        public static TokenInfo m32Ʌ32 => TokenInfo.Define(T.m32Ʌ32, I.m32Ʌ32, V.m32Ʌ32, P.m32Ʌ32);

        public static TokenInfo m16Ʌ64 => TokenInfo.Define(T.m16Ʌ64, I.m16Ʌ64, V.m16Ʌ64, P.m16Ʌ64);

        public static TokenInfo m32fp => TokenInfo.Define(T.m32fp, I.m32fp, V.m32fp, P.m32fp);

        public static TokenInfo m64fp => TokenInfo.Define(T.m64fp, I.m64fp, V.m64fp, P.m64fp);

        public static TokenInfo m80fp => TokenInfo.Define(T.m80fp, I.m80fp, V.m80fp, P.m80fp);

        public static TokenInfo m16int => TokenInfo.Define(T.m16int, I.m16int, V.m16int, P.m16int);

        public static TokenInfo m32int => TokenInfo.Define(T.m32int, I.m32int, V.m32int, P.m32int);

        public static TokenInfo m64int => TokenInfo.Define(T.m64int, I.m64int, V.m64int, P.m64int);

        public static TokenInfo mm => TokenInfo.Define(T.mm, I.mm, V.mm, P.mm);

        public static TokenInfo mmノm32 => TokenInfo.Define(T.mmノm32, I.mmノm32, V.mmノm32, P.mmノm32);

        public static TokenInfo mmノm64 => TokenInfo.Define(T.mmノm64, I.mmノm64, V.mmノm64, P.mmノm64);

        public static TokenInfo mib => TokenInfo.Define(T.mib, I.mib, V.mib, P.mib);

        public static TokenInfo moffs8 => TokenInfo.Define(T.moffs8, I.moffs8, V.moffs8, P.moffs8);

        public static TokenInfo moffs16 => TokenInfo.Define(T.moffs16, I.moffs16, V.moffs16, P.moffs16);

        public static TokenInfo moffs32 => TokenInfo.Define(T.moffs32, I.moffs32, V.moffs32, P.moffs32);

        public static TokenInfo moffs64 => TokenInfo.Define(T.moffs64, I.moffs64, V.moffs64, P.moffs64);

        public static TokenInfo ptr16ᙾ16 => TokenInfo.Define(T.ptr16ᙾ16, I.ptr16ᙾ16, V.ptr16ᙾ16, P.ptr16ᙾ16);

        public static TokenInfo ptr16ᙾ32 => TokenInfo.Define(T.ptr16ᙾ32, I.ptr16ᙾ32, V.ptr16ᙾ32, P.ptr16ᙾ32);

        public static TokenInfo r8  => TokenInfo.Define(T.r8, I.r8, V.r8, P.r8);

        public static TokenInfo r16 => TokenInfo.Define(T.r16, I.r16, V.r16, P.r16);

        public static TokenInfo r32 => TokenInfo.Define(T.r32, I.r32, V.r32, P.r32);

        public static TokenInfo r64 => TokenInfo.Define(T.r64, I.r64, V.r64, P.r64);

        public static TokenInfo rel8 => TokenInfo.Define(T.rel8, I.rel8, V.rel8, P.rel8);
        
        public static TokenInfo rel16 => TokenInfo.Define(T.rel16, I.rel16, V.rel16, P.rel16);
        
        public static TokenInfo rel32 => TokenInfo.Define(T.rel32, I.rel32, V.rel32, P.rel32);
        
        public static TokenInfo rノm8 => TokenInfo.Define(T.rノm8, I.rノm8, V.rノm8, P.rノm8);
        
        public static TokenInfo rノm16 => TokenInfo.Define(T.rノm16, I.rノm16, V.rノm16, P.rノm16);
        
        public static TokenInfo rノm32 => TokenInfo.Define(T.rノm32, I.rノm32, V.rノm32, P.rノm32);
        
        public static TokenInfo rノm64 => TokenInfo.Define(T.rノm64, I.rノm64, V.rノm64, P.rノm64);
        
        public static TokenInfo Sreg => TokenInfo.Define(T.Sreg, I.Sreg, V.Sreg, P.Sreg);
        
        public static TokenInfo ᛁsaeᛁ => TokenInfo.Define(T.ᛁsaeᛁ, I.ᛁsaeᛁ, V.ᛁsaeᛁ, P.ᛁsaeᛁ);
        
        public static TokenInfo SRC => TokenInfo.Define(T.SRC, I.SRC, V.SRC, P.SRC);
        
        public static TokenInfo SRC1 => TokenInfo.Define(T.SRC1, I.SRC1, V.SRC1, P.SRC1);
        
        public static TokenInfo SRC2 => TokenInfo.Define(T.SRC2, I.SRC2, V.SRC2, P.SRC2);
        
        public static TokenInfo SRC3 => TokenInfo.Define(T.SRC3, I.SRC3, V.SRC3, P.SRC3);

        public static TokenInfo ST  => TokenInfo.Define(T.ST, I.ST, V.ST, P.ST);

        public static TokenInfo STᐸ0ᐳ => TokenInfo.Define(T.STᐸ0ᐳ, I.STᐸ0ᐳ, V.STᐸ0ᐳ, P.STᐸ0ᐳ);

        public static TokenInfo xmm => TokenInfo.Define(T.xmm, I.xmm, V.xmm, P.xmm);

        public static TokenInfo xmmノ32 => TokenInfo.Define(T.xmmノ32, I.xmmノ32, V.xmmノ32, P.xmmノ32);

        public static TokenInfo xmmノ64 => TokenInfo.Define(T.xmmノ64, I.xmmノ64, V.xmmノ64, P.xmmノ64);

        public static TokenInfo xmmノ128 => TokenInfo.Define(T.xmmノ128, I.xmmノ128, V.xmmノ128, P.xmmノ128);

        public static TokenInfo ᐸXMM0ᐳ => TokenInfo.Define(T.ᐸXMM0ᐳ, I.ᐸXMM0ᐳ, V.ᐸXMM0ᐳ, P.ᐸXMM0ᐳ);

        public static TokenInfo ymm => TokenInfo.Define(T.ymm, I.ymm, V.ymm, P.ymm);

        public static TokenInfo m256 => TokenInfo.Define(T.m256, I.m256, V.m256, P.m256);

        public static TokenInfo ymmノm256 => TokenInfo.Define(T.ymmノm256, I.ymmノm256, V.ymmノm256, P.ymmノm256);

        public static TokenInfo ᐸYMM0ᐳ => TokenInfo.Define(T.ᐸYMM0ᐳ, I.ᐸYMM0ᐳ, V.ᐸYMM0ᐳ, P.ᐸYMM0ᐳ);

        public static TokenInfo zmm => TokenInfo.Define(T.zmm, I.zmm, V.zmm, P.zmm);

        public static TokenInfo m512 => TokenInfo.Define(T.m512, I.m512, V.m512, P.m512);

        public static TokenInfo zmmノm512 => TokenInfo.Define(T.zmmノm512, I.zmmノm512, V.zmmノm512, P.zmmノm512);

        public static TokenInfo mV => TokenInfo.Define(T.mV, I.mV, V.mV, P.mV);

        public static TokenInfo m32bcst => TokenInfo.Define(T.m32bcst, I.m32bcst, V.m32bcst, P.m32bcst);

        public static TokenInfo m64bcst => TokenInfo.Define(T.m64bcst, I.m64bcst, V.m64bcst, P.m64bcst);

        public static TokenInfo zmmノm512ノm32bcst => TokenInfo.Define(T.zmmノm512ノm32bcst, I.zmmノm512ノm32bcst, V.zmmノm512ノm32bcst, P.zmmノm512ノm32bcst);

        public static TokenInfo zmmノm512ノm64bcst => TokenInfo.Define(T.zmmノm512ノm64bcst, I.zmmノm512ノm64bcst, V.zmmノm512ノm64bcst, P.zmmノm512ノm64bcst);

        public static TokenInfo ᐸZMM0ᐳ => TokenInfo.Define(T.ᐸZMM0ᐳ, I.ᐸZMM0ᐳ, V.ᐸZMM0ᐳ, P.ᐸZMM0ᐳ);  
    }
}