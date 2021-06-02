//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    partial struct BitNumbers
    {
        [MethodImpl(Inline), Op]
        public static ScaledIndex scaled(W8 w, N4 n, uint i)
            => new ScaledIndex(8, 4, -2, i);

        [MethodImpl(Inline), Op]
        public static NibbleSpan nibbles(Span<byte> src)
            => new NibbleSpan(src);

        [MethodImpl(Inline), Op]
        public static uint count(in NibbleSpan src)
            => src.Width/4;

        [MethodImpl(Inline), Op]
        public static uint4 read(in NibbleSpan src, uint index)
        {
            var cell = scaled(w8, n4, index);
            ref readonly var c = ref skip(src.Bytes, cell.Offset);
            return cell.Even ? uint4(c) : uint4(Bytes.srl(c , cell.CellWidth));
        }

        [MethodImpl(Inline), Op]
        public static void write(uint4 src, uint index, in NibbleSpan dst)
        {
            const byte UpperMask = 0xF0;

            const byte LowerMask = 0x0F;

            var cell = scaled(w8, n4, index);
            ref var c = ref seek(dst.Bytes, cell.Offset);
            if(cell.Even)
                c = Bytes.or(Bytes.and(c, UpperMask), src);
            else
                c = Bytes.or(Bytes.sll(src, cell.CellWidth), Bytes.and(c, LowerMask));
        }
    }
}