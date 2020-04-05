//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed;
    using static refs;
    using static Vectors;
    
    partial class LogicSquares
    {     
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vxornot<T>(N128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxornot(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vxornot<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxornot(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void xornot<T>(N128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vxornot(w, in a, in b), ref z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void xornot<T>(N256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vxornot(w, in a, in b), ref z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void xornot<T>(N128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xornot(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void xornot<T>(N256 w, int vcount, int blocklen,  in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xornot(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}