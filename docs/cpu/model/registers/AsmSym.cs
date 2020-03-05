//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.CpuModel
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static AsmSymTypes;

    public static partial class AsmSym
    {
         //~ rax
        public static RAX rax => default;

        public static EAX eax => default;

        public static AX ax => default;

        public static AL al => default;


        //~ ecx
        public static readonly RCX rcx = new RCX();

        public static readonly ECX ecx = new ECX();

        public static readonly CX cx = new CX();

        public static readonly CL cl = new CL();

        //~ rdx
        public static readonly RDX rdx = new RDX();

        public static readonly EDX edx = new EDX();

        public static readonly DX dx = new DX();

        public static readonly DL dl = new DL();
        
        //~ rbx
        
        public static readonly RBX rbx = new RBX();

        public static readonly EBX ebx = new EBX();

        public static readonly BX bx = new BX();

        public static readonly BL bl = new BL();
        
        //~ rsp

        public static readonly RSP rsp = new RSP();

        public static readonly ESP esp = new ESP();

        public static readonly SP sp = new SP();

        public static readonly AH ah = new AH();

        //~ rbp

        public static readonly RBP rbp = new RBP();

        public static readonly EBP ebp = new EBP();

        public static readonly BP bp = new BP();

        public static readonly CH ch = new CH();

        //~ rsi

        public static readonly RSI rsi = new RSI();

        public static readonly ESI esi = new ESI();

        public static readonly SI si = new SI();

        public static readonly DH dh = new DH();

        //~ rdi

        public static readonly RDI rdi = new RDI();

        public static readonly EDI edi = new EDI();

        public static readonly DI di = new DI();
        
        public static readonly BH bh = new BH();

        //~ r8

        public static readonly R8 r8 = new R8();

        public static readonly R8D r8d = new R8D();

        public static readonly R8W r8w = new R8W();

        public static readonly R8B r8b = new R8B();

        //~ r9

        public static readonly R9 r9 = new R9();

        public static readonly R9D r9d = new R9D();

        public static readonly R9W r9w = new R9W();

        public static readonly R9B r9b = new R9B();
        
        //~ r10
        
        public static readonly r10 r10 = new r10();

        public static readonly r10d r10d = new r10d();

        public static readonly r10w  r10w = new r10w();

        public static readonly r10b  r10b = new r10b();

        //~ r11
        
        public static readonly R11 r11 = new R11();

        public static readonly R11D  r11d = new R11D();

        public static readonly R11W  r11w = new R11W();

        public static readonly R11B  r11b = new R11B();
        
        //~ r12
        
        public static readonly R12 r12 = new R12();

        public static readonly R12D r12d = new R12D();

        public static readonly R12W r12w = new R12W();

        public static readonly R12B r12b = new R12B();

        //~ r13

        public static readonly R13 r13 = new R13();
        
        public static readonly R13D r13d = new R13D();

        public static readonly R13W r13w = new R13W();

        public static readonly R13B r13b = new R13B();

        //~ r14
        
        public static readonly R14 r14 = new R14();

        public static readonly R14D r14d = new R14D();

        public static readonly R14W r14w = new R14W();

        public static readonly R14B r14b = new R14B();

        //~ r15

        public static readonly R15 r15 = new R15();

        public static readonly R15D r15d  = new R15D();

        public static readonly R15W r15w = new R15W();

        public static readonly R15B r15b = new R15B();

        //~XMM

        public static XMM0 xmm0 => default;

        public static XMM1 xmm1 => default;

        public static XMM2 xmm2 => default;

        public static XMM3 xmm3 => default;

        public static XMM4 xmm4 => default;

        public static XMM5 xmm5 => default;

        public static XMM6 xmm6 => default;

        public static XMM7 xmm7 => default;

        public static XMM8 xmm8 => default;

        public static XMM9 xmm9 => default;

        public static XMM10 xmm10 => default;

        public static XMM11 xmm11 => default;

        public static XMM12 xmm12 => default;

        public static XMM13 xmm13 => default;

        public static XMM14 xmm14 => default;

        public static XMM15 xmm15 => default;

        //~YMM

        public static readonly YMM0 ymm0 = new YMM0();

        public static readonly YMM1 ymm1 = new YMM1();

        public static readonly YMM2  ymm2 = new YMM2();

        public static readonly YMM3  ymm3 = new YMM3();

        public static readonly YMM4  ymm4 = new YMM4();

        public static readonly YMM5  ymm5 = new YMM5();

        public static readonly YMM6  ymm6 = new YMM6();

        public static readonly YMM7  ymm7 = new YMM7();

        public static readonly YMM8  ymm8 = new YMM8();

        public static readonly YMM9  ymm9 = new YMM9();

        public static readonly YMM10  ymm10 = new YMM10();

        public static readonly YMM11  ymm11 = new YMM11();

        public static readonly YMM12  ymm12 = new YMM12();

        public static readonly YMM13  ymm13 = new YMM13();

        public static readonly YMM14  ymm14 = new YMM14();

        public static readonly YMM15  ymm15 = new YMM15();
       
    }    
}