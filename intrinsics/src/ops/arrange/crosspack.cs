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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static void vcrosspack(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> lo, out Vector128<byte> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        [MethodImpl(Inline)]
        public static void vcrosspack(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        /// <summary>
        /// ([x0 x1 x2 x3], [y0 y1 y2 63]) -> ([x0 x1 y0 y1], [x2 x3 y2 y3])
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void vcrosspack(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> lo, out Vector128<uint> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }


        /// <summary>
        /// ([x0 x1], [y0 y1]) -> ([x0 y0], [x1 y1])
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void vcrosspack(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> lo, out Vector128<ulong> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        [MethodImpl(Inline)]
        public static void vcrosspack(Vector256<byte> x, Vector256<byte> y, out Vector256<byte> lo, out Vector256<byte> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        [MethodImpl(Inline)]
        public static void vcrosspack(Vector256<ushort> x, Vector256<ushort> y, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        [MethodImpl(Inline)]
        public static void vcrosspack(Vector256<uint> x, Vector256<uint> y, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

        /// <summary>
        /// ([x0 x1 x2 x3], [y0 y1 y2 y3]) -> ([x0 x1 y0 y1], [x2 x3 y2 y3])
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static void vcrosspack(Vector256<ulong> x, Vector256<ulong> y, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = vmergelo(x,y);
            hi = vmergehi(x,y);
        }

    }

}