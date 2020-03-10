//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;
    using static Nats;
    using static vfunc;

    partial class gblocks
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> add<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vadd<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> add<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vadd<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vsub<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vsub<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vsub<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vsub<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.SignedInts)]
        public static ref readonly Block128<T> vabs<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vabs<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.SignedInts)]
        public static ref readonly Block256<T> vabs<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c, VSvcFactories.vabs<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vdec<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vdec<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vdec<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vdec<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vinc<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vinc<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vinc<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vinc<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vnegate<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vnegate<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnegate<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c, VSvcFactories.vnegate<T>(n256));
    }
}