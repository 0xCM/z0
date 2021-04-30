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

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VConcat2x128<T> vconcat<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VConcat2x128<T>);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VHi128<T> vhi<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VHi128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VHi256<T> vhi<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VHi256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VLo128<T> vlo<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VLo128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VLo256<T> vlo<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VLo256<T>);
    }
}