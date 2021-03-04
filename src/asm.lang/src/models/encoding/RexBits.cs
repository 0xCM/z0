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
    using static memory;

    using RFI = RexFieldIndex;
    using RFW = RexFieldWidth;
    using RF = RexFieldIndex;

    /// <summary>
    /// REX = [ [0100] | W:4 | R:3 | X:2 | B:1 ]
    /// </summary>
    [ApiHost]
    public struct RexBits : IScalarBitField<byte>
    {
        const byte MinRexCode = 0x40;

        const byte MaxRexCode = 0x4F;

        [MethodImpl(Inline), Op]
        public static RexBits first()
            => new RexBits(MinRexCode);

        [MethodImpl(Inline), Op]
        public static RexBits last()
            => new RexBits(MaxRexCode);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexBits> all()
            => recover<RexBits>(All);

        [MethodImpl(Inline), Op]
        public static RexBits next(RexBits src)
        {
            if(src.Data < MaxRexCode)
                return new RexBits(++src.Data);
            else
                return first();
        }

        [MethodImpl(Inline), Op]
        public static RexBits prior(RexBits src)
        {
            if(src.Data > MinRexCode)
                return new RexBits(--src.Data);
            else
                return last();
        }

        static Identifier symbol(RexBits src)
        {
            if(src.Code == RexPrefixCode.RexW)
                return "REX.W";
            else
                return "";
        }

        static string hexcode(RexBits src)
            => src.Data.FormatAsmHex();

        [Op]
        static string bits(RexBits src)
        {
            var bs = src.Data.FormatBits();
            var chars = text.span(bs);
            var lo = slice(chars,0,4);
            var hi = slice(chars,4,4);
            return text.format("[{0} {1}]", lo, hi);
        }

        [Op]
        public static string format(RexBits src)
            => $"{hexcode(src)} | {bits(src)} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B} | {symbol(src)}";

        [MethodImpl(Inline), Op]
        public static bit test(byte src)
            => (uint4)(src >> 4) == b0100;

        [MethodImpl(Inline), Op]
        public static RexBits define(byte src)
            => test(src) ? new RexBits(src) : default;

        byte Data;

        [MethodImpl(Inline)]
        public RexBits(byte src)
            => Data = src;

        public byte Scalar
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
            get => bit.test(Scalar, (byte)RFI.W);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.W, value));
        }

        /// <summary>
        /// Indicates an extension of the ModR/M reg field
        /// </summary>
        public bit R
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar, (byte)RFI.R);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.R, value));
        }

        /// <summary>
        /// Indicates an extension of the SIB index field
        /// </summary>
        public bit X
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar, (byte)RFI.X);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.X, value));
        }

        /// <summary>
        /// Indicates an extension of the ModR/M r/m field, SIB base field, or Opcode reg field
        /// </summary>
        public bit B
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar,(byte)RFI.B);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar,(byte)RFI.B, value));
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
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static RexBits operator ++(RexBits src)
            => next(src);

        [MethodImpl(Inline)]
        public static RexBits operator --(RexBits src)
            => prior(src);

        public static RexBits Empty
            => new RexBits(0);

        static ReadOnlySpan<byte> All
            => new byte[16]{0x40,0x41,0x42,0x43,0x44,0x45,0x46,0x47,0x48,0x49,0x4A,0x4B,0x4C,0x4D,0x4E,0x4F};
    }
}