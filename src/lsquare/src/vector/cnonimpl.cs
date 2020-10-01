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
        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static Vector128<T> vcnonimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static Vector256<T> vcnonimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vcnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W128 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(vcnonimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W256 w, in T a, in T b, ref T z)
            where T : unmanaged
                => vsave(vcnonimpl(w, in a, in b), ref z);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T z)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(z, offset));
        }
    }
}