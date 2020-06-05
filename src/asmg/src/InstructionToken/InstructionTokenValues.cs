//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using static Seed;

    using V = InstructionTokenValue;

    public class InstructionTokenValues
    {
        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> span(string src)
            => src;        

        [MethodImpl(Inline)]
        static MemoryAddress address(string src)
            => MemoryAddress.From(Control.head(span(src)));            

        public static ReadOnlySpan<char> None => text.Empty;

        public static ReadOnlySpan<char> bnd => V.bnd;

        public static ReadOnlySpan<char> DST => V.DST;

        public static ReadOnlySpan<char> ᛁerᛁ => V.ᛁerᛁ;

        public static ReadOnlySpan<char> imm8 => V.imm8;

        public static ReadOnlySpan<char> imm16 => V.imm16;

        public static ReadOnlySpan<char> imm32 => V.imm32;

        public static ReadOnlySpan<char> imm64 => V.imm64;

        public static ReadOnlySpan<char> k1 => V.k1;

        public static ReadOnlySpan<char> m => V.m;

        public static ReadOnlySpan<char> m8 => V.m8;

        public static ReadOnlySpan<char> m16 => V.m16;

        public static ReadOnlySpan<char> m32 => V.m32;

        public static ReadOnlySpan<char> m64 => V.m64;

        public static ReadOnlySpan<char> m128 => V.m128;

        public static ReadOnlySpan<char> m16ᙾ16 => V.m16ᙾ16;

        public static ReadOnlySpan<char> m16ᙾ32 => V.m16ᙾ32;

        public static ReadOnlySpan<char> m16ᙾ64 => V.m16ᙾ64;

        public static ReadOnlySpan<char> m16Ʌ32 => V.m16Ʌ32;

        public static ReadOnlySpan<char> m16Ʌ16 => V.m16Ʌ16;

        public static ReadOnlySpan<char> m32Ʌ32 => V.m32Ʌ32;

        public static ReadOnlySpan<char> m16Ʌ64 => V.m16Ʌ64;

        public static ReadOnlySpan<char> m32fp  => V.m32fp;

        public static ReadOnlySpan<char> m64fp  => V.m64fp;

        public static ReadOnlySpan<char> m80fp  => V.m80fp;

        public static ReadOnlySpan<char> m16int => V.m16int;

        public static ReadOnlySpan<char> m32int => V.m32int;

        public static ReadOnlySpan<char> m64int => V.m64int;

        public static ReadOnlySpan<char> mm => V.mm;

        public static ReadOnlySpan<char> mmノm32 => V.mmノm32;

        public static ReadOnlySpan<char> mmノm64 => V.mmノm64;

        public static ReadOnlySpan<char> mib => V.mib;

        public static ReadOnlySpan<char> moffs8 => V.moffs8;

        public static ReadOnlySpan<char> moffs16 => V.moffs16;

        public static ReadOnlySpan<char> moffs32 => V.moffs32;

        public static ReadOnlySpan<char> moffs64 => V.moffs64;

        public static ReadOnlySpan<char> ptr16ᙾ16 => V.ptr16ᙾ16;

        public static ReadOnlySpan<char> ptr16ᙾ32 => V.ptr16ᙾ32;
 
        public static ReadOnlySpan<char> r8  => V.r8;
 
        public static ReadOnlySpan<char> r16 => V.r16;
 
        public static ReadOnlySpan<char> r32 => V.r32;
 
        public static ReadOnlySpan<char> r64 => V.r64;
 
        public static ReadOnlySpan<char> rel8  => V.rel8;
 
        public static ReadOnlySpan<char> rel16 => V.rel16;
 
        public static ReadOnlySpan<char> rel32 => V.rel32;
 
        public static ReadOnlySpan<char> rノm8 => V.rノm8;
 
        public static ReadOnlySpan<char> rノm16 => V.rノm16 ;
 
        public static ReadOnlySpan<char> rノm32 => V.rノm32;
 
        public static ReadOnlySpan<char> rノm64 => V.rノm64;
 
        public static ReadOnlySpan<char> Sreg  => V.Sreg;
 
        public static ReadOnlySpan<char> ᛁsaeᛁ => V.ᛁsaeᛁ;
 
        public static ReadOnlySpan<char> SRC => V.SRC;
 
        public static ReadOnlySpan<char> SRC1  => V.SRC1;
 
        public static ReadOnlySpan<char> SRC2  => V.SRC2;
 
        public static ReadOnlySpan<char> SRC3  => V.SRC3;
 
        public static ReadOnlySpan<char> ST  => V.ST;
 
        public static ReadOnlySpan<char> STᐸ0ᐳ => V.STᐸ0ᐳ;
 
        public static ReadOnlySpan<char> xmm => V.xmm;
 
        public static ReadOnlySpan<char> xmmノ32 => V.xmmノ32;
 
        public static ReadOnlySpan<char> xmmノ64 => V.xmmノ64;
 
        public static ReadOnlySpan<char> xmmノ128 => V.xmmノ128;
 
        public static ReadOnlySpan<char> ᐸXMM0ᐳ => V.ᐸXMM0ᐳ;
 
        public static ReadOnlySpan<char> ymm => V.ymm;
 
        public static ReadOnlySpan<char> m256  => V.m256;
 
        public static ReadOnlySpan<char> ymmノm256 => V.ymmノm256;
 
        public static ReadOnlySpan<char> ᐸYMM0ᐳ => V.ᐸYMM0ᐳ;
 
        public static ReadOnlySpan<char> zmm => V.zmm;
 
        public static ReadOnlySpan<char> m512  => V.m512;
 
        public static ReadOnlySpan<char> zmmノm512 => V.zmmノm512;
 
        public static ReadOnlySpan<char> mV  => V.mV;
 
        public static ReadOnlySpan<char> m32bcst => V.m32bcst;
 
        public static ReadOnlySpan<char> m64bcst => V.m64bcst;
 
        public static ReadOnlySpan<char> zmmノm512ノm32bcst => V.zmmノm512ノm32bcst;
 
        public static ReadOnlySpan<char> zmmノm512ノm64bcst => V.zmmノm512ノm64bcst;
 
        public static ReadOnlySpan<char> ᐸZMM0ᐳ => V.ᐸZMM0ᐳ;
    }
}