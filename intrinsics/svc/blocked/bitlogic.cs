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
        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vxor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vxor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vnot<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vnot<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnot<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vnot<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vnand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnand<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnand<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vnor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnor<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vxnor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxnor<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vxnor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxnor<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vxornot<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxornot<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vxornot<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxornot<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vselect<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a,b,c,dst, VSvcFactories.vselect<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vselect<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a,b,c,dst, VSvcFactories.vselect<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vimpl<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vimpl<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vnonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnonimpl<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnonimpl<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vcimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcimpl<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vcimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcimpl<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vcnonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcnonimpl<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vcnonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcnonimpl<T>(n256));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vbsll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsll<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vbsll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsll<T>(n256));


        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> vbsrl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsrl<T>(n128));

        [MethodImpl(Inline), BlockedOp, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vbrll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsrl<T>(n256));

    }

}