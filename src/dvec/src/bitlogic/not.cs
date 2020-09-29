//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class dvec
    {
        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vnot(Vector128<sbyte> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vnot(Vector128<byte> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vnot(Vector128<short> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vnot(Vector128<ushort> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vnot(Vector128<int> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vnot(Vector128<uint> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vnot(Vector128<long> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vnot(Vector128<ulong> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vnot(Vector256<sbyte> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vnot(Vector256<byte> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vnot(Vector256<short> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vnot(Vector256<ushort> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vnot(Vector256<int> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vnot(Vector256<uint> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vnot(Vector256<long> x)
            => z.vnot(x);

        /// <summary>
        /// Computes the bitwise negation of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vnot(Vector256<ulong> x)
             => z.vnot(x);
   }
}