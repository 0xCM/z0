//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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

    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vadd<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vadd<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vadd<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vadd<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vsub<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vsub<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vsub<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vsub<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vmax<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vmax<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vmax<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vmax<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vmin<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vmin<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vmin<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vmin<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vand<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vand<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vand<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vand<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vnand<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vnand<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vnand<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vnand<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vor<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vor<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vor<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vor<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vxor<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxor<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vxor<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxor<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vxornot<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxornot<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vxornot<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxornot<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vnor<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vnor<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vnor<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vand<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vxnor<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxnor<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vxnor<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vxnor<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vselect<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(xb,yb,zb,dst, VOps.vselect<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vselect<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(xb,yb,zb,dst, VOps.vselect<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vsrl<T>(in Block128<T> xb, byte offset, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,offset,zb,VOps.vsrl<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vsrl<T>(in Block256<T> xb, byte offset, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,offset,zb,VOps.vsrl<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vsll<T>(in Block128<T> xb, byte offset, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,offset,zb,VOps.vsll<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vsll<T>(in Block256<T> xb, byte offset, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,offset,zb,VOps.vsll<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vnot<T>(in Block128<T> xb, in Block128<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vnot<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vnot<T>(in Block256<T> xb, in Block256<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vnot<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> veq<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.veq<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> veq<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.veq<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vlt<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vlt<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vlt<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vlt<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vgt<T>(in Block128<T> xb, in Block128<T> yb, in Block128<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vgt<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vgt<T>(in Block256<T> xb, in Block256<T> yb, in Block256<T> zb)
            where T : unmanaged
                => ref vzip(xb,yb,zb,VOps.vgt<T>(n256));

        [MethodImpl(Inline)]
        public static bit vnonz<T>(in Block128<T> xb)
            where T : unmanaged
                => vall(xb,VOps.vnonz<T>(n128));

        [MethodImpl(Inline)]
        public static bit vnonz<T>(in Block256<T> xb)
            where T : unmanaged
                => vall(xb,VOps.vnonz<T>(n256));

        [MethodImpl(Inline)]
        public static bit vtestc<T>(in Block128<T> xb, in Block128<T> yb)
            where T : unmanaged
                => vall(xb,yb,VOps.vtestc<T>(n128));

        [MethodImpl(Inline)]
        public static bit vtestc<T>(in Block256<T> xb, in Block256<T> yb)
            where T : unmanaged
                => vall(xb,yb,VOps.vtestc<T>(n256));

        [MethodImpl(Inline)]
        public static bit vtestz<T>(in Block128<T> xb, in Block128<T> yb)
            where T : unmanaged
                => vall(xb,yb,VOps.vtestz<T>(n128));

        [MethodImpl(Inline)]
        public static bit vtestz<T>(in Block256<T> xb, in Block256<T> yb)
            where T : unmanaged
                => vall(xb,yb,VOps.vtestc<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vdec<T>(in Block128<T> xb, in Block128<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vdec<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vdec<T>(in Block256<T> xb, in Block256<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vdec<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vinc<T>(in Block128<T> xb, in Block128<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vinc<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vinc<T>(in Block256<T> xb, in Block256<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vinc<T>(n256));

        [MethodImpl(Inline)]
        public static ref readonly Block128<T> vnegate<T>(in Block128<T> xb, in Block128<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb,VOps.vnegate<T>(n128));

        [MethodImpl(Inline)]
        public static ref readonly Block256<T> vnegate<T>(in Block256<T> xb, in Block256<T> zb)
            where T : unmanaged
                => ref vmap(xb, zb, VOps.vnegate<T>(n256));

    }
}