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

    partial struct BitPack
    {
        [Op]
        public static Span<byte> pack(ReadOnlySpan<byte> src, uint offset = 0, int? minlen = null)
        {
            const byte M = 8;

            if(src.Length <= offset)
                return alloc<byte>(minlen ?? 1);

            var srcLen = (uint)(src.Length - offset);
            var dstLen = srcLen/M + (srcLen % M == 0 ? 0 : 1);
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            var dst = span<byte>((int)dstLen);
            pack(src, offset, ref first(dst));

            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void pack(ReadOnlySpan<byte> src, uint offset, ref byte dst)
        {
            const byte M = 8;
            var kIn = (uint)(src.Length - offset);
            var kOut = kIn/M + (kIn % M == 0 ? 0 : 1);
            for(int i=0, j=0; j<kOut; i+=M, j++)
            {
                ref var x = ref seek(dst, j);
                for(var k=0; k<M; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < kIn && skip(src,srcIx) != 0)
                        x |= (byte)(1 << k);
                }
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T pack<T>(ReadOnlySpan<byte> src, out T dst, uint offset = 0)
            where T : unmanaged
        {
            dst = default;
            var buffer = bytes(dst);
            pack(src, offset, ref first(buffer));
            return ref dst;
        }
    }
}