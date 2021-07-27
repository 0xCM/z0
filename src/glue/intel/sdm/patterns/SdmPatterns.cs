//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;

    readonly partial struct SdmPatterns
    {
        public const string Vex128Version = "(VEX.128 encoded version)";

        public const string Vex256Version = "(VEX.256 encoded version)";

        public const string EvexVersions = "(EVEX encoded versions)";

        public const string PageNumber = "{Chapter}-{Page} Vol. {Vol}";

        public const string MnemonicTitle = "{Mnemonic} — {Description}";

        public const string MultiMnemonicTitle1 = "{Mnemonic}/{0}";

        public const string MultiMnemonicTitle2 = "{Mnemonic}/{0}/{1}";

        public const string MultiMnemonicTitle3 = "{Mnemonic}/{0}/{1}/{2}";

        public static string[] OpCodeHeader0 = new string[9]{"Opcode", "Instruction", "Op/", "En", "64-Bit", "Mode", "Compat/", "Leg Mode", "Description"};

        public static string[] OpCodeHeader1 = new string[11]{"Opcode/", "Instruction", "Op/", "En", "64/32", "-bit", "Mode", "CPUID", "Feature", "Flag", "Description"};

        public static string[] OpCodeHeader2 = new string[12]{"Opcode/", "Instruction", "Op /", "En", "64/32", "bit", "Mode", "Support", "CPUID", "Feature", "Flag", "Description"};

        public static string[] EncodingHeader = new string[5]{"Op/En", "Operand 1", "Operand 2", "Operand 3", "Operand 4"};
    }

    /*

KL := 16 | 32 | 64
VL := 128 | 256 | 512

VPBROADCASTB xmm1 {k1}{z}, reg
void vpbroadcastb(r8 src, k1, z, out xmm dst)
{
    const KL=16;
    const VL=128;

    for(var j=0; j<KL; j++)
    {
        var i = j*8;
        if(k1[j] == 1 || !writemask(?))
            dst[i+7:i] = src[7:0]
        else if(mergemasking)
        {
            //noop
        }
        else if(zeromasking)
        {
            dst[i+7:i] = 0
        }
    }

    dst[MAXVL-1:VL] = 0;
}

VPBROADCASTB (EVEX encoded versions)
(KL, VL) = (16, 128), (32, 256), (64, 512)
FOR j := 0 TO KL-1
i := j * 8
IF k1[j] OR *no writemask*
THEN DEST[i+7:i] := SRC[7:0]
ELSE
IF *merging-masking*
; merging-masking
THEN *DEST[i+7:i] remains unchanged*
ELSE
; zeroing-masking
DEST[i+7:i] := 0
FI
FI;
ENDFOR
DEST[MAXVL-1:VL] := 0

VPBROADCASTW (EVEX encoded versions)
(KL, VL) = (8, 128), (16, 256), (32, 512)
FOR j := 0 TO KL-1
i := j * 16
IF k1[j] OR *no writemask*
THEN DEST[i+15:i] := SRC[15:0]
ELSE
IF *merging-masking*
; merging-masking
THEN *DEST[i+15:i] remains unchanged*
ELSE
; zeroing-masking
DEST[i+15:i] := 0
FI
FI;
ENDFOR
DEST[MAXVL-1:VL] := 0

VPBROADCASTD (EVEX encoded versions)
(KL, VL) = (4, 128), (8, 256), (16, 512)
FOR j := 0 TO KL-1
i := j * 32
IF k1[j] OR *no writemask*
THEN DEST[i+31:i] := SRC[31:0]
ELSE
IF *merging-masking*
; merging-masking
THEN *DEST[i+31:i] remains unchanged*
ELSE
; zeroing-masking
DEST[i+31:i] := 0
FI
FI;
ENDFOR
DEST[MAXVL-1:VL] := 0

VPBROADCASTB/W/D/Q—Load with Broadcast Integer Data from General Purpose Register
INSTRUCTION SET REFERENCE, V-Z
Vol. 2C 5-311
VPBROADCASTQ (EVEX encoded versions)
(KL, VL) = (2, 128), (4, 256), (8, 512)
FOR j := 0 TO KL-1
i := j * 64
IF k1[j] OR *no writemask*
THEN DEST[i+63:i] := SRC[63:0]
ELSE
IF *merging-masking*
; merging-masking
THEN *DEST[i+63:i] remains unchanged*
ELSE
; zeroing-masking
DEST[i+63:i] := 0
FI
FI;
ENDFOR
DEST[MAXVL-1:VL] := 0


OpCodeHeader0

34 ib
XOR AL, imm8
I
Valid
Valid
AL XOR imm8.

35 iw
XOR AX, imm16
I
Valid
Valid
AX XOR imm16.

35 id
XOR EAX, imm32
I
Valid
Valid
EAX XOR imm32.

REX.W + 35 id
XOR RAX, imm32
I
Valid
N.E.
RAX XOR imm32 (sign-extended).

80 /6 ib
XOR r/m8, imm8
MI
Valid
Valid
r/m8 XOR imm8.

REX + 80 /6 ib
XOR r/m8*, imm8
MI
Valid
N.E.
r/m8 XOR imm8.

81 /6 iw
XOR r/m16, imm16
MI
Valid
Valid
r/m16 XOR imm16.

81 /6 id
XOR r/m32, imm32
MI
Valid
Valid
r/m32 XOR imm32.

REX.W + 81 /6 id
XOR r/m64, imm32
MI
Valid
N.E.
r/m64 XOR imm32 (sign-extended).

83 /6 ib
XOR r/m16, imm8
MI
Valid
Valid
r/m16 XOR imm8 (sign-extended).

83 /6 ib
XOR r/m32, imm8
MI
Valid
Valid
r/m32 XOR imm8 (sign-extended).

REX.W + 83 /6 ib
XOR r/m64, imm8
MI
Valid
N.E.
r/m64 XOR imm8 (sign-extended).

30 /r
XOR r/m8, r8
MR
Valid
Valid
r/m8 XOR r8.

REX + 30 /r
XOR r/m8*, r8*
MR
Valid
N.E.
r/m8 XOR r8.

31 /r
XOR r/m16, r16
MR
Valid
Valid
r/m16 XOR r16.

31 /r
XOR r/m32, r32
MR
Valid
Valid
r/m32 XOR r32.

REX.W + 31 /r
XOR r/m64, r64
MR
Valid
N.E.
r/m64 XOR r64.

32 /r
XOR r8, r/m8
RM
Valid
Valid
r8 XOR r/m8.

REX + 32 /r
XOR r8*, r/m8*
RM
Valid
N.E.
r8 XOR r/m8.

33 /r
XOR r16, r/m16
RM
Valid
Valid
r16 XOR r/m16.

33 /r
XOR r32, r/m32
RM
Valid
Valid
r32 XOR r/m32.

REX.W + 33 /r
XOR r64, r/m64
RM
Valid
N.E.
r64 XOR r/m64.

OpCodeHeader2
Opcode/
Instruction
Op /
En
64/32
bit
Mode
Support
CPUID
Feature
Flag
Description

EVEX.128.66.0F38.W0 7A /r
VPBROADCASTB xmm1 {k1}{z}, reg
A
V/V
AVX512VL
AVX512BW
Broadcast an 8-bit value from a GPR to all bytes in the
128-bit destination subject to writemask k1.

EVEX.256.66.0F38.W0 7A /r
VPBROADCASTB ymm1 {k1}{z}, reg
A
V/V
AVX512VL
AVX512BW
Broadcast an 8-bit value from a GPR to all bytes in the
256-bit destination subject to writemask k1.

EVEX.512.66.0F38.W0 7A /r
VPBROADCASTB zmm1 {k1}{z}, reg
A
V/V
AVX512BW
Broadcast an 8-bit value from a GPR to all bytes in the
512-bit destination subject to writemask k1.

EVEX.128.66.0F38.W0 7B /r
VPBROADCASTW xmm1 {k1}{z}, reg
A
V/V
AVX512VL
AVX512BW
Broadcast a 16-bit value from a GPR to all words in the
128-bit destination subject to writemask k1.

EVEX.256.66.0F38.W0 7B /r
VPBROADCASTW ymm1 {k1}{z}, reg
A
V/V
AVX512VL
AVX512BW
Broadcast a 16-bit value from a GPR to all words in the
256-bit destination subject to writemask k1.

EVEX.512.66.0F38.W0 7B /r
VPBROADCASTW zmm1 {k1}{z}, reg
A
V/V

AVX512BW
Broadcast a 16-bit value from a GPR to all words in the
512-bit destination subject to writemask k1.

EVEX.128.66.0F38.W0 7C /r
VPBROADCASTD xmm1 {k1}{z}, r32
A
V/V

AVX512VL
AVX512F
Broadcast a 32-bit value from a GPR to all double-words
in the 128-bit destination subject to writemask k1.
EVEX.256.66.0F38.W0 7C /r
VPBROADCASTD ymm1 {k1}{z}, r32
A
V/V
AVX512VL
AVX512F
Broadcast a 32-bit value from a GPR to all double-words
in the 256-bit destination subject to writemask k1.
EVEX.512.66.0F38.W0 7C /r
VPBROADCASTD zmm1 {k1}{z}, r32
A
V/V
AVX512F
Broadcast a 32-bit value from a GPR to all double-words
in the 512-bit destination subject to writemask k1.
EVEX.128.66.0F38.W1 7C /r
VPBROADCASTQ xmm1 {k1}{z}, r64
A
V/N.E.1
AVX512VL
AVX512F
Broadcast a 64-bit value from a GPR to all quad-words in
the 128-bit destination subject to writemask k1.
EVEX.256.66.0F38.W1 7C /r
VPBROADCASTQ ymm1 {k1}{z}, r64
A
V/N.E.1
AVX512VL
AVX512F
Broadcast a 64-bit value from a GPR to all quad-words in
the 256-bit destination subject to writemask k1.
EVEX.512.66.0F38.W1 7C /r
VPBROADCASTQ zmm1 {k1}{z}, r64
A
V/N.E.1

    */
}