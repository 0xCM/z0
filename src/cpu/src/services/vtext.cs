//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct vtext
    {
        /// <summary>
        /// Converts 16 source characters to 16 asci codes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="offset">The source offset</param>
        /// <param name="count">The number of source characters to convert</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline), Op]
        public static void pack(in CharBlock16 src, uint offset, ref ByteBlock16 dst)
            => cpu.vstore(cpu.vpack128x8u(cpu.vload(w256, skip(@char(src), offset))), ref @byte(dst));

        [MethodImpl(Inline), Op]
        public static void unpack(in ByteBlock32 src, ref CharBlock32 dst)
        {
            var v = cpu.vload(w256, src.Bytes);

            var x0 = cpu.vinflatelo256x16u(v);
            ref var y0 = ref u16(dst);
            cpu.vstore(x0, ref y0);

            var x1 = cpu.vinflatehi256x16u(v);
            ref var y1 = ref seek(u16(dst),16);
            cpu.vstore(x1, ref y1);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in ByteBlock32 src)
        {
            var v = cpu.vload(w256, src.Bytes);
            var lo = cpu.vinflatelo256x16u(v);
            var hi = cpu.vinflatehi256x16u(v);
            return recover<char>(bytes(new V256x2(lo,hi)));
        }

        public static void bits(Vector128<byte> src, Span<char> dst)
        {
            var a = cpu.vinflate256x8u(cpu.vcell(src,1), 0);
            var lo = cpu.vlo256x16u(a);
            ref var target = ref u16(first(dst));
            cpu.vstore(lo, ref seek(target,0));
            var hi = cpu.vhi256x16u(a);
            cpu.vstore(hi, ref seek(target,16));
        }

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vunicode(W256 w, ReadOnlySpan<char> src)
            => cpu.vload(w, recover<ushort>(src));

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vasci(W256 w, ReadOnlySpan<byte> src)
            => cpu.vload(w, src);

        [MethodImpl(Inline), Op]
        public static ref CharBlock16 copy(ReadOnlySpan<char> src, ref CharBlock16 dst)
        {
            cpu.vstore(cpu.vload(w128, first(recover<char,byte>(src))), ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock32 copy(ReadOnlySpan<char> src, ref CharBlock32 dst)
        {
            cpu.vstore(cpu.vload(w256, u8(dst)), ref u8(dst));
            return ref dst;
        }
    }
}