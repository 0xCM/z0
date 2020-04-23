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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vnot<T>(N128 n, in T a)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return gvec.vnot(vA);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vnot<T>(N256 n, in T a)
            where T : unmanaged
        {                    
            Vectors.vload(a, out Vector256<T> vA);
            return gvec.vnot(vA);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(N128 n, in T a, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnot(n, in a),ref z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(N128 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(N256 n, in T a, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnot(n, in a),ref z);
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(N256 n, int vcount, int blocklen, in T a, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                not(n, in skip(in a, offset), ref seek(ref z, offset));
        }
    }
}