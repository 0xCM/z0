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
    using static AsmDsl;

    [ApiHost]
    public readonly struct AsmRegNames
    {
        public string al() => "al";

        public string cl() => "cl";

        public string dl() => "dl";

        public string bl() => "bl";

        public string spl() => "spl";

        public string bpl() => "bpl";

        public string sil() => "sil";

        public string dil() => "dil";

        public string r8b() => "r8b";

        public string r9b() => "r9b";

        public string r10b() => "r10b";

        public string r11b() => "r11b";

        public string r12b() => "r12b";

        public string r13b() => "r13b";

        public string r14b() => "r14b";

        public string r15b() => "r15b";

        public string ah() => "ah";

        public string ch() => "ch";

        public string dh() => "dh";

        public string bh() => "bh";

        public string ax() => "ax";

        public string cx() => "cx";

        public string dx() => "dx";

        public string bx() => "bx";

        public string sp() => "sp";

        public string bp() => "bp";

        public string si() => "si";

        public string di() => "di";

        public string r8w() => "r8w";

        public string r9w() => "r9w";

        public string r10w() => "r10w";

        public string r11w() => "r11w";

        public string r12w() => "r12w";

        public string r13w() => "r13w";

        public string r14w() => "r14w";

        public string r15w() => "r15w";

        public string eax() => "eax";

        public string ecx() => "ecx";

        public string edx() => "edx";

        public string ebx() => "ebx";

        public string esp() => "esp";

        public string ebp() => "ebp";

        public string esi() => "esi";

        public string edi() => "edi";

        public string r8d() => "r8d";

        public string r9d() => "r9d";

        public string r10d() => "r10d";

        public string r11d() => "r11d";

        public string r12d() => "r12d";

        public string r13d() => "r13d";

        public string r14d() => "r14d";

        public string r15d() => "r15d";

        public string rax() => "rax";

        public string rcx() => "rcx";

        public string rdx() => "rdx";

        public string rbx() => "rbx";

        public string rsp() => "rsp";

        public string rbp() => "rbp";

        public string rsi() => "rsi";

        public string rdi() => "rdi";

        public string r8q() => "r8";

        public string r9q() => "r9";

        public string r10q() => "r10";

        public string r11q() => "r11";

        public string r12q() => "r12";

        public string r13q() => "r13";

        public string r14q() => "r14";

        public string r15q() => "r15";

        public string xmm0() => "xmm0";

        public string XMM1() => "xmm1";

        public string xmm2() => "xmm2";

        public string xmm3() => "xmm3";

        public string xmm4() => "xmm4";

        public string xmm5() => "xmm5";

        public string xmm6() => "xmm6";

        public string xmm7() => "xmm7";

        public string xmm8() => "xmm8";

        public string xmm9() => "xmm9";

        public string xmm10() => "xmm10";

        public string xmm11() => "xmm11";

        public string xmm12() => "xmm12";

        public string xmm13() => "xmm13";

        public string xmm14() => "xmm14";

        public string xmm15() => "xmm15";

        public string xmm16() => "xmm16";

        public string xmm17() => "xmm17";

        public string xmm18() => "xmm18";

        public string xmm19() => "xmm19";

        public string xmm20() => "xmm20";

        public string xmm21() => "xmm21";

        public string xmm22() => "xmm22";

        public string xmm23() => "xmm23";

        public string xmm24() => "xmm24";

        public string xmm25() => "xmm25";

        public string xmm26() => "xmm26";

        public string xmm27() => "xmm27";

        public string xmm28() => "xmm28";

        public string xmm29() => "xmm29";

        public string xmm30() => "xmm30";

        public string xmm31() => "xmm31";

        public string ymm0() => "ymm0";

        public string ymm1() => "ymm1";

        public string ymm2() => "ymm2";

        public string ymm3() => "ymm3";

        public string ymm4() => "ymm4";

        public string ymm5() => "ymm5";

        public string ymm6() => "ymm6";

        public string ymm7() => "ymm7";

        public string ymm8() => "ymm8";

        public string ymm9() => "ymm9";

        public string ymm10() => "ymm10";

        public string ymm11() => "ymm11";

        public string ymm12() => "ymm12";

        public string ymm13() => "ymm13";

        public string ymm14() => "ymm14";

        public string ymm15() => "ymm15";

        public string ymm16() => "ymm16";

        public string ymm17() => "ymm17";

        public string ymm18() => "ymm18";

        public string ymm19() => "ymm19";

        public string ymm20() => "ymm20";

        public string ymm21() => "ymm21";

        public string ymm22() => "ymm22";

        public string ymm23() => "ymm23";

        public string ymm24() => "ymm24";

        public string ymm25() => "ymm25";

        public string ymm26() => "ymm26";

        public string ymm27() => "ymm27";

        public string ymm28() => "ymm28";

        public string ymm29() => "ymm29";

        public string ymm30() => "ymm30";

        public string ymm31() => "ymm31";

        public string zmm0() => "zmm0";

        public string zmm1() => "zmm1";

        public string zmm2() => "zmm2";

        public string zmm3() => "zmm3";

        public string zmm4() => "zmm4";

        public string zmm5() => "zmm5";

        public string zmm6() => "zmm6";

        public string zmm7() => "zmm7";

        public string zmm8() => "zmm8";

        public string zmm9() => "zmm9";

        public string zmm10() => "zmm10";

        public string zmm11() => "zmm11";

        public string zmm12() => "zmm12";

        public string zmm13() => "zmm13";

        public string zmm14() => "zmm14";

        public string zmm15() => "zmm15";

        public string zmm16() => "zmm16";

        public string zmm17() => "zmm17";

        public string zmm18() => "zmm18";

        public string zmm19() => "zmm19";

        public string zmm20() => "zmm20";

        public string zmm21() => "zmm21";

        public string zmm22() => "zmm22";

        public string zmm23() => "zmm23";

        public string zmm24() => "zmm24";

        public string zmm25() => "zmm25";

        public string zmm26() => "zmm26";

        public string zmm27() => "zmm27";

        public string zmm28() => "zmm28";

        public string zmm29() => "zmm29";

        public string zmm30() => "zmm30";

        public string zmm31() => "zmm31";

        public string bnd0() => "bnd0";

        public string bnd1() => "bnd1";

        public string bnd2() => "bnd2";

        public string bnd3() => "bnd3";

        public string cr0() => "CR0";

        public string cr1() => "CR1";

        public string cr2() => "CR2";

        public string cr3() => "CR3";

        public string cr4() => "CR4";

        public string cr5() => "CR5";

        public string cr6() => "CR6";

        public string cr7() => "CR7";

        public string dr0() => "DR0";

        public string dr1() => "DR1";

        public string dr2() => "DR2";

        public string dr3() => "DR3";

        public string dr4() => "DR4";

        public string dr5() => "DR5";

        public string dr6() => "DR6";

        public string dr7() => "DR7";

        public string k0() => "k0";

        public string k1() => "k1";

        public string k2() => "k2";

        public string k3() => "k3";

        public string k4() => "k4";

        public string k5() => "k5";

        public string k6() => "k6";

        public string k7() => "k7";

        public string tr0() => "TR0";

        public string tr1() => "TR1";

        public string tr2() => "TR2";

        public string tr3() => "TR3";

        public string tr4() => "TR4";

        public string tr5() => "TR5";

        public string tr6() => "TR6";

        public string tr7() => "TR7";

        public string st0() => "ST(0)";

        public string st1() => "ST(1)";

        public string st2() => "ST(2)";

        public string st3() => "ST(3)";

        public string st4() => "ST(4)";

        public string st5() => "ST(5)";

        public string st6() => "ST(6)";

        public string st7() => "ST(7)";

        public string cs() => "cs";

        public string ds() => "ds";

        public string ss() => "ss";

        public string es() => "es";

        public string fs() => "fs";

        public string gs() => "gs";

        public string gdtr() => "GDTR";

        public string ldtr() => "LDTR";

        public string idtr() => "IDTR";

        public string mm0() => "mmx0";

        public string mm1() => "mmx1";

        public string mm2() => "mmx2";

        public string mm3() => "mmx3";

        public string mm4() => "mmx4";

        public string mm5() => "mmx5";

        public string mm6() => "mmx6";

        public string mm7() => "mmx7";

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

        const string GpRegText = R0 + R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8 + R9 + R10 + R11 + R12 + R13 + R14 + R15;

        const byte RegLength = 4;

        const byte RowLength = 4*RegLength;

        const byte GpRowCount = 16;

        const ushort GpRegsLength = RowLength*GpRowCount;

        static ReadOnlySpan<char> GpRegChars => GpRegText;

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(GpClass gp)
            => GpRegChars;

        [MethodImpl(Inline), Op]
        static ushort offsset(GpClass gp, RegIndex index, RegWidthIndex width)
        {
            var row = (uint)((uint)index*RowLength);
            var col = z32;
            if(width == RegWidthIndex.W64)
                col = 0;
            else if(width == RegWidthIndex.W32)
                col = 4;
            else if(width == RegWidthIndex.W16)
                col = 8;
            else
                col = 12;

            return (ushort)(row + col);
        }

        [MethodImpl(Inline), Op]
        public static RegName name(GpClass gp, RegIndex index, RegWidthIndex width)
        {
            var gpchars = chars(gp);
            var data = 0ul;
            var i0 = offsset(gp,index,width);
            data = first(recover<ulong>(core.slice(gpchars,i0,RegLength)));
            return new RegName(data);
        }

        [MethodImpl(Inline), Op]
        public static string format(RegName src)
        {
            var chars = recover<char>(bytes(src));
            return new string(chars);
        }

        [MethodImpl(Inline), Op]
        public static RegName name(RegOp src)
            => name(GP, src.Index, (RegWidthIndex)(src.Bitfield & 0b111));
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