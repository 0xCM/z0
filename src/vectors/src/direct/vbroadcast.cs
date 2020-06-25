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

    partial class Vectors
    {
        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vbroadcast(W128 w, sbyte src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vbroadcast(W128 w, short src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vbroadcast(W128 w, ushort src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vbroadcast(W128 w, int src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vbroadcast(W128 w, uint src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vbroadcast(W128 w, long src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vbroadcast(W128 w, ulong src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vbroadcast(W256 w, sbyte src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => V0.vbroadcast(w,src);
                        
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vbroadcast(W256 w, short src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vbroadcast(W256 w, ushort src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vbroadcast(W256 w, int src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vbroadcast(W256 w, uint src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vbroadcast(W256 w, long src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vbroadcast(W256 w, ulong src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<float> vbroadcast(W256 w, float src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<double> vbroadcast(W256 w, double src)
            => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<float> vbroadcast(W128 w, float src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> vbroadcast(W128 w, double src)
           => V0.vbroadcast(w,src);

        [MethodImpl(Inline)]
        public static Vector256<byte> vbroadcast(W256 w, byte lo, byte hi)
            => V0.vbroadcast(w,lo,hi);
 
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbroadcast(W256 w, ushort lo, ushort hi)
            => V0.vbroadcast(w,lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<uint> vbroadcast(W256 w, uint lo, uint hi)
            => V0.vbroadcast(w,lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vbroadcast(W256 w, ulong lo, ulong hi)
            => V0.vbroadcast(w,lo,hi);
    }
}