//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    using static vfunc;

    static class BlockedCases
    {

        [MethodImpl(Inline),  NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n128));

        [MethodImpl(Inline),  NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n256));

        [MethodImpl(Inline),  NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n128));

        [MethodImpl(Inline),  NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n256));

        [MethodImpl(Inline),  NumericClosures(NumericKind.All)]
        public static ref readonly Block128<T> vxor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n128));

        [MethodImpl(Inline),  NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vxor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n256));

    }

}
