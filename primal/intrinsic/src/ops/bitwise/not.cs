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
 
        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vxor1(Vector128<sbyte> x)
            => Xor(x, CompareEqual(default(Vector128<sbyte>), default(Vector128<sbyte>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vxor1(Vector128<byte> x)
            => Xor(x, CompareEqual(default(Vector128<byte>), default(Vector128<byte>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vxor1(Vector128<short> x)
            => Xor(x, CompareEqual(default(Vector128<short>), default(Vector128<short>)));
 
        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxor1(Vector128<ushort> x)
            => Xor(x, CompareEqual(default(Vector128<ushort>), default(Vector128<ushort>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vxor1(Vector128<int> x)
            => Xor(x, CompareEqual(default(Vector128<int>), default(Vector128<int>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxor1(Vector128<uint> x)
            => Xor(x, CompareEqual(default(Vector128<uint>), default(Vector128<uint>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vxor1(Vector128<long> x)
            => Xor(x, CompareEqual(default(Vector128<long>), default(Vector128<long>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxor1(Vector128<ulong> x)
            => Xor(x, CompareEqual(default(Vector128<ulong>), default(Vector128<ulong>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vxor1(Vector256<sbyte> x)
            => Xor(x, CompareEqual(default(Vector256<sbyte>), default(Vector256<sbyte>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vxor1(Vector256<byte> x)
            => Xor(x, CompareEqual(default(Vector256<byte>), default(Vector256<byte>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vxor1(Vector256<short> x)
            => Xor(x, CompareEqual(default(Vector256<short>), default(Vector256<short>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxor1(Vector256<ushort> x)
            => Xor(x, CompareEqual(default(Vector256<ushort>), default(Vector256<ushort>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vxor1(Vector256<int> x)
            => Xor(x, CompareEqual(default(Vector256<int>), default(Vector256<int>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxor1(Vector256<uint> x)
            => Xor(x, CompareEqual(default(Vector256<uint>), default(Vector256<uint>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vxor1(Vector256<long> x)
            => Xor(x, CompareEqual(default(Vector256<long>), default(Vector256<long>)));

        /// <summary>
        /// Computes the bitwise negation of the source vector using alternate approach, logically equivalent to vnot
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxor1(Vector256<ulong> x)
            => Xor(x, CompareEqual(default(Vector256<ulong>), default(Vector256<ulong>)));
 
    }

}