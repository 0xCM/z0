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
        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static Vector128<T> vxnor<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxnor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static Vector256<T> vxnor<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxnor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static void xnor<T>(W128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static void xnor<T>(W256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vxnor(n, in a, in b), ref z);

        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static void xnor<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), Xnor, Closures(UnsignedInts)]
        public static void xnor<T>(W256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xnor(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}