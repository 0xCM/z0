//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;

    static class VectorizedCases
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vand<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vand(a,b);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vor(a,b);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vxor<T>(Vector256<T> a, Vector256<T> b)
            where T : unmanaged
                => gvec.vxor(a,b);
    }
}