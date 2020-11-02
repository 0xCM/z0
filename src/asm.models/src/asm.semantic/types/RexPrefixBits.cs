//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static UInt4;

    using RFI = RexFieldIndex;
    using RFW = RexFieldWidth;
    using RF = RexFieldIndex;

    /// <summary>
    /// A prefix that occurs at most once and is applicable to instructions in 64-bit mode and which facilitates specifying
    /// a) gp and sse register operands
    /// b) 64-bit operand size
    /// c) extended control register operands
    /// </summary>
    public struct RexPrefixBits : IScalarBitField<byte>
    {
        public static RexPrefixBits Empty
            => Define(0,0,0,0,0);

        byte Data;

        [MethodImpl(Inline)]
        public static RexPrefixBits define(byte src)
            => new RexPrefixBits(src);

        public static ref RexPrefixBits BitCopy(in RexPrefixBits src, ref RexPrefixBits dst)
        {
            var bf = RexPrefixBits.BitField;
            bf.Write(RFI.B, src, ref dst);
            bf.Write(RFI.X, src, ref dst);
            bf.Write(RFI.R, src, ref dst);
            bf.Write(RFI.W, src, ref dst);
            bf.Write(RFI.Code, src, ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static byte Encode(bit b, bit x, bit r, bit w)
        {
            var rex = math.sll((byte)b0100, 4);
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx,rw,rex);
        }

        [MethodImpl(Inline)]
        public static RexPrefixBits Define(bit b, bit x, bit r, bit w, RexPrefixCode code)
        {
            var data = (byte)gmath.or(
                gmath.sll(b, RFI.B),
                gmath.sll(x, RFI.X),
                gmath.sll(r, RFI.R),
                gmath.sll(w, RFI.W),
                gmath.sll((uint)code, RFI.Code));
            return define(data);
        }

        /// <summary>
        /// Creates a bitfield over the rex prefix data structure and using the index/width
        /// enumerations to specified the bit layout
        /// </summary>
        public static BitField<RexPrefixBits,RexFieldIndex,byte> BitField
        {
            [MethodImpl(Inline)]
            get => BitFields.create<RexPrefixBits,RexFieldIndex,byte,RexFieldWidth>();
        }

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

        [MethodImpl(Inline)]
        public RexPrefixBits(byte src)
            => Data = src;

        public bit B
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Scalar,(byte)RFI.B);

            [MethodImpl(Inline)]
            set => Update(gbits.setbit(Scalar,(byte)RFI.B, value));
        }

        public bit X
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Scalar, (byte)RFI.X);

            [MethodImpl(Inline)]
            set => Update(gbits.setbit(Scalar, (byte)RFI.X, value));
        }

        public bit R
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Scalar, (byte)RFI.R);

            [MethodImpl(Inline)]
            set => Update(gbits.setbit(Scalar, (byte)RFI.R, value));
        }

        public bit W
        {
            [MethodImpl(Inline)]
            get => gbits.testbit(Scalar, (byte)RFI.W);

            [MethodImpl(Inline)]
            set => Update(gbits.setbit(Scalar, (byte)RFI.W, value));
        }

        public RexPrefixCode Code
        {
            [MethodImpl(Inline)]
            get => (RexPrefixCode)gbits.slice(Scalar, 4, (byte)RFW.Code);

            [MethodImpl(Inline)]
            set => Update(gbits.copy((byte)value, 4, (byte)RFW.Code, Scalar));
        }

        public string Render()
            => $"{RF.Code}:{Code} | {RF.W}:{W} | {RF.R}:{R} | {RF.X}:{X} | {RF.B}:{B}";
    }
}