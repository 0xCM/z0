//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static VServices;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Eq128<T> veq<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Eq256<T> veq<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lt128<T> vlt<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lt256<T> vlt<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Gt128<T> vgt<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Gt256<T> vgt<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Max128<T> vmax<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Max128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Max256<T> vmax<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Min128<T> vmin<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Min256<T> vmin<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NonZ128<T> vnonz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NonZ256<T> vnonz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestC128<T> vtestc<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestC256<T> vtestc<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestZ128<T> vtestz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TestZ256<T> vtestz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;
    }
}