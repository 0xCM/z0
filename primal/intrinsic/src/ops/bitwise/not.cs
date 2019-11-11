//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse41;

    
    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vnot(Vector128<sbyte> x)
            => Xor(x, CompareEqual(x, x));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vnot(Vector128<byte> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vnot(Vector128<short> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vnot(Vector128<ushort> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vnot(Vector128<int> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vnot(Vector128<uint> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vnot(Vector128<long> src)
            => vnot(src.AsUInt32()).AsInt64();

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vnot(Vector128<ulong> src)
            => vnot(src.AsUInt32()).AsUInt64();

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vnot(Vector256<sbyte> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vnot(Vector256<byte> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vnot(Vector256<short> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vnot(Vector256<ushort> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vnot(Vector256<int> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vnot(Vector256<uint> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vnot(Vector256<long> src)
            => Xor(src, CompareEqual(src, src));

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vnot(Vector256<ulong> src)
            => Xor(src, CompareEqual(src, src));
 
    }

}