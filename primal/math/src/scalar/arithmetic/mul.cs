//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static As;
    
    using static zfunc;        

    partial class math
    {
       [MethodImpl(Inline)]
        public static sbyte mul(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs * rhs);

        [MethodImpl(Inline)]
        public static byte mul(byte lhs, byte rhs)
            => (byte)(lhs * rhs);

        [MethodImpl(Inline)]
        public static short mul(short lhs, short rhs)
            => (short)(lhs * rhs);

        [MethodImpl(Inline)]
        public static ushort mul(ushort lhs, ushort rhs)
            => (ushort)(lhs * rhs);

        [MethodImpl(Inline)]
        public static int mul(int lhs, int rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static uint mul(uint lhs, uint rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static long mul(long lhs, long rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static ulong mul(ulong lhs, ulong rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public static ref sbyte mul(ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte mul(ref byte lhs, byte rhs)
        {
            lhs = (byte)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short mul(ref short lhs, short rhs)
        {
            lhs = (short)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort mul(ref ushort lhs, ushort rhs)
        {
            lhs = (ushort)(lhs * rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int mul(ref int lhs, int rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint mul(ref uint lhs, uint rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long mul(ref long lhs, long rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong mul(ref ulong lhs, ulong rhs)
        {
            lhs = lhs * rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static unsafe void mul(in Pair<uint> src, ref Pair<uint> dst)                 
            => dst.B = Bmi2.MultiplyNoFlags(src.A, src.B, refptr(ref dst.A));

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static unsafe void mul(in Pair<ulong> src, ref Pair<ulong> dst)                 
            => dst.B = Bmi2.X64.MultiplyNoFlags(src.A, src.B, refptr(ref dst.A));

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static Pair<uint> mul(in Pair<uint> src)
        {                         
            var dst = default(Pair<uint>);
            mul(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static Pair<ulong> mul(in Pair<ulong> src)
        {                         
            var dst = default(Pair<ulong>);
            mul(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> mul(in ulong a, in ulong b, ref Pair<ulong> dst)
        {                         
            mul(pair(a,b), ref dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static void mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<Pair<ulong>> dst)
        {
            var count = math.min(math.min(lhs.Length, rhs.Length), dst.Length);
            for(var i=0; i<count; i++)
                mul(skip(in head(lhs), i), skip(in head(rhs), i), ref seek(ref head(dst), i));
        }

        [MethodImpl(Inline)]
        public static void mul(ReadOnlySpan<ulong> lhs, ulong rhs, Span<Pair<ulong>> dst)
        {
            var count = lhs.Length;
            for(var i=0; i<count; i++)
                mul(skip(in head(lhs), i), rhs, ref seek(ref head(dst), i));
        }

    }
}