//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotrx128<T> vrotrx<T>(W128 w)
            where T : unmanaged
                => default(VRotrx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotrx256<T> vrotrx<T>(W256 w)
            where T : unmanaged
                => default(VRotrx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx128<T> vrotlx<T>(W128 w)
            where T : unmanaged
                => default(VRotlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotlx256<T> vrotlx<T>(W256 w)
            where T : unmanaged
                => default(VRotlx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotl128<T> vrotl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VRotl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotl256<T> vrotl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VRotl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotr128<T> vrotr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VRotr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VRotr256<T> vrotr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VRotr256<T>);
    }
}