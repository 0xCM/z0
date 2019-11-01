//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    public static class FullAdder
    {
        [MethodImpl(Inline)]
        public static void Compute(bit x, bit y, bit cin, out bit sum, out bit cout)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            sum = a ^ cin;
            cout = b | c;
        }

        [MethodImpl(Inline)]
        public static OutPair<bit> Compute(bit x, bit y, bit cin)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            var sum = a ^ cin;
            var cout = b | c;
            return(sum, cout);
        }

        [MethodImpl(Inline)]
        public static void Compute<T>(T x, T y, T cin, out T sum, out T cout)
            where T : unmanaged
        {
            var a = gmath.xor(x, y);
            var b = gmath.and(a, cin);
            var c = gmath.and(x, y);
            sum = gmath.xor(a, cin);
            cout = gmath.or(b, c);
        }
        
        [MethodImpl(Inline)]
        public static BitVector64 Compute(BitVector32 x, BitVector32 y, BitVector32 cin)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            var sum = a ^ cin;
            var cout = b | c;
            return BitVector.concat(sum,cout);
        }

        [MethodImpl(Inline)]
        public static void Compute<T>(Vector256<T> x, Vector256<T> y, Vector256<T> cin, out Vector256<T> sum, out Vector256<T> cout)
            where T : unmanaged
        {
            var a = ginx.vxor(x,y);
            var b = ginx.vand(a,cin);
            var c = ginx.vand(x,y);
            sum = ginx.vxor(a, cin);
            cout = ginx.vor(b, c);
        }

        [MethodImpl(Inline)]
        public static OutPair<Vector256<T>> Compute<T>(Vector256<T> x, Vector256<T> y, Vector256<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vector256<T> sum, out Vector256<T> cout);
            return(sum,cout);
        }

        [MethodImpl(Inline)]
        public static void Compute<T>(Vector128<T> x, Vector128<T> y, Vector128<T> cin, out Vector128<T> sum, out Vector128<T> cout)
            where T : unmanaged
        {
            var a = ginx.vxor(x,y);
            var b = ginx.vand(a,cin);
            var c = ginx.vand(x,y);
            sum = ginx.vxor(a, cin);
            cout = ginx.vor(b, c);
        }

        [MethodImpl(Inline)]
        public static OutPair<Vector128<T>> Compute<T>(Vector128<T> x, Vector128<T> y, Vector128<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vector128<T> sum, out Vector128<T> cout);
            return(sum,cout);
        }

    }

}