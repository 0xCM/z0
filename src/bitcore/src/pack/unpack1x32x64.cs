//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Bits
    {
        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack1x32x64(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            var wSrc = w64;
            var wDst = w256;
            unpack1x8x8((byte)src, ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead);
            unpack1x8x8((byte)(src >> 8), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 8);
            unpack1x8x8((byte)(src >> 16), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 16);
            unpack1x8x8((byte)(src >> 24), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 24);
            unpack1x8x8((byte)(src >> 32), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 32);
            unpack1x8x8((byte)(src >> 40), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 40);
            unpack1x8x8((byte)(src >> 48), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 48);
            unpack1x8x8((byte)(src >> 56), ref tmp);
            cpu.vconvert32u(wSrc, tmp, wDst).StoreTo(ref lead, 56);
        }
    }
}