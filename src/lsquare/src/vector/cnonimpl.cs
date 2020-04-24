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
    using static Memories;
    using static Vectors;
        
    partial class LSquare
    {     
        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static Vector128<T> vcnonimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static Vector256<T> vcnonimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static void cnonimpl<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcnonimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static void cnonimpl<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vcnonimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static void cnonimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), CNonImpl, Closures(UnsignedInts)]
        public static void cnonimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}