//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public class FullAdder
    {
        [MethodImpl(Inline), Op]
        public static void Compute(Bit32 x, Bit32 y, Bit32 cin, out Bit32 sum, out Bit32 cout)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            sum = a ^ cin;
            cout = b | c;
        }

        [MethodImpl(Inline), Op]
        public static OutPair<Bit32> Compute(Bit32 x, Bit32 y, Bit32 cin)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            var sum = a ^ cin;
            var cout = b | c;
            return(sum, cout);
        }

        [MethodImpl(Inline), Op]
        public static BitVector64 Compute(BitVector32 x, BitVector32 y, BitVector32 cin)
        {
            var a = x ^ y;
            var b = a & cin;
            var c = x & y;
            var sum = a ^ cin;
            var cout = b | c;
            return BitVector.concat(sum,cout);
        }

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static void Compute<T>(T x, T y, T cin, out T sum, out T cout)
            where T : unmanaged
        {
            var a = gmath.xor(x, y);
            var b = gmath.and(a, cin);
            var c = gmath.and(x, y);
            sum = gmath.xor(a, cin);
            cout = gmath.or(b, c);
        }

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static void Compute<T>(Vector256<T> x, Vector256<T> y, Vector256<T> cin, out Vector256<T> sum, out Vector256<T> cout)
            where T : unmanaged
        {
            var a = gvec.vxor(x,y);
            var b = gvec.vand(a,cin);
            var c = gvec.vand(x,y);
            sum = gvec.vxor(a, cin);
            cout = gvec.vor(b, c);
        }

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static OutPair<Vector256<T>> Compute<T>(Vector256<T> x, Vector256<T> y, Vector256<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vector256<T> sum, out Vector256<T> cout);
            return(sum,cout);
        }

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static void Compute<T>(Vector128<T> x, Vector128<T> y, Vector128<T> cin, out Vector128<T> sum, out Vector128<T> cout)
            where T : unmanaged
        {
            var a = gvec.vxor(x,y);
            var b = gvec.vand(a,cin);
            var c = gvec.vand(x,y);
            sum = gvec.vxor(a, cin);
            cout = gvec.vor(b, c);
        }

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static OutPair<Vector128<T>> Compute<T>(Vector128<T> x, Vector128<T> y, Vector128<T> cin)
            where T : unmanaged
        {
            Compute(x,y,cin, out Vector128<T> sum, out Vector128<T> cout);
            return(sum,cout);
        }
    }
}