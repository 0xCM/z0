//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static Sll128<T> vsll<T>(N128 w, T t = default)
            where T : unmanaged
                => Sll128<T>.Op;

        [MethodImpl(Inline)]
        public static Sll256<T> vsll<T>(N256 w, T t = default)
            where T : unmanaged
                => Sll256<T>.Op;

        [MethodImpl(Inline)]
        public static Srl128<T> vsrl<T>(N128 w, T t = default)
            where T : unmanaged
                => Srl128<T>.Op;

        [MethodImpl(Inline)]
        public static Srl256<T> vsrl<T>(N256 w, T t = default)
            where T : unmanaged
                => Srl256<T>.Op;

        [MethodImpl(Inline)]
        public static Srlx128<T> vsrlx<T>(N128 w, T t = default)
            where T : unmanaged
                => Srlx128<T>.Op;

        [MethodImpl(Inline)]
        public static Srlx256<T> vsrlx<T>(N256 w, T t = default)
            where T : unmanaged
                => Srlx256<T>.Op;
 
        [MethodImpl(Inline)]
        public static Sllx128<T> vsllx<T>(N128 w, T t = default)
            where T : unmanaged
                => Sllx128<T>.Op;

        [MethodImpl(Inline)]
        public static Sllx256<T> vsllx<T>(N256 w, T t = default)
            where T : unmanaged
                => Sllx256<T>.Op;

        [MethodImpl(Inline)]
        public static Sllr128<T> vsllr<T>(N128 w, T t = default)
            where T : unmanaged
                => Sllr128<T>.Op;

        [MethodImpl(Inline)]
        public static Sllr256<T> vsllr<T>(N256 w, T t = default)
            where T : unmanaged
                => Sllr256<T>.Op;

        [MethodImpl(Inline)]
        public static Srlr128<T> vsrlr<T>(N128 w, T t = default)
            where T : unmanaged
                => Srlr128<T>.Op;

        [MethodImpl(Inline)]
        public static Srlr256<T> vsrlr<T>(N256 w, T t = default)
            where T : unmanaged
                => Srlr256<T>.Op;

        [MethodImpl(Inline)]
        public static Bsrl128<T> vbsrl<T>(N128 w, T t = default)
            where T : unmanaged
                => Bsrl128<T>.Op;

        [MethodImpl(Inline)]
        public static Bsrl256<T> vbsrl<T>(N256 w, T t = default)
            where T : unmanaged
                => Bsrl256<T>.Op;

        [MethodImpl(Inline)]
        public static Bsll128<T> vbsll<T>(N128 w, T t = default)
            where T : unmanaged
                => Bsll128<T>.Op;

        [MethodImpl(Inline)]
        public static Bsll256<T> vbsll<T>(N256 w, T t = default)
            where T : unmanaged
                => Bsll256<T>.Op;

        [MethodImpl(Inline)]
        public static Srlv128<T> vsrlv<T>(N128 w, T t = default)
            where T : unmanaged
                => Srlv128<T>.Op;

        [MethodImpl(Inline)]
        public static Srlv256<T> vsrlv<T>(N256 w, T t = default)
            where T : unmanaged
                => Srlv256<T>.Op;

        [MethodImpl(Inline)]
        public static Sllv128<T> vsllv<T>(N128 w, T t = default)
            where T : unmanaged
                => Sllv128<T>.Op;

        [MethodImpl(Inline)]
        public static Sllv256<T> vsllv<T>(N256 w, T t = default)
            where T : unmanaged
                => Sllv256<T>.Op;
    }
}