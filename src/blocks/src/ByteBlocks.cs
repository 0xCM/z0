//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Root;
    using static core;
    using static vcore;

    [ApiHost]
    public static partial class ByteBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock4 src)
        {
            var storage = 0ul;
            var input = u32(src);
            ref var dst = ref @as<ulong,char>(storage);
            seek(dst, 0) = (char)(byte)(input >> 0);
            seek(dst, 1) = (char)(byte)(input >> 8);
            seek(dst, 2) = (char)(byte)(input >> 16);
            seek(dst, 3) = (char)(byte)(input >> 24);
            return core.cover(dst, 4);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock8 src)
            => recover<char>(core.bytes(vlo(vinflate256x16u(vbytes(w128, u64(src))))));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock16 src)
            => recover<char>(core.bytes(vlo(vinflate256x16u(vbytes(w128, u64(src))))));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> decode(in ByteBlock32 src)
        {
            var v = vcore.vload(w256, src.Bytes);
            var lo = vinflatelo256x16u(v);
            var hi = vinflatehi256x16u(v);
            return recover<char>(core.bytes(new V256x2(lo,hi)));
        }

        [MethodImpl(Inline)]
        internal static unsafe Vector128<byte> vload(W128 w, in byte src)
            => LoadDquVector128(gptr(src));

        [MethodImpl(Inline)]
        internal static unsafe Vector256<byte> vload(W256 w, in byte src)
            => LoadDquVector256(gptr(src));

        [MethodImpl(Inline)]
        internal static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);

        [MethodImpl(Inline)]
        internal static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(refptr(ref dst), src);

        [MethodImpl(Inline)]
        internal static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        internal static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);
    }
}