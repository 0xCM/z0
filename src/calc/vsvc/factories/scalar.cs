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
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VPop128<T> vpop<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VPop128<T>);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VPop256<T> vpop<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VPop256<T>);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VTakeMask128<T> vtakemask<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VTakeMask128<T>);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VTakeMask256<T> vtakemask<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VTakeMask256<T>);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VTakeIMask128<T> vtakeimask<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VTakeIMask128<T>);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static VTakeIMask256<T> vtakeimask<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VTakeIMask256<T>);

    }
}