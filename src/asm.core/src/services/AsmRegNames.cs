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
    using static AsmCodes;

    [ApiHost]
    public readonly struct AsmRegNames
    {
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

        const string XmmText = "xmm1 xmm2 xmm3 xmm4 xmm5 xmm6 xmm7 xmm8 xmm9 xmm10xmm11xmm12xmm13xmm14xmm15xmm16xmm17xmm18xmm19xmm20xmm21xmm22xmm23xmm24xmm25xmm26xmm27xmm28xmm29xmm30xmm31";

        const string YmmText = "ymm1 ymm2 ymm3 ymm4 ymm5 ymm6 ymm7 ymm8 ymm9 ymm10ymm11ymm12ymm13ymm14ymm15ymm16ymm17ymm18ymm19ymm20ymm21ymm22ymm23ymm24ymm25ymm26ymm27ymm28ymm29ymm30ymm31";

        const string ZmmText = "zmm1 zmm2 zmm3 zmm4 zmm5 zmm6 zmm7 zmm8 zmm9 zmm10zmm11zmm12zmm13zmm14zmm15zmm16zmm17zmm18zmm19zmm20zmm21zmm22zmm23zmm24zmm25zmm26zmm27zmm28zmm29zmm30zmm31";

        const string GpRegText = R0 + R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8 + R9 + R10 + R11 + R12 + R13 + R14 + R15;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(GpClass k)
            => GpRegText;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(XmmClass k)
            => XmmText;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(YmmClass k)
            => YmmText;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(ZmmClass k)
            => ZmmText;

        const byte VRegWidth = 5;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(XmmClass k, RegIndexCode index)
            => slice(chars(k),((byte)index)*VRegWidth, VRegWidth);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(YmmClass k, RegIndexCode index)
            => slice(chars(k),((byte)index)*VRegWidth, VRegWidth);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ZmmClass k, RegIndexCode index)
            => slice(chars(k),((byte)index)*VRegWidth, VRegWidth);

        [MethodImpl(Inline), Op]
        static ushort offsset(GpClass gp, RegIndexCode index, RegWidthCode width)
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

        [MethodImpl(Inline), Op]
        public static RegName name(GpClass gp, RegIndexCode index, RegWidthCode width)
        {
            const byte RegLength = 4;
            var data = 0ul;
            var i0 = offsset(gp, index, width);
            data = first(recover<ulong>(slice(chars(gp),i0, RegLength)));
            return new RegName(data);
        }

        [MethodImpl(Inline), Op]
        static byte length(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            byte i=0;
            for(i=0; i<count; i++)
            {
                if(skip(src,i) == Chars.Space)
                {
                    i++;
                    break;
                }
            }
            return i;
        }

        [MethodImpl(Inline), Op]
        public static string format(RegName src)
        {
            var chars = recover<char>(bytes(src));
            return new string(slice(chars,0,length(chars)));
        }

        [MethodImpl(Inline), Op]
        public static RegName name(RegOp src)
            => name(GP, src.Index, (RegWidthCode)(src.Bitfield & 0b111));
    }

/*

| Index | Code | [63:0] | [31:0] | [15:0] | [7:0] |
| 0     | 0000 | rax    | eax    | ax     | al    |
| 1     | 0001 | rcx    | ecx    | cx     | cl    |
| 2     | 0010 | rdx    | edx    | dx     | dl    |
| 3     | 0011 | rbx    | ebx    | bx     | bl    |
| 4     | 0100 | rsp    | esp    | sp     | spl   |
| 5     | 0101 | rbp    | ebp    | bp     | bpl   |
| 6     | 0110 | rsi    | esi    | si     | sil   |
| 7     | 0111 | rdi    | edi    | di     | dil   |
| 8     | 1000 | r8     | r8d    | r8w    | r8b   |
| 9     | 1001 | r9     | r9d    | r9w    | r9b   |
| 10    | 1010 | r10    | r10d   | r10w   | r10b  |
| 11    | 1011 | r11    | r11d   | r11w   | r11b  |
| 12    | 1100 | r12    | r12d   | r12w   | r12b  |
| 13    | 1101 | r13    | r13d   | r13w   | r13b  |
| 14    | 1110 | r14    | r14d   | r14w   | r14b  |
| 15    | 1111 | r15    | r15d   | r15w   | r15b  |
*/
}