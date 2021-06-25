//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /*
        Mod | Reg | Rm  | Effective
        00  | 000 | 000 | [bx + si]
        00  | 000 | 001 | [bx + di]
        00  | 000 | 010 | [bp + si]
        00  | 000 | 011 | [bp + di]
        00  | 000 | 100 | [si]
        00  | 000 | 101 | [di]
        00  | 000 | 110 | disp16
        00  | 000 | 111 | [bx]
        01  | 000 | 000 | [bx + si] + disp8
        01  | 000 | 001 | [bx + di] + disp8
        01  | 000 | 010 | [bp + si] + disp8
        01  | 000 | 011 | [bp + di] + disp8
        01  | 000 | 100 | [si] + disp8
        01  | 000 | 101 | [di] + disp8
        01  | 000 | 110 | [bp] + disp8
        01  | 000 | 111 | [bx] + disp8
        10  | 000 | 000 | [bx + si] + disp16
        10  | 000 | 001 | [bx + di] + disp16
        10  | 000 | 010 | [bp + si] + disp16
        10  | 000 | 011 | [bp + di] + disp16
        10  | 000 | 100 | [si] + disp16
        10  | 000 | 101 | [di] + disp16
        10  | 000 | 110 | [bp] + disp16
        10  | 000 | 111 | [bx] + disp16
        11  | 000 | 000 | eax/ax/al/mm0/xmm0
        11  | 000 | 001 | ecx/cx/cl/mm1/xmm1
        11  | 000 | 010 | edx/dx/dl/mm2/xmm2
        11  | 000 | 011 | ebx/bx/bl/mm3/xmm3
        11  | 000 | 100 | esp/sp/ah/mm4/xmm4
        11  | 000 | 101 | ebp/bp/ch/mm5/xmm5
        11  | 000 | 110 | esi/si/dh/mm6/xmm6
        11  | 000 | 111 | edi/di/bh/mm7/xmm7

    */

    /// <summary>
    /// ModRM[mod[7:6] | reg[5:3] | r/m[2:0]]
    /// </summary>
    [ApiComplete]
    public struct ModRm
    {
        byte Data;

        [MethodImpl(Inline)]
        public ModRm(byte src)
            => Data = src;

        /// <summary>
        /// Reads bits [2:0] of the modrm byte
        /// </summary>
        [MethodImpl(Inline)]
        public byte Rm()
            => Bits.segment(Data, 0, 2);

        [MethodImpl(Inline)]
        public void Rm(byte rm)
            => Data = Bits.replace(Data, 0, 2, rm);

        /// <summary>
        /// Reads bits [5:3] of the modrm byte that specifies a register operand or extends the operation encoding
        /// </summary>
        [MethodImpl(Inline)]
        public byte Reg()
            => Bits.segment(Data, 3, 5);

        [MethodImpl(Inline)]
        public void Reg(byte reg)
            => Data = Bits.replace(Data, 3, 5, reg);

        /// <summary>
        /// Reads bits [7:6] of the modrm byte that, together with the r/m field, specifies an operand addressing mode
        /// </summary>
        [MethodImpl(Inline)]
        public byte Mod()
            => Bits.segment(Data, 6, 7);

        [MethodImpl(Inline)]
        public void Mod(byte mod)
            => Data = Bits.replace(Data, 6, 7, mod);

        /// <summary>
        /// The encoded bitfield value
        /// </summary>
        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => (byte)Data != 0;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => (byte)Data == 0;
        }

        [MethodImpl(Inline)]
        public static ModRm operator ^(ModRm a, ModRm b)
            => new ModRm(math.xor(a.Data, b.Data));

        [MethodImpl(Inline)]
        public static ModRm operator |(ModRm a, ModRm b)
            => new ModRm(math.or(a.Data, b.Data));

        public static ModRm Empty => default;
    }
}