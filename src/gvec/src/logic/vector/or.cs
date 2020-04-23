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
    
    partial class LSquares
    {     
        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static Vector128<T> vor<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return gvec.vor(vA,vB);
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static Vector256<T> vor<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return gvec.vor(vA,vB);
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vor(n, in a, in b), ref z);

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(N128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vor(n, in a, in b), ref z);

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}