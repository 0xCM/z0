//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static refs;        

    partial class math
    {
        [MethodImpl(Inline), Mul]
        public static sbyte mul(sbyte a, sbyte rhs)
            => (sbyte)(a * rhs);

        [MethodImpl(Inline), Mul]
        public static byte mul(byte a, byte b)
            => (byte)(a * b);

        [MethodImpl(Inline), Mul]
        public static short mul(short a, short b)
            => (short)(a * b);

        [MethodImpl(Inline), Mul]
        public static ushort mul(ushort a, ushort b)
            => (ushort)(a * b);

        [MethodImpl(Inline), Mul]
        public static int mul(int a, int b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static uint mul(uint a, uint b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static long mul(long a, long b)
            => a * b;

        [MethodImpl(Inline), Mul]
        public static ulong mul(ulong a, ulong b)
            => a * b;

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static unsafe void mul32x64(in Pair<uint> src, ref Pair<uint> dst)                 
            => dst.Right = Bmi2.MultiplyNoFlags(src.Left, src.Right, Root.ptr(ref dst.Left));

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static unsafe void mul64x128(in Pair<ulong> src, ref Pair<ulong> dst)                 
            => dst.Right = Bmi2.X64.MultiplyNoFlags(src.Left, src.Right, Root.ptr(ref dst.Left));

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static Pair<uint> mul32x64(in Pair<uint> src)
        {                         
            var dst = default(Pair<uint>);
            mul32x64(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> mul64x128(in Pair<ulong> src)
        {                         
            var dst = default(Pair<ulong>);
            mul64x128(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="z">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> mul64x128(in ulong a, in ulong b, ref Pair<ulong> z)
        {                         
            mul64x128((a,b), ref z);
            return ref z;
        }

        /// <summary>
        /// Computes the full 128-bit products between corresponding 64-bit span elements
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The right operands</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ReadOnlySpan<ulong> ys, Span<Pair<ulong>> zs)
        {
            var count = math.min(math.min(xs.Length, ys.Length), zs.Length);
            for(var i=0; i<count; i++)
                mul64x128(skip(in head(xs), i), skip(in head(ys), i), ref seek(ref head(zs), i));
        }

        /// <summary>
        /// Computes the full 128-bit products between 64-bit span elements and a 64-bit scalar
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The scalar value</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ulong a, Span<Pair<ulong>> zs)
        {
            var count = xs.Length;
            for(var i=0; i<count; i++)
                mul64x128(skip(in head(xs), i), a, ref seek(ref head(zs), i));
        }
    }
}