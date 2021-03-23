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

    using I = RexFieldIndex;
    using W = RexFieldWidth;
    using RF = RexFieldIndex;

    [ApiHost]
    public sealed class Rex : WfService<Rex>
    {
        readonly BitFieldSpec FieldSpec;

        public Rex()
        {
            FieldSpec = BitFieldSpecs.define<I,byte,W>();
        }

        [MethodImpl(Inline), Op]
        public byte Encode(bit b, bit x, bit r, bit w)
        {
            var rex = math.sll((byte)b0100, 4);
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx, rw, rex);
        }

        [MethodImpl(Inline), Op]
        BitField<RexBits,RexFieldIndex,byte> BitField()
            => BitFields.create<RexBits,RexFieldIndex,byte>(FieldSpec);

        [MethodImpl(Inline), Op]
        public RexBits Encode(bit b, bit x, bit r, bit w, RexPrefixCode code)
        {
            var data = (byte)gmath.or(
                emath.sll(b, I.B),
                emath.sll(x, I.X),
                emath.sll(r, I.R),
                emath.sll(w, I.W),
                emath.sll((uint)code, I.Code));
            return new RexBits(data);
        }

        [MethodImpl(Inline), Op]
        public static bit test(byte src)
            => (uint4)(src >> 4) == b0100;

        [MethodImpl(Inline), Op]
        public static bit test(AsmHexCode src)
            => AsmQuery.IsRexPrefix(skip(src.Bytes,0));


        [MethodImpl(Inline), Op]
        public static RexBits define(byte src)
            => test(src) ? new RexBits(src) : RexBits.Empty;


        [MethodImpl(Inline), Op]
        public static RexBits next(RexBits src)
        {
            if(src.Data < RexBits.MaxRexCode)
                return new RexBits(++src.Data);
            else
                return new RexBits(RexBits.MinRexCode);
        }

        [MethodImpl(Inline), Op]
        public static RexBits prior(RexBits src)
        {
            if(src.Data > RexBits.MinRexCode)
                return new RexBits(--src.Data);
            else
                return new RexBits(RexBits.MaxRexCode);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexBits> bits()
            => recover<RexBits>(RexBits.All);

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
        public static string FormatRow(RexBits src)
            => $"{src.Format()} | {bits(src)} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B}";
    }
}