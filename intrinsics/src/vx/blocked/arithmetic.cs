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
    
    using static zfunc;
    using static vfunc;

    partial class vblocks
    {

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vadd<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vadd<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vadd<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vadd<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vsub<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vsub<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vsub<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VX.vsub<T>(n256));


        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vabs<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vabs<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vabs<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vabs<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vdec<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vdec<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static ref readonly Block256<T> vdec<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vdec<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static ref readonly Block128<T> vinc<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vinc<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vinc<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vinc<T>(n256));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block128<T> vnegate<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VX.vnegate<T>(n128));

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static ref readonly Block256<T> vnegate<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c, VX.vnegate<T>(n256));

    }

}