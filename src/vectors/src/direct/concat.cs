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
        public static Vector256<byte> vconcat(Vector128<byte> lo, Vector128<byte> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vconcat(Vector128<sbyte> lo, Vector128<sbyte> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<short> vconcat(Vector128<short> lo, Vector128<short> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<ushort> vconcat(Vector128<ushort> lo, Vector128<ushort> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<int> vconcat(Vector128<int> lo, Vector128<int> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<uint> vconcat(Vector128<uint> lo, Vector128<uint> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<long> vconcat(Vector128<long> lo, Vector128<long> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<ulong> vconcat(Vector128<ulong> lo, Vector128<ulong> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<float> vconcat(Vector128<float> lo, Vector128<float> hi)        
            => V0.vconcat(lo,hi);

        [MethodImpl(Inline)]
        public static Vector256<double> vconcat(Vector128<double> lo, Vector128<double> hi)        
             => V0.vconcat(lo,hi);
   }
}