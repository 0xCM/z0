//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BitSeq4;

    using RFI = RexFieldIndex;
    using api = Rex;

    /// <summary>
    /// REX = [ [0100] | W:4 | R:3 | X:2 | B:1 ]
    /// </summary>
    [ApiHost]
    public struct RexBits : INumericBits<byte>
    {
        [MethodImpl(Inline), Op]
        public static bit test(byte src)
            => (uint4)(src >> 4) == b0100;

        [MethodImpl(Inline), Op]
        public static RexBits define(byte src)
            => test(src) ? new RexBits(src) : default;

        internal byte Data;

        [MethodImpl(Inline)]
        public RexBits(byte src)
            => Data = src;

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public ref readonly byte Update(in byte src)
        {
            Data = src;
            return ref src;
        }

        /// <summary>
        /// When enabled, indicates a 64-bit operand size; if not, operand size determined by CS.D
        /// </summary>
        public bit W
        {
            [MethodImpl(Inline)]
            get => bit.test(Content, (byte)RFI.W);

            [MethodImpl(Inline)]
            set => Update(bit.set(Content, (byte)RFI.W, value));
        }

        /// <summary>
        /// Indicates an extension of the ModR/M reg field
        /// </summary>
        public bit R
        {
            [MethodImpl(Inline)]
            get => bit.test(Content, (byte)RFI.R);

            [MethodImpl(Inline)]
            set => Update(bit.set(Content, (byte)RFI.R, value));
        }

        /// <summary>
        /// Indicates an extension of the SIB index field
        /// </summary>
        public bit X
        {
            [MethodImpl(Inline)]
            get => bit.test(Content, (byte)RFI.X);

            [MethodImpl(Inline)]
            set => Update(bit.set(Content, (byte)RFI.X, value));
        }

        /// <summary>
        /// Indicates an extension of the ModR/M r/m field, SIB base field, or Opcode reg field
        /// </summary>
        public bit B
        {
            [MethodImpl(Inline)]
            get => bit.test(Content,(byte)RFI.B);

            [MethodImpl(Inline)]
            set => Update(bit.set(Content,(byte)RFI.B, value));
        }

        public RexPrefixCode Code
        {
            [MethodImpl(Inline)]
            get => (RexPrefixCode)Data;

            [MethodImpl(Inline)]
            set => Data = (byte)value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == 0;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static RexBits operator ++(RexBits src)
            => api.next(src);

        [MethodImpl(Inline)]
        public static RexBits operator --(RexBits src)
            => api.prior(src);

        public static RexBits Empty
            => new RexBits(0);

        internal const byte MinRexCode = 0x40;

        internal const byte MaxRexCode = 0x4F;

        internal static ReadOnlySpan<byte> All
            => new byte[16]{0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,0x48,0x49,0x4A,0x4B,0x4C,0x4D,0x4E,0x4F};
    }
}