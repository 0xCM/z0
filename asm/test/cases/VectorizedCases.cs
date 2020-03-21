//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Root;

    static class VectorizedCases
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vhi<T>(Vector128<T> x)
            where T : unmanaged
                => gvec.vhi(x);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vlo<T>(Vector128<T> x)
            where T : unmanaged
                => gvec.vlo(x);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => gvec.vadd(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => gvec.vadd(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => gvec.vand(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => gvec.vand(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => gvec.vxor(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => gvec.vxor(x,y);
    }
}