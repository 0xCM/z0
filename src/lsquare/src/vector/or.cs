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
    using static Memories;
    using static Vectors;
    
    partial class LogicSquare
    {     
        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static Vector128<T> vor<T>(W128 w, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector128<T> vA);
            vload(in b, out Vector128<T> vB);
            return gvec.vor(vA,vB);
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static Vector256<T> vor<T>(W256 w, in T a, in T b)
            where T : unmanaged
        {                    
            vload(in a, out Vector256<T> vA);
            vload(in b, out Vector256<T> vB);
            return gvec.vor(vA,vB);
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vor(w, in a, in b), ref z);

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vor(w, in a, in b), ref z);

        [MethodImpl(Inline), Or, Closures(UnsignedInts)]
        public static void or<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                or(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}