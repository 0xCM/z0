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
        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static Vector128<T> vnonimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static Vector256<T> vnonimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vnonimpl(vload(w, in a),vload(w, in b));

        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static void nonimpl<T>(W128 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => vstore(vnonimpl(w, in a, in b), ref dst);

        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static void nonimpl<T>(W256 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => vstore(vnonimpl(w, in a, in b), ref dst);

        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static void nonimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(w, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }

        [MethodImpl(Inline), NonImpl, Closures(Closure)]
        public static void nonimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                nonimpl(LogicSquare.w, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }
    }
}