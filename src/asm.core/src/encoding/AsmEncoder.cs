//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using K = RexPrefixKind;

    [ApiHost]
    public readonly partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static Hex8 rex()
            => (byte)K.Base;

        [MethodImpl(Inline), Op]
        public static AsmHexCode rex(uint4 wrxb, uint4 index)
        {
            var dst = AsmBytes.code();
            dst.Cell(index) = rex(wrxb);
            dst.Cell(15) = 1;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Hex8 rex(uint4 wrxb)
            => math.or((byte)K.Base, (byte)wrxb);

        [MethodImpl(Inline), Op]
        public static byte rex(bit b, bit x, bit r, bit w)
        {
            var bx = math.slor((byte)b, 0, (byte)x, 1);
            var rw = math.slor((byte)r, 2, (byte)w, 3);
            return math.or(bx, rw, rex());
        }

        [MethodImpl(Inline), Op]
        public static bit test(K src, K match)
            => (src & match) == match;

        [MethodImpl(Inline), Op]
        public static Hex8 rex(K kind)
        {
            var dst = rex();

            if(test(kind, K.W))
                dst |= (byte)K.W;

            if(test(kind, K.R))
                dst |= (byte)K.R;

            if(test(kind, K.X))
                dst |= (byte)K.X;

            if(test(kind, K.W))
                dst |= (byte)K.W;

            return dst;
        }


    }
}