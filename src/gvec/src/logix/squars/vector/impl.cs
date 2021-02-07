//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class LogicSquare
    {
        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static Vector128<T> vimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vimpl(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static Vector256<T> vimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vimpl(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static void impl<T>(W128 n, in T a, in T b, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vimpl(n, in a, in b), ref dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static void impl<T>(W256 n, in T a, in T b, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vimpl(n, in a, in b), ref dst);

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static void impl<T>(W128 n, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                impl(n, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }

        [MethodImpl(Inline), Impl, Closures(Closure)]
        public static void impl<T>(W256 n, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                impl(n, in skip(in a, offset), in skip(in b, offset), ref seek(dst, offset));
        }
    }
}