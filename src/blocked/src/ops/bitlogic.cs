//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static z;

    partial class Blocked
    {
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
    }
}