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
    public readonly struct ModRm
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        public ModRm(byte src)
            => Data = src;

        /// <summary>
        /// Defines bits [2:0] of the modrm byte
        /// </summary>
        public uint3 Rm()
            => Bits.segment(Data, 0, 2);

        /// <summary>
        /// Defines bits [5:3] of the modrm byte
        /// </summary>
        public uint3 Reg()
            => Bits.segment(Data, 3, 5);

        /// <summary>
        /// Defines bits [7:6] of the modrm byte
        /// </summary>
        public uint2 Mod()
            => Bits.segment(Data, 6, 7);

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
            => new ModRm(Bytes.xor(a.Data, b.Data));

        [MethodImpl(Inline)]
        public static ModRm operator |(ModRm a, ModRm b)
            => new ModRm(Bytes.or(a.Data, b.Data));

        public static ModRm Empty => default;
    }
}