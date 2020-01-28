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
    using static vfunc;

    static class BlockedCases
    {

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vand<T>(n128));

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vand<T>(n256));

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vor<T>(n128));

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vor<T>(n256));

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.All)]
        public static ref readonly Block128<T> vxor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vxor<T>(n128));

        [MethodImpl(Inline), BlockedOp, PrimalClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vxor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vxor<T>(n256));

    }

}
