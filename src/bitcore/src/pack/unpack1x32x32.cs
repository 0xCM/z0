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
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x32(uint src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack1x8x8((byte)src, ref tmp);
            cpu.vconvert32u(n64, in tmp, n256).StoreTo(ref lead);
            unpack1x8x8((byte)(src >> 8), ref tmp);
            cpu.vconvert32u(n64, in tmp, n256).StoreTo(ref lead, 8);
            unpack1x8x8((byte)(src >> 16), ref tmp);
            cpu.vconvert32u(n64, in tmp, n256).StoreTo(ref lead, 16);
            unpack1x8x8((byte)(src >> 24), ref tmp);
            cpu.vconvert32u(n64, in tmp, n256).StoreTo(ref lead, 24);
        }
    }
}