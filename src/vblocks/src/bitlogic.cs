//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed; 
    using static Memories;
    using static SBlock;

    partial class VBlocks
    {
        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly Block128<T> and<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vand<T>(n128));

        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly Block256<T> and<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vand<T>(n256));

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static ref readonly Block128<T> or<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vor<T>(n128));

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static ref readonly Block256<T> or<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vor<T>(n256));

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static ref readonly Block128<T> xor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxor<T>(n128));

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static ref readonly Block256<T> xor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxor<T>(n256));

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static ref readonly Block128<T> not<T>(in Block128<T> a, in Block128<T> c)
            where T : unmanaged
                => ref map(a, c,VSvc.vnot<T>(n128));

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static ref readonly Block256<T> vnot<T>(in Block256<T> a, in Block256<T> c)
            where T : unmanaged
                => ref map(a, c,VSvc.vnot<T>(n256));

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static ref readonly Block128<T> nand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vnand<T>(n128));

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static ref readonly Block256<T> nand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vnand<T>(n256));

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static ref readonly Block128<T> nor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vnor<T>(n128));

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static ref readonly Block256<T> nor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vand<T>(n256));

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static ref readonly Block128<T> xnor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxnor<T>(n128));

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static ref readonly Block256<T> xnor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxnor<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> xornot<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxornot<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> xornot<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vxornot<T>(n256));

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly Block128<T> select<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst)
            where T : unmanaged
                => ref zip(a,b,c,dst, VSvc.vselect<T>(n128));

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly Block256<T> vselect<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst)
            where T : unmanaged
                => ref zip(a,b,c,dst, VSvc.vselect<T>(n256));

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static ref readonly Block128<T> impl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vimpl<T>(n128));

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static ref readonly Block256<T> impl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vimpl<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> nonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vnonimpl<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> nonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vnonimpl<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> cimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vcimpl<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> cimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vcimpl<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> cnonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vcnonimpl<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> cnonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c)
            where T : unmanaged
                => ref zip(a,b,c,VSvc.vcnonimpl<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsll<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsll<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> bsll<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsll<T>(n256));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> bsrl<T>(in Block128<T> a, [Imm] byte count, in Block128<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n128));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> brsl<T>(in Block256<T> a, [Imm] byte count, in Block256<T> dst)
            where T : unmanaged
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n256));
    }
}