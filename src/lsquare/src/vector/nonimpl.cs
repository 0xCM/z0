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
        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static Vector128<T> vnonimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static Vector256<T> vnotimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => VStore.vsave(vnonimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vstore(vnotimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(LogicSquare.w, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}