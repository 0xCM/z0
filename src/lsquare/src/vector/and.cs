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
    using static Root;
    using static V0;
    
    partial class LogicSquare
    {     
        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static Vector128<T> and<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vand(vload(w, in a), vload(w, in b));

        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static void and<T>(W128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(and(n, in a, in b), ref z);

        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static void and<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static Vector256<T> and<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vand(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static void and<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(and(w, in a, in b), ref z);

        [MethodImpl(Inline), And, Closures(UnsignedInts)]
        public static void and<T>(W256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                and(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }        
   }
}