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
        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static Vector128<T> vnonimpl<T>(N128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static Vector256<T> vnotimpl<T>(N256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(N128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnonimpl(n, in a, in b), ref z);

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(N256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => Vectors.vstore(vnotimpl(n, in a, in b), ref z);

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(N128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }

        [MethodImpl(Inline), NonImpl, Closures(UnsignedInts)]
        public static void nonimpl<T>(N256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(n, in skip(in a, offset), in skip(in b, offset), ref seek(ref z, offset));
        }
    }
}