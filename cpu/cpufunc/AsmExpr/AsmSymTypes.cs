//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


   public static partial class AsmSymTypes
    {
        //~ rax
        public sealed class RAX : Reg64{ internal RAX() : base(GpRegId64.rax) {} }

        public sealed class EAX : Reg32{ internal EAX() : base(GpRegId32.eax) {} }

        public sealed class AX : Reg16{ internal AX() : base(GpRegId16.ax) {} }

        public sealed class AL : Reg8{ internal AL() : base(GpRegId8.al) {} }

        //~ ecx
        public sealed class RCX : Reg64{ internal RCX() : base(GpRegId64.rcx) {} }

        public sealed class ECX : Reg32{ internal ECX() : base(GpRegId32.ecx) {} }

        public sealed class CX : Reg16{ internal CX() : base(GpRegId16.cx) {} }

        public sealed class CL : Reg8{ internal CL() : base(GpRegId8.cl) {} }

        //~ rdx
        public sealed class RDX : Reg64{ internal RDX() : base(GpRegId64.rdx) {} }

        public sealed class EDX : Reg32{ internal EDX() : base(GpRegId32.edx) {} }

        public sealed class DX : Reg16{ internal DX() : base(GpRegId16.dx) {} }

        public sealed class DL : Reg8{ internal DL() : base(GpRegId8.dl) {} }
        
        //~ rbx
        
        public sealed class RBX : Reg64{ internal RBX() : base(GpRegId64.rbx) {} }

        public sealed class EBX : Reg32{ internal EBX() : base(GpRegId32.ebx) {} }

        public sealed class BX : Reg16{ internal BX() : base(GpRegId16.bx) {} }

        public sealed class BL : Reg8{ internal BL() : base(GpRegId8.bl) {} }
        
        //~ rsp

        public sealed class RSP : Reg64{ internal RSP() : base(GpRegId64.rsp) {} }

        public sealed class ESP : Reg32{ internal ESP() : base(GpRegId32.esp) {} }

        public sealed class SP : Reg16{ internal SP() : base(GpRegId16.sp) {} }

        public sealed class AH : Reg8{ internal AH() : base(GpRegId8.ah) {} }

        //~ rbp

        public sealed class RBP : Reg64{ internal RBP() : base(GpRegId64.rbp) {} }

        public sealed class EBP : Reg32{ internal EBP() : base(GpRegId32.ebp) {} }

        public sealed class BP : Reg16{ internal BP() : base(GpRegId16.bp) {} }

        public sealed class CH : Reg8{ internal CH() : base(GpRegId8.ch) {} }

        //~ rsi

        public sealed class RSI : Reg64{ internal RSI() : base(GpRegId64.rsi) {} }

        public sealed class ESI : Reg32{ internal ESI() : base(GpRegId32.esi) {} }

        public sealed class SI : Reg16{ internal SI() : base(GpRegId16.si) {} }

        public sealed class DH : Reg8{ internal DH() : base(GpRegId8.dh) {} }

        //~ rdi

        public sealed class RDI : Reg64{ internal RDI() : base(GpRegId64.rdi) {} }

        public sealed class EDI : Reg32{ internal EDI() : base(GpRegId32.edi) {} }

        public sealed class DI : Reg16{ internal DI() : base(GpRegId16.di) {} }
        
        public sealed class BH : Reg8{ internal BH() : base(GpRegId8.bh) {} }

        //~ r8

        public sealed class R8 : Reg64{ internal R8() : base(GpRegId64.r8) {} }

        public sealed class R8D : Reg32{ internal R8D() : base(GpRegId32.r8d) {} }

        public sealed class R8W : Reg16{ internal R8W() : base(GpRegId16.r8w) {} }

        public sealed class R8B : Reg8{ internal R8B() : base(GpRegId8.r8b) {} }

        //~ r9

        public sealed class R9 : Reg64{ internal R9() : base(GpRegId64.r9) {} }

        public sealed class R9D : Reg32{ internal R9D() : base(GpRegId32.r9d) {} }

        public sealed class R9W : Reg16{ internal R9W() : base(GpRegId16.r9w) {} }

        public sealed class R9B : Reg8{ internal R9B() : base(GpRegId8.r9b) {} }
        
        //~ r10
        
        public sealed class r10 : Reg64{ internal r10() : base(GpRegId64.r10) {} }

        public sealed class r10d: Reg32{ internal r10d() : base(GpRegId32.r10d) {} }

        public sealed class r10w : Reg16{ internal r10w() : base(GpRegId16.r10w) {} }

        public sealed class r10b : Reg8{ internal r10b() : base(GpRegId8.r10b) {} }

        //~ r11
        
        public sealed class R11 : Reg64{ internal R11() : base(GpRegId64.r11) {} }

        public sealed class R11D : Reg32{ internal R11D() : base(GpRegId32.r11d) {} }

        public sealed class R11W : Reg16{ internal R11W() : base(GpRegId16.r11w) {} }

        public sealed class R11B : Reg8{ internal R11B() : base(GpRegId8.r11b) {} }
        
        //~ r12
        
        public sealed class R12 : Reg64{ internal R12() : base(GpRegId64.r12) {} }

        public sealed class R12D : Reg32{ internal R12D() : base(GpRegId32.r12d) {} }

        public sealed class R12W : Reg16{ internal R12W() : base(GpRegId16.r12w) {} }

        public sealed class R12B : Reg8{ internal R12B() : base(GpRegId8.r12b) {} }

        //~ r13

        public sealed class R13 : Reg64{ internal R13() : base(GpRegId64.r13) {} }
        
        public sealed class R13D : Reg32{ internal R13D() : base(GpRegId32.r13d) {} }

        public sealed class R13W : Reg16{ internal R13W() : base(GpRegId16.r13w) {} }

        public sealed class R13B : Reg8{ internal R13B() : base(GpRegId8.r13b) {} }

        //~ r14
        
        public sealed class R14 : Reg64{ internal R14() : base(GpRegId64.r14) {} }

        public sealed class R14D : Reg32{ internal R14D() : base(GpRegId32.r14d) {} }

        public sealed class R14W : Reg16{ internal R14W() : base(GpRegId16.r14w) {} }

        public sealed class R14B : Reg8{ internal R14B() : base(GpRegId8.r14b) {} }

        //~ r15

        public sealed class R15 : Reg64{ internal R15() : base(GpRegId64.r15) {} }

        public sealed class R15D : Reg32{ internal R15D() : base(GpRegId32.r15d) {} }

        public sealed class R15W : Reg16{ internal R15W() : base(GpRegId16.r15w) {} }

        public sealed class R15B : Reg8{ internal R15B() : base(GpRegId8.r15b) {} }

        //~XMM

        public sealed class XMM0 : Reg128{ internal XMM0() : base(XmmRegId.xmm0) {} }

        public sealed class XMM1 : Reg128{ internal XMM1() : base(XmmRegId.xmm1) {} }

        public sealed class XMM2 : Reg128{ internal XMM2() : base(XmmRegId.xmm2) {} }

        public sealed class XMM3 : Reg128{ internal XMM3() : base(XmmRegId.xmm3) {} }

        public sealed class XMM4 : Reg128{ internal XMM4() : base(XmmRegId.xmm4) {} }

        public sealed class XMM5 : Reg128{ internal XMM5() : base(XmmRegId.xmm5) {} }

        public sealed class XMM6 : Reg128{ internal XMM6() : base(XmmRegId.xmm6) {} }

        public sealed class XMM7 : Reg128{ internal XMM7() : base(XmmRegId.xmm7) {} }

        public sealed class XMM8 : Reg128{ internal XMM8() : base(XmmRegId.xmm8) {} }

        public sealed class XMM9 : Reg128{ internal XMM9() : base(XmmRegId.xmm9) {} }

        public sealed class XMM10 : Reg128{ internal XMM10() : base(XmmRegId.xmm10) {} }

        public sealed class XMM11 : Reg128{ internal XMM11() : base(XmmRegId.xmm11) {} }

        public sealed class XMM12 : Reg128{ internal XMM12() : base(XmmRegId.xmm12) {} }


        public sealed class XMM13 : Reg128{ internal XMM13() : base(XmmRegId.xmm13) {} }


        public sealed class XMM14 : Reg128{ internal XMM14() : base(XmmRegId.xmm14) {} }

        public sealed class XMM15 : Reg128{ internal XMM15() : base(XmmRegId.xmm15) {} }

        //~XMM

        public sealed class YMM0 : Reg256{ internal YMM0() : base(YmmRegId.ymm0) {} }

        public sealed class YMM1 : Reg256{ internal YMM1() : base(YmmRegId.ymm1) {} }

        public sealed class YMM2 : Reg256{ internal YMM2() : base(YmmRegId.ymm2) {} }


        public sealed class YMM3 : Reg256{ internal YMM3() : base(YmmRegId.ymm3) {} }

        public sealed class YMM4 : Reg256{ internal YMM4() : base(YmmRegId.ymm4) {} }


        public sealed class YMM5 : Reg256{ internal YMM5() : base(YmmRegId.ymm5) {} }

        public sealed class YMM6 : Reg256{ internal YMM6() : base(YmmRegId.ymm6) {} }

        public sealed class YMM7 : Reg256{ internal YMM7() : base(YmmRegId.ymm7) {} }

        public sealed class YMM8 : Reg256{ internal YMM8() : base(YmmRegId.ymm8) {} }

        public sealed class YMM9 : Reg256{ internal YMM9() : base(YmmRegId.ymm9) {} }

        public sealed class YMM10 : Reg256{ internal YMM10() : base(YmmRegId.ymm10) {} }

        public sealed class YMM11 : Reg256{ internal YMM11() : base(YmmRegId.ymm11) {} }

        public sealed class YMM12 : Reg256{ internal YMM12() : base(YmmRegId.ymm12) {} }

        public sealed class YMM13 : Reg256{ internal YMM13() : base(YmmRegId.ymm13) {} }

        public sealed class YMM14 : Reg256{ internal YMM14() : base(YmmRegId.ymm14) {} }

        public sealed class YMM15 : Reg256{ internal YMM15() : base(YmmRegId.ymm15) {} }

    }


}