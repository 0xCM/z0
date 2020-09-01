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
 
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(pointer(ref dst), src);            

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(pointer(ref dst), src);            

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<byte> src, ref byte dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 32));   
        }

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<ushort> src, ref ushort dst)
            => Store(pointer(ref dst), src);            

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<ushort> src, ref ushort dst)
            => Store(pointer(ref dst), src);            

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<ushort> src, ref ushort dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 16));   
        }

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));
    }
}