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
        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VGt128<T> vgt<T>(W128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VGt256<T> vgt<T>(W256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VMax128<T> vmax<T>(W128 w)
            where T : unmanaged
                => default(VMax128<T>);

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VMax256<T> vmax<T>(W256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VMin128<T> vmin<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VMin256<T> vmin<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VNonZ128<T> vnonz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VNonZ256<T> vnonz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VTestC128<T> vtestc<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VTestC256<T> vtestc<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VTestZ128<T> vtestz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory, Closures(Closure)]
        public static VTestZ256<T> vtestz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

    }

    partial class VSvc
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VMin128<T> vmin<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VMin256<T> vmin<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNonZ128<T> vnonz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VNonZ256<T> vnonz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VTestC128<T> vtestc<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VTestC256<T> vtestc<T>(W256 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VTestZ128<T> vtestz<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VTestZ256<T> vtestz<T>(W256 w, T t = default)
            where T : unmanaged
                => default;
    }
}