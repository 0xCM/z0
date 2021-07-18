//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// ModRM[mod[7:6] | reg[5:3] | r/m[2:0]]
    /// </summary>
    [ApiComplete]
    public struct ModRmByte
    {
        byte Data;

        [MethodImpl(Inline)]
        public ModRmByte(byte src)
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
        public static ModRmByte operator ^(ModRmByte a, ModRmByte b)
            => new ModRmByte(math.xor(a.Data, b.Data));

        [MethodImpl(Inline)]
        public static ModRmByte operator |(ModRmByte a, ModRmByte b)
            => new ModRmByte(math.or(a.Data, b.Data));

        [MethodImpl(Inline)]
        public static implicit operator byte(ModRmByte src)
            => src.Encoded;

        public static ModRmByte Empty => default;
    }
}