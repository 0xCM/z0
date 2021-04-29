//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Concat2x128<T> vconcat<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Concat2x128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Broadcast128<T> vbroadcast<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Broadcast128<T>);

        [MethodImpl(Inline)]
        public static Broadcast128<S,T> vbroadcast<S,T>(W128 w, S s = default, T t = default)
            where T : unmanaged
            where S : unmanaged
                => default(Broadcast128<S,T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Broadcast256<T> vbroadcast<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Broadcast256<T>);

        [MethodImpl(Inline)]
        public static Broadcast256<S,T> vbroadcast<S,T>(W256 w, S s = default, T t = default)
            where T : unmanaged
            where S : unmanaged
                => default(Broadcast256<S,T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSwap128<T> vbyteswap<T>(W128 w, T t = default)
            where T : unmanaged
                => default(ByteSwap128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSwap256<T> vbyteswap<T>(W256 w, T t = default)
            where T : unmanaged
                => default(ByteSwap256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Hi128<T> vhi<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Hi128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Hi256<T> vhi<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Hi256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lo128<T> vlo<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Lo128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lo256<T> vlo<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Lo256<T>);
    }
}