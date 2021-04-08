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

    using R = AsmRegOps;

    [ApiHost]
    public readonly struct AsmOps
    {
        [MethodImpl(Inline), Op]
        public static AsmRegOp reg(RegWidth width, RegClass @class, RegIndex index)
            => new AsmRegOp(width,@class,index);


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