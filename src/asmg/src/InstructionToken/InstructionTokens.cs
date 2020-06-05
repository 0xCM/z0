//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    
    using T = InstructionToken;
    using I = InstructionTokenId;
    using P = InstructionTokenPurpose;
    using V = InstructionTokenValue;

    public class InstructionTokens
    {
        public static Token None => Token.Define(T.None, I.None, V.None, P.None);

        public static Token bnd => Token.Define(T.bnd, I.bnd, V.bnd, P.bnd);

        public static Token DST => Token.Define(T.DST, I.DST, V.DST, P.DST);

        public static Token ᛁerᛁ => Token.Define(T.ᛁerᛁ, I.ᛁerᛁ, V.ᛁerᛁ, P.ᛁerᛁ);

        public static Token imm8 => Token.Define(T.imm8, I.imm8, V.imm8, P.imm8);

        public static Token imm16 => Token.Define(T.imm16, I.imm16, V.imm16, P.imm16);

        public static Token imm32 => Token.Define(T.imm32, I.imm32, V.imm32, P.imm32);

        public static Token imm64 => Token.Define(T.imm64, I.imm64, V.imm64, P.imm64);

        public static Token k1 => Token.Define(T.k1, I.k1, V.k1, P.k1);

        public static Token m => Token.Define(T.m, I.m, V.m, P.m);

        public static Token m8 => Token.Define(T.m8, I.m8, V.m8, P.m8);

        public static Token m16 => Token.Define(T.m16, I.m16, V.m16, P.m16);

        public static Token m32 => Token.Define(T.m32, I.m32, V.m32, P.m32);

        public static Token m64 => Token.Define(T.m64, I.m64, V.m64, P.m64);

        public static Token m128 => Token.Define(T.m128, I.m128, V.m128, P.m128);

        public static Token m16ᙾ16 => Token.Define(T.m16ᙾ16, I.m16ᙾ16, V.m16ᙾ16, P.m16ᙾ16);

        public static Token m16ᙾ32 => Token.Define(T.m16ᙾ32, I.m16ᙾ32, V.m16ᙾ32, P.m16ᙾ32);

        public static Token m16ᙾ64 => Token.Define(T.m16ᙾ64, I.m16ᙾ64, V.m16ᙾ64, P.m16ᙾ64);

        public static Token m16Ʌ32 => Token.Define(T.m16Ʌ32, I.m16Ʌ32, V.m16Ʌ32, P.m16Ʌ32);

        public static Token m16Ʌ16 => Token.Define(T.m16Ʌ16, I.m16Ʌ16, V.m16Ʌ16, P.m16Ʌ16);

        public static Token m32Ʌ32 => Token.Define(T.m32Ʌ32, I.m32Ʌ32, V.m32Ʌ32, P.m32Ʌ32);

        public static Token m16Ʌ64 => Token.Define(T.m16Ʌ64, I.m16Ʌ64, V.m16Ʌ64, P.m16Ʌ64);

        public static Token m32fp => Token.Define(T.m32fp, I.m32fp, V.m32fp, P.m32fp);

        public static Token m64fp => Token.Define(T.m64fp, I.m64fp, V.m64fp, P.m64fp);

        public static Token m80fp => Token.Define(T.m80fp, I.m80fp, V.m80fp, P.m80fp);

        public static Token m16int => Token.Define(T.m16int, I.m16int, V.m16int, P.m16int);

        public static Token m32int => Token.Define(T.m32int, I.m32int, V.m32int, P.m32int);

        public static Token m64int => Token.Define(T.m64int, I.m64int, V.m64int, P.m64int);

        public static Token mm => Token.Define(T.mm, I.mm, V.mm, P.mm);

        public static Token mmノm32 => Token.Define(T.mmノm32, I.mmノm32, V.mmノm32, P.mmノm32);

        public static Token mmノm64 => Token.Define(T.mmノm64, I.mmノm64, V.mmノm64, P.mmノm64);

        public static Token mib => Token.Define(T.mib, I.mib, V.mib, P.mib);

        public static Token moffs8 => Token.Define(T.moffs8, I.moffs8, V.moffs8, P.moffs8);

        public static Token moffs16 => Token.Define(T.moffs16, I.moffs16, V.moffs16, P.moffs16);

        public static Token moffs32 => Token.Define(T.moffs32, I.moffs32, V.moffs32, P.moffs32);

        public static Token moffs64 => Token.Define(T.moffs64, I.moffs64, V.moffs64, P.moffs64);

        public static Token ptr16ᙾ16 => Token.Define(T.ptr16ᙾ16, I.ptr16ᙾ16, V.ptr16ᙾ16, P.ptr16ᙾ16);

        public static Token ptr16ᙾ32 => Token.Define(T.ptr16ᙾ32, I.ptr16ᙾ32, V.ptr16ᙾ32, P.ptr16ᙾ32);

        public static Token r8  => Token.Define(T.r8, I.r8, V.r8, P.r8);

        public static Token r16 => Token.Define(T.r16, I.r16, V.r16, P.r16);

        public static Token r32 => Token.Define(T.r32, I.r32, V.r32, P.r32);

        public static Token r64 => Token.Define(T.r64, I.r64, V.r64, P.r64);

        public static Token rel8 => Token.Define(T.rel8, I.rel8, V.rel8, P.rel8);
        
        public static Token rel16 => Token.Define(T.rel16, I.rel16, V.rel16, P.rel16);
        
        public static Token rel32 => Token.Define(T.rel32, I.rel32, V.rel32, P.rel32);
        
        public static Token rノm8 => Token.Define(T.rノm8, I.rノm8, V.rノm8, P.rノm8);
        
        public static Token rノm16 => Token.Define(T.rノm16, I.rノm16, V.rノm16, P.rノm16);
        
        public static Token rノm32 => Token.Define(T.rノm32, I.rノm32, V.rノm32, P.rノm32);
        
        public static Token rノm64 => Token.Define(T.rノm64, I.rノm64, V.rノm64, P.rノm64);
        
        public static Token Sreg => Token.Define(T.Sreg, I.Sreg, V.Sreg, P.Sreg);
        
        public static Token ᛁsaeᛁ => Token.Define(T.ᛁsaeᛁ, I.ᛁsaeᛁ, V.ᛁsaeᛁ, P.ᛁsaeᛁ);
        
        public static Token SRC => Token.Define(T.SRC, I.SRC, V.SRC, P.SRC);
        
        public static Token SRC1 => Token.Define(T.SRC1, I.SRC1, V.SRC1, P.SRC1);
        
        public static Token SRC2 => Token.Define(T.SRC2, I.SRC2, V.SRC2, P.SRC2);
        
        public static Token SRC3 => Token.Define(T.SRC3, I.SRC3, V.SRC3, P.SRC3);

        public static Token ST  => Token.Define(T.ST, I.ST, V.ST, P.ST);

        public static Token STᐸ0ᐳ => Token.Define(T.STᐸ0ᐳ, I.STᐸ0ᐳ, V.STᐸ0ᐳ, P.STᐸ0ᐳ);

        public static Token xmm => Token.Define(T.xmm, I.xmm, V.xmm, P.xmm);

        public static Token xmmノ32 => Token.Define(T.xmmノ32, I.xmmノ32, V.xmmノ32, P.xmmノ32);

        public static Token xmmノ64 => Token.Define(T.xmmノ64, I.xmmノ64, V.xmmノ64, P.xmmノ64);

        public static Token xmmノ128 => Token.Define(T.xmmノ128, I.xmmノ128, V.xmmノ128, P.xmmノ128);

        public static Token ᐸXMM0ᐳ => Token.Define(T.ᐸXMM0ᐳ, I.ᐸXMM0ᐳ, V.ᐸXMM0ᐳ, P.ᐸXMM0ᐳ);

        public static Token ymm => Token.Define(T.ymm, I.ymm, V.ymm, P.ymm);

        public static Token m256 => Token.Define(T.m256, I.m256, V.m256, P.m256);

        public static Token ymmノm256 => Token.Define(T.ymmノm256, I.ymmノm256, V.ymmノm256, P.ymmノm256);

        public static Token ᐸYMM0ᐳ => Token.Define(T.ᐸYMM0ᐳ, I.ᐸYMM0ᐳ, V.ᐸYMM0ᐳ, P.ᐸYMM0ᐳ);

        public static Token zmm => Token.Define(T.zmm, I.zmm, V.zmm, P.zmm);

        public static Token m512 => Token.Define(T.m512, I.m512, V.m512, P.m512);

        public static Token zmmノm512 => Token.Define(T.zmmノm512, I.zmmノm512, V.zmmノm512, P.zmmノm512);

        public static Token mV => Token.Define(T.mV, I.mV, V.mV, P.mV);

        public static Token m32bcst => Token.Define(T.m32bcst, I.m32bcst, V.m32bcst, P.m32bcst);

        public static Token m64bcst => Token.Define(T.m64bcst, I.m64bcst, V.m64bcst, P.m64bcst);

        public static Token zmmノm512ノm32bcst => Token.Define(T.zmmノm512ノm32bcst, I.zmmノm512ノm32bcst, V.zmmノm512ノm32bcst, P.zmmノm512ノm32bcst);

        public static Token zmmノm512ノm64bcst => Token.Define(T.zmmノm512ノm64bcst, I.zmmノm512ノm64bcst, V.zmmノm512ノm64bcst, P.zmmノm512ノm64bcst);

        public static Token ᐸZMM0ᐳ => Token.Define(T.ᐸZMM0ᐳ, I.ᐸZMM0ᐳ, V.ᐸZMM0ᐳ, P.ᐸZMM0ᐳ);        
    }
}