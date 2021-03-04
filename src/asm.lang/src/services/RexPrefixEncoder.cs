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

    using I = RexFieldIndex;
    using W = RexFieldWidth;

    [ApiHost]
    public sealed class RexPrefixEncoder : WfService<RexPrefixEncoder>
    {
        readonly BitFieldSpec FieldSpec;

        public RexPrefixEncoder()
        {
            FieldSpec = BitFieldModels.specify<I,byte,W>();
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
        public static RexBits define(byte src)
            => test(src) ? new RexBits(src) : RexBits.Empty;
    }
}