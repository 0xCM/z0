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
        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static Vector128<T> vcimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static Vector256<T> vcimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(W128 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => z.vsave(vcimpl(w, in a, in b), ref dst);

        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(W256 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => z.vsave(vcimpl(w, in a, in b), ref dst);

        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }

        [MethodImpl(Inline), CImpl, Closures(Closure)]
        public static void cimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }
    }
}