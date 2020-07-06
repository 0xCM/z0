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
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static Root;
    using static Typed;

    public partial class SymBits
    {        
        [MethodImpl(Inline)]
        public static ref Vector256<ushort> v16u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref edit(in src));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmove8x16(in byte src)
            => ConvertToVector256Int16(constptr(src)).AsUInt16();

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo)
            => Vector128.CreateScalarUnsafe(lo).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo, ulong hi)
            => Vector128.Create(lo,hi).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector256<byte> vbytes(W256 w, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3).As<ulong,byte>();


        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector512<byte> src, ref byte dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 32));   
        }

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector128<ushort> src, ref ushort dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector256<ushort> src, ref ushort dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector512<ushort> src, ref ushort dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 16));   
        }

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector128<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector256<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector512<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

 
        [MethodImpl(Inline)]
        public static ulong vlo(Vector128<byte> src)
            => src.AsUInt64().GetElement(0);

        [MethodImpl(Inline)]
        public static ulong vlo(Vector128<ushort> src)
            => src.AsUInt64().GetElement(0);

        [MethodImpl(Inline)]
        public static ulong vhi(Vector128<byte> src)
            => src.AsUInt64().GetElement(1);

        [MethodImpl(Inline)]
        public static ulong vhi(Vector128<ushort> src)
            => src.AsUInt64().GetElement(1);

        [MethodImpl(Inline)]
        public static Vector128<byte> vlo(Vector256<byte> src)
            => Vector256.GetLower(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vlo(Vector256<ushort> src)
            => Vector256.GetLower(src);

        [MethodImpl(Inline)]
        public static Vector128<byte> vhi(Vector256<byte> src)
            => Vector256.GetUpper(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vhi(Vector256<ushort> src)
            => Vector256.GetUpper(src);

        [MethodImpl(Inline)]
        public static Vector256<byte> vlo(Vector512<byte> src)
            => src.Lo;

        [MethodImpl(Inline)]
        public static Vector256<byte> vhi(Vector512<byte> src)
            => src.Hi;
    }
}