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
        [MethodImpl(Inline), And, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> and<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n128));

        [MethodImpl(Inline), And, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> and<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n256));

        [MethodImpl(Inline), Or, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> or<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n128));

        [MethodImpl(Inline), Or, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> or<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vor<T>(n256));

        [MethodImpl(Inline), Xor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> xor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n128));

        [MethodImpl(Inline), Xor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> xor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxor<T>(n256));

        [MethodImpl(Inline), Not, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> not<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vnot<T>(n128));

        [MethodImpl(Inline), Not, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vnot<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref vmap(a, c,VSvcFactories.vnot<T>(n256));

        [MethodImpl(Inline), Nand, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> nand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnand<T>(n128));

        [MethodImpl(Inline), Nand, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> nand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnand<T>(n256));

        [MethodImpl(Inline), Nor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> nor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnor<T>(n128));

        [MethodImpl(Inline), Nor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> nor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vand<T>(n256));

        [MethodImpl(Inline), Xnor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> xnor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxnor<T>(n128));

        [MethodImpl(Inline), Xnor, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> xnor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxnor<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> xornot<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxornot<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> xornot<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vxornot<T>(n256));

        [MethodImpl(Inline), Select, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> select<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a,b,c,dst, VSvcFactories.vselect<T>(n128));

        [MethodImpl(Inline), Select, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> vselect<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a,b,c,dst, VSvcFactories.vselect<T>(n256));

        [MethodImpl(Inline), Impl, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> impl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vimpl<T>(n128));

        [MethodImpl(Inline), Impl, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> impl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vimpl<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> nonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnonimpl<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> nonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vnonimpl<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> cimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcimpl<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> cimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcimpl<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> cnonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcnonimpl<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> cnonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref vzip(a,b,c,VSvcFactories.vcnonimpl<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> bsll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsll<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> bsll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsll<T>(n256));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block128<T> bsrl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsrl<T>(n128));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ref readonly Block256<T> brsl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref vzip(a, count, dst, VSvcFactories.vbsrl<T>(n256));
    }
}