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
        public static Sll128<T> vsll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sll128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sll256<T> vsll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sll256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srl128<T> vsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Srl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srl256<T> vsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Srl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlx128<T> vsrlx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Srlx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlx256<T> vsrlx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Srlx256<T>);

        [MethodImpl(Inline)]
        public static Sllx128<T> vsllx<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sllx128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sllx256<T> vsllx<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sllx256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sllr128<T> vsllr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sllr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sllr256<T> vsllr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sllr256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlr128<T> vsrlr<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Srlr128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlr256<T> vsrlr<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Srlr256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bsrl128<T> vbsrl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Bsrl128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bsrl256<T> vbsrl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Bsrl256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bsll128<T> vbsll<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Bsll128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bsll256<T> vbsll<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Bsll256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlv128<T> vsrlv<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Srlv128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Srlv256<T> vsrlv<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Srlv256<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sllv128<T> vsllv<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Sllv128<T>);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Sllv256<T> vsllv<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Sllv256<T>);
    }
}