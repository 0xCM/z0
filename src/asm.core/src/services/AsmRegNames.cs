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
    using static RegClasses;
    using static Blit;

    [ApiHost]
    public readonly struct AsmRegNames
    {
        [Op]
        public static string format<T>(NamedRegValue<T> src)
            where T : unmanaged
                => string.Format("{0,-5}{1}",
                src.Name,
                src.Value.FormatHexBytes()
                );

        [MethodImpl(Inline), Op]
        public static text7 name(XmmClass k, RegIndexCode index)
        {
            const byte RegLength = 5;
            const string Data = "xmm1 xmm2 xmm3 xmm4 xmm5 xmm6 xmm7 xmm8 xmm9 xmm10xmm11xmm12xmm13xmm14xmm15xmm16xmm17xmm18xmm19xmm20xmm21xmm22xmm23xmm24xmm25xmm26xmm27xmm28xmm29xmm30xmm31";
            var i0 = (uint)index*RegLength;
            return slice(text.chars(Data), i0, RegLength);
        }

        [MethodImpl(Inline), Op]
        public static text7 name(YmmClass k, RegIndexCode index)
        {
            const byte RegLength = 5;
            const string Data = "ymm1 ymm2 ymm3 ymm4 ymm5 ymm6 ymm7 ymm8 ymm9 ymm10ymm11ymm12ymm13ymm14ymm15ymm16ymm17ymm18ymm19ymm20ymm21ymm22ymm23ymm24ymm25ymm26ymm27ymm28ymm29ymm30ymm31";
            var i0 = (uint)index*RegLength;
            return slice(text.chars(Data), i0, RegLength);
        }

        [MethodImpl(Inline), Op]
        public static text7 name(ZmmClass k, RegIndexCode index)
        {
            const byte RegLength = 5;
            const string Data = "zmm1 zmm2 zmm3 zmm4 zmm5 zmm6 zmm7 zmm8 zmm9 zmm10zmm11zmm12zmm13zmm14zmm15zmm16zmm17zmm18zmm19zmm20zmm21zmm22zmm23zmm24zmm25zmm26zmm27zmm28zmm29zmm30zmm31";
            var i0 = (uint)index*RegLength;
            return slice(text.chars(Data), i0, RegLength);
        }

        [MethodImpl(Inline), Op]
        public static text7 name(MaskClass k, RegIndexCode index)
        {
            const byte RegLength = 2;
            const string Data = "k0k1k2k3k4k5k6k7";
            var i0 = (ushort)((uint)index*RegLength);
            return slice(text.chars(Data), i0, RegLength);
        }

        [MethodImpl(Inline), Op]
        public static text7 name(GpClass k, RegIndexCode index, RegWidthCode width)
        {
            const byte RegLength = 4;
            const string R0 = "rax eax ax  al  ";
            const string R1 = "rcx ecx cx  cl  ";
            const string R2 = "rdx edx dx  dl  ";
            const string R3 = "rbx ebx bx  bl  ";
            const string R4 = "rsp esp sp  spl ";
            const string R5 = "rbp ebp bp  bpl ";
            const string R6 = "rsi esi si  sil ";
            const string R7 = "rdi edi di  dil ";
            const string R8 = "r8  r8d r8w r8b ";
            const string R9 = "r9  r9d r9w r9b ";
            const string R10 = "r10 r10dr10wr10b";
            const string R11 = "r11 r11dr11wr11b";
            const string R12 = "r12 r12dr12wr12b";
            const string R13 = "r13 r13dr13wr13b";
            const string R14 = "r14 r14dr14wr14b";
            const string R15 = "r15 r15dr15wr15b";
            const string Data = R0 + R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8 + R9 + R10 + R11 + R12 + R13 + R14 + R15;
            var data = 0ul;
            var i0 = offsset(k, index, width);
            return slice(text.chars(Data), i0, RegLength);
        }

        [Op]
        public static text7 name(RegOp src)
        {
            switch(src.RegClass)
            {
                case RegClassCode.GP:
                    return name(Gp, src.Index, (RegWidthCode)(src.Bitfield & 0b111));
                case RegClassCode.XMM:
                    return name(Xmm, src.Index);
                case RegClassCode.YMM:
                    return name(Ymm, src.Index);
                case RegClassCode.ZMM:
                    return name(Zmm, src.Index);
                case RegClassCode.MASK:
                    return name(KReg, src.Index);
            }
            return text7.Empty;
        }

        [MethodImpl(Inline), Op]
        static ushort offsset(GpClass k, RegIndexCode index, RegWidthCode width)
        {
            const byte RegLength = 4;
            const byte RowLength = 4*RegLength;
            var row = (uint)((uint)index*RowLength);
            var col = z32;
            if(width == RegWidthCode.W64)
                col = 0;
            else if(width == RegWidthCode.W32)
                col = 4;
            else if(width == RegWidthCode.W16)
                col = 8;
            else
                col = 12;

            return (ushort)(row + col);
        }
    }
}