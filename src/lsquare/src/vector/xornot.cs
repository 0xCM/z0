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
    using static z;

    partial class LogicSquare
    {
        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static Vector128<T> vxornot<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxornot(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static Vector256<T> vxornot<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxornot(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static void xornot<T>(W128 w, in T a, in T b, ref T c)
            where T : unmanaged
                => vsave(vxornot(w, in a, in b), ref c);

        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static void xornot<T>(W256 w, in T a, in T b, ref T c)
            where T : unmanaged
                => vsave(vxornot(w, in a, in b), ref c);

        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static void xornot<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T c)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xornot(w, in skip(in a, offset), in skip(in b, offset), ref seek(c, offset));
        }

        [MethodImpl(Inline), XorNot, Closures(UnsignedInts)]
        public static void xornot<T>(W256 w, int vcount, int blocklen,  in T a, in T b, ref T c)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xornot(w, in skip(in a, offset), in skip(in b, offset), ref seek(c, offset));
        }
    }
}