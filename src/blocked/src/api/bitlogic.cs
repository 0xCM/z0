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

    partial class Blocked
    {
        [MethodImpl(Inline), Not, Closures(Integers)]
        public static ref readonly Block128<T> not<T>(in Block128<T> a, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w128).Invoke(a, dst);

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static ref readonly Block256<T> not<T>(in Block256<T> a, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.not<T>(w256).Invoke(a, dst);

        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly Block128<T> and<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), And, Closures(Integers)]
        public static ref readonly Block256<T> and<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.and<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static ref readonly Block128<T> nand<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static ref readonly Block256<T> nand<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.nand<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static ref readonly Block128<T> or<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.or<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static ref readonly Block256<T> or<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.or<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static ref readonly Block128<T> nor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.nor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static ref readonly Block256<T> nor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.nor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static ref readonly Block128<T> xor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.xor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static ref readonly Block256<T> xor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.xor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static ref readonly Block128<T> xnor<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.xnor<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static ref readonly Block256<T> xnor<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.xnor<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> xornot<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.xornot<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> xornot<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.xornot<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static ref readonly Block128<T> impl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.impl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static ref readonly Block256<T> impl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.impl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> nonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.nonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> nonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.nonimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> cimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.cimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> cimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.cimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> cnonimpl<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.cnonimpl<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> cnonimpl<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.cnonimpl<T>(w256).Invoke(a, b, dst);

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly Block128<T> select<T>(in Block128<T> a, in Block128<T> b, in Block128<T> c, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w128).Invoke(a, b, c, dst);

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static ref readonly Block256<T> select<T>(in Block256<T> a, in Block256<T> b, in Block256<T> c, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.select<T>(w256).Invoke(a, b, c, dst);
    }
}