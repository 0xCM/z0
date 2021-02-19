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
    using RFW = RexFieldWidth;
    using RF = RexFieldIndex;

    /// <summary>
    /// A prefix that occurs at most once and is applicable to instructions in 64-bit mode and which facilitates specifying
    /// a) gp and sse register operands
    /// b) 64-bit operand size
    /// c) extended control register operands
    /// </summary>
    [ApiHost]
    public struct RexPrefixBits : IScalarBitField<byte>
    {
        byte Data;

        [MethodImpl(Inline)]
        public RexPrefixBits(byte src)
            => Data = src;

        [Op]
        public static string format(RexPrefixBits src)
            => $"{RF.Code}:{src.Code} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";

        [MethodImpl(Inline), Op]
        public static bit test(byte src)
            => (uint4)(src >> 4) == b0100;

        [MethodImpl(Inline), Op]
        public static RexPrefixBits define(byte src)
            => test(src) ? new RexPrefixBits(src) : default;

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

        public bit B
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar,(byte)RFI.B);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar,(byte)RFI.B, value));
        }

        public bit X
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar, (byte)RFI.X);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.X, value));
        }

        public bit R
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar, (byte)RFI.R);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.R, value));
        }

        public bit W
        {
            [MethodImpl(Inline)]
            get => bit.test(Scalar, (byte)RFI.W);

            [MethodImpl(Inline)]
            set => Update(bit.set(Scalar, (byte)RFI.W, value));
        }

        public RexPrefixCode Code
        {
            [MethodImpl(Inline)]
            get => (RexPrefixCode)Bits.extract(Scalar, 4, (byte)RFW.Code);

            [MethodImpl(Inline)]
            set => Update(gbits.copy((byte)value, 4, (byte)RFW.Code, Scalar));
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

        public static RexPrefixBits Empty
            => new RexPrefixBits(0);
    }
}