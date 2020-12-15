//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static BitMasks;

    partial class Bits
    {
        /// <summary>
        /// Unpacks 16 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x16(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);

            Bits.unpack1x8x8((byte)src, ref tmp);
            vconvert32u(n64, in tmp, n256).StoreTo(ref lead);
            Bits.unpack1x8x8((byte)(src >> 8), ref tmp);
            vconvert32u(n64, in tmp, n256).StoreTo(ref lead, 8);
        }
    }
}