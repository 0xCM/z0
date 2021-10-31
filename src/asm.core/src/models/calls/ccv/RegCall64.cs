//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Vec;

    using static Root;
    using static core;
    using static AsmRegTokens;
    using static AsmRegTokens.Gp64Reg;
    using static AsmRegTokens.Gp32Reg;
    using static AsmRegTokens.Gp8Reg;
    using static AsmRegTokens.Gp16Reg;
    using static AsmRegTokens.XmmReg;
    using static AsmRegTokens.YmmReg;
    using static AsmRegTokens.ZmmReg;

    partial struct Ccv
    {
        /// <summary>
        /// Codifies the intel regcall convention as described in the intel c++ compiler reference
        /// </summary>
        [ApiHost("ccv.regcall64")]
        public readonly struct RegCall64 : ICallCv<RegCall64>
        {
            public CcvKind Kind => CcvKind.RegCall64;

            [MethodImpl(Inline)]
            public static implicit operator RegCall64(CcvKind src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator CcvKind(RegCall64 src)
                => src.Kind;

            // [MethodImpl(Inline), Op]
            // public static ref readonly v12<Gp8Reg> slots(W8 w)
            //     => ref first(recover<v12<Gp8Reg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v12<Gp16Reg> slots(W16 w)
            //     => ref first(recover<v12<Gp16Reg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v12<Gp32Reg> slots(W32 w)
            //     => ref first(recover<v12<Gp32Reg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v12<Gp64Reg> slots(W64 w)
            //     => ref first(recover<v12<Gp64Reg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v16<XmmReg> slots(W128 w)
            //     => ref first(recover<v16<XmmReg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v16<YmmReg> slots(W256 w)
            //     => ref first(recover<v16<YmmReg>>(bytes(regs(w))));

            // [MethodImpl(Inline), Op]
            // public static ref readonly v16<ZmmReg> slots(W512 w)
            //     => ref first(recover<v16<ZmmReg>>(bytes(regs(w))));

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<Gp8Reg> regs(W8 w)
                => Gp8Data;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<Gp16Reg> regs(W16 w)
                => Gp16Data;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<Gp32Reg> regs(W32 w)
                => Gp32Data;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<Gp64Reg> regs(W64 w)
                => Gp64Data;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<XmmReg> regs(W128 w)
                => XmmData;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<YmmReg> regs(W256 w)
                => YmmData;

            [MethodImpl(Inline), Op]
            public static ReadOnlySpan<ZmmReg> regs(W512 w)
                => ZmmData;

            const byte GpRegCount = 12;

            const byte VRegCount = 16;

            static ReadOnlySpan<Gp64Reg> Gp64Data
                => new Gp64Reg[GpRegCount]{rax,rcx,rdx,rdi,rsi,r8,r9,r11,r12,r13,r14,r15};

            static ReadOnlySpan<Gp32Reg> Gp32Data
                => new Gp32Reg[GpRegCount]{eax,ecx,edx,edi,esi,r8d,r9d,r11d,r12d,r13d,r14d,r15d};

            static ReadOnlySpan<Gp16Reg> Gp16Data
                => new Gp16Reg[GpRegCount]{ax,cx,dx,di,si,r8w,r9w,r11w,r12w,r13w,r14w,r15w};

            static ReadOnlySpan<Gp8Reg> Gp8Data
                => new Gp8Reg[GpRegCount]{al,cl,dl,dil,sil,r8b,r9b,r11b,r12b,r13b,r14b,r15b};

            static ReadOnlySpan<XmmReg> XmmData
                => new XmmReg[VRegCount]{xmm0, xmm1, xmm2, xmm3, xmm4, xmm5, xmm6, xmm7, xmm8, xmm9, xmm10, xmm11, xmm12, xmm13, xmm14, xmm15};

            static ReadOnlySpan<YmmReg> YmmData
                => new YmmReg[VRegCount]{ymm0, ymm1, ymm2, ymm3, ymm4, ymm5, ymm6, ymm7, ymm8, ymm9, ymm10, ymm11, ymm12, ymm13, ymm14, ymm15};

            static ReadOnlySpan<ZmmReg> ZmmData
                => new ZmmReg[VRegCount]{zmm0, zmm1, zmm2, zmm3, zmm4, zmm5, zmm6, zmm7, zmm8, zmm9, zmm10, zmm11, zmm12, zmm13, zmm14, zmm15};
        }
    }
}
