//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOps;
    using static math;

    using R = AsmOps;

    [ApiHost]
    public readonly struct AsmOp
    {
        const byte RegWidthWidth = 3;

        const byte RegClassWidth = 5;

        const byte RegIndexWidth = 5;

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidth width, RegClass @class, RegIndex index)
            => new RegOp(or((byte)encode(width), sll((ushort)@class,5), sll((ushort)index, 10)));

        [MethodImpl(Inline), Op]
        public static RegWidthIndex encode(RegWidth width)
            => (RegWidthIndex)Pow2.log((ushort)width);

        [MethodImpl(Inline), Op]
        public static RegWidth decode(RegWidthIndex width)
            => (RegWidth)Pow2.pow((byte)width);

        [MethodImpl(Inline), Op]
        public static RegWidth width(RegOp src)
            => decode((RegWidthIndex)(src.Bitfield & 0b111));

        [MethodImpl(Inline), Op]
        public static RegIndex index(RegOp src)
            =>(RegIndex)Bits.bitseg(src.Bitfield, 10, 15);

        [MethodImpl(Inline), Op]
        public static RegClass regclass(RegOp src)
            => (RegClass)Bits.bitseg(src.Bitfield, 5, 9);

        [MethodImpl(Inline), Op]
        public m8 m8()
            => default;

        [MethodImpl(Inline), Op]
        public m16 m16()
            => default;

        [MethodImpl(Inline), Op]
        public m32 m32()
            => default;

        [MethodImpl(Inline), Op]
        public m64 m64()
            => default;

        [MethodImpl(Inline), Op]
        public m128 m128()
            => default;

        [MethodImpl(Inline), Op]
        public m256 m256()
            => default;

        [MethodImpl(Inline), Op]
        public m512 m512()
            => default;

        [MethodImpl(Inline), Op]
        public static imm8 imm8(byte value)
            => new imm8(value);

        [MethodImpl(Inline), Op]
        public static imm16 imm16(ushort value)
            => new imm16(value);

        [MethodImpl(Inline), Op]
        public static imm32 imm32(uint value)
            => new imm32(value);

        [MethodImpl(Inline), Op]
        public static imm64 imm64(ulong value)
            => new imm64(value);

        [MethodImpl(Inline)]
        public static RegOp<T> reg<T>(T src)
            where T : unmanaged, IRegOp
                => new RegOp<T>(src);

        public static RegMem<T> mem<T>(T @base, T index, MemoryScale scale, Hex32 dx)
            where T : unmanaged, IRegOp
                => new RegMem<T>(@base, index, scale, dx);

        public static R.al al => default;

        public static R.cl cl => default;

        public static R.dl dl => default;

        public static R.bl bl => default;

        public static R.sil sil => default;

        public static R.dil dil => default;

        public static R.spl spl => default;

        public static R.bpl bpl => default;

        public static R.r8b r8b => default;

        public static R.r9b r9b => default;

        public static R.r10b r10b => default;

        public static R.r11b r11b => default;

        public static R.r12b r12b => default;

        public static R.r13b r13b => default;

        public static R.r14b r14b => default;

        public static R.r15b r15b => default;

        public static R.ax ax => default;

        public static R.cx cx => default;

        public static R.dx dx => default;

        public static R.bx bx => default;

        public static R.si si => default;

        public static R.di di => default;

        public static R.sp sp => default;

        public static R.bp bp => default;

        public static R.r8w r8w => default;

        public static R.r9w r9w => default;

        public static R.r10w r10w => default;

        public static R.r11w r11w => default;

        public static R.r12w r12w => default;

        public static R.r13w r13w => default;

        public static R.r14w r14w => default;

        public static R.r15w r15w => default;

        public static R.eax eax => default;

        public static R.ecx ecx => default;

        public static R.edx edx => default;

        public static R.ebx ebx => default;

        public static R.esi esi => default;

        public static R.edi edi => default;

        public static R.esp esp => default;

        public static R.ebp ebp => default;

        public static R.r8d r8d => default;

        public static R.r9d r9d => default;

        public static R.r10d r10d => default;

        public static R.r11d r11d => default;

        public static R.r12d r12d => default;

        public static R.r13d r13d => default;

        public static R.r14d r14d => default;

        public static R.r15d r15d => default;

        public static R.rax rax => default;

        public static R.rcx rcx => default;

        public static R.rdx rdx => default;

        public static R.rbx rbx => default;

        public static R.rsi rsi => default;

        public static R.rdi rdi => default;

        public static R.rsp rsp => default;

        public static R.rbp rbp => default;

        public static R.r8q r8 => default;

        public static R.r9q r9 => default;

        public static R.r10q r10 => default;

        public static R.r11q r11 => default;

        public static R.r12q r12 => default;

        public static R.r13q r13 => default;

        public static R.r14q r14 => default;

        public static R.r15q r15 => default;
    }
}