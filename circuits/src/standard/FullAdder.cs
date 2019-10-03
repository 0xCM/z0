//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public static class FullAdder
    {
        [MethodImpl(Inline)]
        public static void Compute(Bit x, Bit y, Bit cin, out Bit sum, out Bit cout)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            sum = a ^ cin;
            cout = b | c;
        }

        [MethodImpl(Inline)]
        public static OutPair<Bit> Compute(Bit x, Bit y, Bit cin)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            var sum = a ^ cin;
            var cout = b | c;
            return(sum, cout);
        }


        [MethodImpl(Inline)]
        public static void Compute<T>(in T x, in T y, in T cin, out T sum, out T cout)
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
            return cout.Concat(sum);

            // var a = x.Scalar ^ y.Scalar;
            // var b = a & cin.Scalar;
            // var c = x.Scalar & y.Scalar;
            // var sum = a ^ cin.Scalar;
            // var cout = b | c;
            // return BitVector64.FromScalars(sum,cout);
        }


        [MethodImpl(Inline)]
        public static void Compute<T>(in Vec256<T> x, in Vec256<T> y, in Vec256<T> cin, out Vec256<T> sum, out Vec256<T> cout)
            where T : unmanaged
        {
            var a = ginx.vxor(x,y);
            var b = ginx.vand(a,cin);
            var c = ginx.vand(x,y);
            sum = ginx.vxor(a, cin);
            cout = ginx.vor(b, c);
        }

        [MethodImpl(Inline)]
        public static OutPair<Vec256<T>> Compute<T>(in Vec256<T> x, in Vec256<T> y, in Vec256<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vec256<T> sum, out Vec256<T> cout);
            return(sum,cout);
        }

        [MethodImpl(Inline)]
        public static void Compute<T>(in Vec128<T> x, in Vec128<T> y, in Vec128<T> cin, out Vec128<T> sum, out Vec128<T> cout)
            where T : unmanaged
        {
            var a = ginx.vxor(x,y);
            var b = ginx.vand(a,cin);
            var c = ginx.vand(x,y);
            sum = ginx.vxor(a, cin);
            cout = ginx.vor(b, c);
        }

        [MethodImpl(Inline)]
        public static OutPair<Vec128<T>> Compute<T>(in Vec128<T> x, in Vec128<T> y, in Vec128<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vec128<T> sum, out Vec128<T> cout);
            return(sum,cout);
        }

    }

}