//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using static zfunc;

    static class VectorizedCases
    {
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector128<T> vhi<T>(Vector128<T> x)
            where T : unmanaged
                => ginx.vhi(x);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector128<T> vlo<T>(Vector128<T> x)
            where T : unmanaged
                => ginx.vlo(x);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vadd(x,y);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vadd(x,y);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vand(x,y);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vand(x,y);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => ginx.vxor(x,y);

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => ginx.vxor(x,y);

    }


}