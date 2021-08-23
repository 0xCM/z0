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
    using static AsmRegTokens;

    partial struct CallCv
    {
        const byte CcvSize = 64;

        const byte Win64MaxReg = 3;

        // rax=0, rcx=1, rdx=2, rbx=3, rsp=4, rbp=5, rsi=6, rdi=7, r8=8, r9=9, r10=10, r11, r12, r13, r14, r15
        static ReadOnlySpan<byte> WinX64Data
            => new byte[CcvSize]{
                1,2,8,9,0,0,0,0,
                0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,
                32,33,34,35,36,37,38,39,
                40,41,42,43,44,45,46,47,
                48,49,50,51,52,53,54,56,
                57,58,59,60,61,62,63,64};

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<Gp8Reg> winX64Regs(W8 w)
            => recover<Gp8Reg>(slice(WinX64Data,0,Win64MaxReg + 1));

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<Gp16Reg> winX64Regs(W16 w)
            => recover<Gp16Reg>(slice(WinX64Data,0,Win64MaxReg + 1));

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<Gp32Reg> winX64Regs(W32 w)
            => recover<Gp32Reg>(slice(WinX64Data,0,Win64MaxReg + 1));

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<Gp64Reg> winX64Regs(W64 w)
            => recover<Gp64Reg>(slice(WinX64Data,0,Win64MaxReg + 1));

        [MethodImpl(Inline), Op]
        static ref readonly Gp8Reg winX64Reg(W8 w, byte index)
            => ref skip(winX64Regs(w), index);

        [MethodImpl(Inline), Op]
        static ref readonly Gp16Reg winX64Reg(W16 w, byte index)
            => ref skip(winX64Regs(w), index);

        [MethodImpl(Inline), Op]
        static ref readonly Gp32Reg winX64Reg(W32 w, byte index)
            => ref skip(winX64Regs(w), index);

        [MethodImpl(Inline), Op]
        static ref readonly Gp64Reg winX64Reg(W64 w, byte index)
            => ref skip(winX64Regs(w), index);
    }
}