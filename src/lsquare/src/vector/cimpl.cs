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
        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static Vector128<T> vcimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static Vector256<T> vcimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static void cimpl<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static void cimpl<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static void cimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), CImpl, Closures(UnsignedInts)]
        public static void cimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}