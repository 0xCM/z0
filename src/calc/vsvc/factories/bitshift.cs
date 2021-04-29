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
        public static VSll128<T> vsll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSll128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSll256<T> vsll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSll256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrl128<T> vsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSrl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrl256<T> vsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSrl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlx128<T> vsrlx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSrlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlx256<T> vsrlx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSrlx256<T>);

        [MethodImpl(Inline)]
        public static VSllx128<T> vsllx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSllx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSllx256<T> vsllx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSllx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSllr128<T> vsllr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSllr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSllr256<T> vsllr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSllr256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlr128<T> vsrlr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSrlr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlr256<T> vsrlr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSrlr256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VBsrl128<T> vbsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VBsrl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VBsrl256<T> vbsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VBsrl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VBsll128<T> vbsll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VBsll128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VBsll256<T> vbsll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VBsll256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlv128<T> vsrlv<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSrlv128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSrlv256<T> vsrlv<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSrlv256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSllv128<T> vsllv<T>(W128 w, T t = default)
            where T : unmanaged
                => default(VSllv128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static VSllv256<T> vsllv<T>(W256 w, T t = default)
            where T : unmanaged
                => default(VSllv256<T>);
    }
}