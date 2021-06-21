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
    using static Typed;
    using static vcore;

    [ApiHost]
    public readonly struct AsciBlocks
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock4 src)
        {
            var storage = 0ul;
            ref var dst = ref @as<ulong,char>(storage);
            ref readonly var input = ref @as<byte,uint>(src.First);
            seek(dst, 0) = (char)(byte)(input >> 0);
            seek(dst, 1) = (char)(byte)(input >> 8);
            seek(dst, 2) = (char)(byte)(input >> 16);
            seek(dst, 3) = (char)(byte)(input >> 24);
            return cover(dst, ByteBlock4.Size);
        }

        [MethodImpl(Inline), Op]
        public static void decode(in ByteBlock8 src, ref char dst)
        {
            var decoded = vinflate256x16u(vbytes(w128, src));
            vstore(decoded.GetLower(), ref @as<char,ushort>(dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in ByteBlock16 src, ref char dst)
        {
           var decoded = vinflate256x16u(src.First);
           vstore(decoded, ref @as<char,ushort>(dst));
        }

        [MethodImpl(Inline), Op]
        public static void decode(in ByteBlock32 src, ref char dst)
        {
            decode(src.Lo, ref dst);
            decode(src.Hi, ref seek(dst, 16));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock32 src)
        {
            var dst = CharBlock32.Null;
            decode(src, ref dst.First);
            var length = TextTools.index(dst, '\0');
            if(length == NotFound)
                return dst.Data;
            else
                return slice(dst.Data, 0, length);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock64 src)
        {
            ref var storage = ref src.First;
            var v1 = vload(w256, storage);
            var v2 = vload(w256, seek(storage, 32));
            var x0 = vinflatelo256x16u(v1);
            var x1 = vinflatehi256x16u(v1);
            var x2 = vinflatelo256x16u(v2);
            var x3 = vinflatehi256x16u(v2);
            return recover<char>(bytes(new V256x4(x0, x1, x2, x3)));
        }

        [MethodImpl(Inline), Op]
        public static ByteBlock4 encode(N4 n, ReadOnlySpan<char> src)
        {
            var dst = ByteBlock4.Empty;
            var count = min(n,src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ByteBlock8 encode(N8 n, ReadOnlySpan<char> src)
        {
            var dst = ByteBlock8.Empty;
            var count = min(n,src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ByteBlock16 encode(N16 n, ReadOnlySpan<char> src)
        {
            var dst = ByteBlock16.Empty;
            var count = min(n,src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock16 encode(ReadOnlySpan<char> src, out ByteBlock16 dst)
        {
            dst = default;
            var count = min(ByteBlock16.N, src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ByteBlock32 encode(N32 n, ReadOnlySpan<char> src)
        {
            var dst = ByteBlock32.Empty;
            var count = min(n,src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref ByteBlock32 encode(ReadOnlySpan<char> src, out ByteBlock32 dst)
        {
            dst = default;
            var count = min(ByteBlock32.N, src.Length);
            encode(src, slice(dst.Bytes,0,count));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static int encode(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var count = min(src.Length, dst.Length);
            for(var i=0u; i<count; i++)
                seek(dst,i) = (byte)skip(src,i);
            return count;
        }
    }
}