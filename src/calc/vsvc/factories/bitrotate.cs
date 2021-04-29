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
        public static Rotrx128<T> vrotrx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotrx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotrx256<T> vrotrx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotrx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotlx128<T> vrotlx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotlx256<T> vrotlx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotlx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotl128<T> vrotl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotl256<T> vrotl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotr128<T> vrotr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Rotr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Rotr256<T> vrotr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Rotr256<T>);
    }
}