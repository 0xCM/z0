//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Konst;

    partial struct z
    {

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo)
            => Vector128.CreateScalarUnsafe(lo).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo, ulong hi)
            => Vector128.Create(lo,hi).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector256<byte> vbytes(W256 w, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vload(W128 w, in sbyte src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(W128 w, in byte src)
            => LoadDquVector128(gptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vload(W128 w, in short src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vload(W128 w, in ushort src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vload(W128 w, in int src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vload(W128 w, in uint src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vload(W128 w, in long src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vload(W128 w, in ulong src)
            => LoadDquVector128(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vload(W256 w, in sbyte src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(W256 w, in byte src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vload(W256 w, in short src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vload(W256 w, in ushort src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vload(W256 w, in int src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vload(W256 w, in uint src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vload(W256 w, in long src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vload(W256 w, in ulong src)
            => LoadDquVector256(gptr(src));            

        [MethodImpl(Inline)]
        public static unsafe Vector512<byte> vload(W512 w, in byte src)
            => (vload(n256, in src), vload(n256, add(src, 32)));

        [MethodImpl(Inline)]
        public static unsafe Vector512<ushort> vload(W512 w, in ushort src)
            => (vload(n256, in src), vload(n256, add(src, 16)));

    }
}