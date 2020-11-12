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
        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static Vector128<T> vxor<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static Vector256<T> vxor<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vxor(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static void xor<T>(W128 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(vxor(n, in a, in b), ref z);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static void xor<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xor(n, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static void xor<T>(W256 n, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(vxor(n, in a, in b), ref z);

        [MethodImpl(Inline), Xor, Closures(Closure)]
        public static void xor<T>(W256 n, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                xor(n, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }
    }
}