//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct RegLayout
    {
        public RegKind R8;

        public RegKind R16;

        public RegKind R32;

        public RegKind R64;

        public RegKind R128;

        public RegKind R256;

        public RegKind R512;
    }


    /*
        | Index | Code  | [63:0] | [31:0] | [15:0] | [7:0] |
        | 0     | 00000 | rax    | eax    | ax     | al    |
        | 1     | 00001 | rcx    | ecx    | cx     | cl    |
        | 2     | 00010 | rdx    | edx    | dx     | dl    |
        | 3     | 00011 | rbx    | ebx    | bx     | bl    |
        | 4     | 00100 | rsp    | esp    | sp     | spl   |
        | 5     | 00101 | rbp    | ebp    | bp     | bpl   |
        | 6     | 00110 | rsi    | esi    | si     | sil   |
        | 7     | 00111 | rdi    | edi    | di     | dil   |
        | 8     | 01000 | r8     | r8d    | r8w    | r8b   |
        | 9     | 01001 | r9     | r9d    | r9w    | r9b   |
        | 10    | 01010 | r10    | r10d   | r10w   | r10b  |
        | 11    | 01011 | r11    | r11d   | r11w   | r11b  |
        | 12    | 01100 | r12    | r12d   | r12w   | r12b  |
        | 13    | 01101 | r13    | r13d   | r13w   | r13b  |
        | 14    | 01110 | r14    | r14d   | r14w   | r14b  |
        | 15    | 01111 | r15    | r15d   | r15w   | r15b  |

        | Index | Code   | [511:0] | [255:0] | [127:0] |
        | 0     | 000000 | zmm0    | ymm0    | xmm0    |
        | 1     | 000001 | zmm1    | ymm1    | xmm1    |
        | 2     | 000010 | zmm2    | ymm2    | xmm2    |
        | 3     | 000011 | zmm3    | ymm3    | xmm3    |
        | 4     | 000100 | zmm4    | ymm4    | xmm4    |
        | 5     | 000101 | zmm5    | ymm5    | xmm5    |
        | 6     | 000110 | zmm6    | ymm6    | xmm6    |
        | 7     | 000111 | zmm7    | ymm7    | xmm7    |
        | 8     | 001000 | zmm8    | ymm8    | xmm8    |
        | 9     | 001001 | zmm9    | ymm9    | xmm9    |
        | 10    | 001010 | zmm10   | ymm10   | xmm10   |
        | 11    | 001011 | zmm11   | ymm11   | xmm11   |
        | 12    | 001100 | zmm12   | ymm12   | xmm12   |
        | 13    | 001101 | zmm13   | ymm13   | xmm13   |
        | 14    | 001110 | zmm14   | ymm14   | xmm14   |
        | 15    | 001111 | zmm15   | ymm15   | xmm15   |


    */


}