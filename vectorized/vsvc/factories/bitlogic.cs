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
        public static And128<T> vand<T>(N128 w, T t = default)
            where T : unmanaged
                => And128<T>.Op;

        [MethodImpl(Inline)]
        public static And256<T> vand<T>(N256 w, T t = default)
            where T : unmanaged
                => And256<T>.Op;

        [MethodImpl(Inline)]
        public static Or128<T> vor<T>(N128 w, T t = default)
            where T : unmanaged
                => Or128<T>.Op;

        [MethodImpl(Inline)]
        public static Or256<T> vor<T>(N256 w, T t = default)
            where T : unmanaged
                => Or256<T>.Op;

        [MethodImpl(Inline)]
        public static Xor128<T> vxor<T>(N128 w, T t = default)
            where T : unmanaged
                => Xor128<T>.Op;

        [MethodImpl(Inline)]
        public static Xor256<T> vxor<T>(N256 w, T t = default)
            where T : unmanaged
                => Xor256<T>.Op;

        [MethodImpl(Inline)]
        public static Nand128<T> vnand<T>(N128 w, T t = default)
            where T : unmanaged
                => Nand128<T>.Op;

        [MethodImpl(Inline)]
        public static Nand256<T> vnand<T>(N256 w, T t = default)
            where T : unmanaged
                => Nand256<T>.Op;

        [MethodImpl(Inline)]
        public static Nor128<T> vnor<T>(N128 w, T t = default)
            where T : unmanaged
                => Nor128<T>.Op;

        [MethodImpl(Inline)]
        public static Nor256<T> vnor<T>(N256 w, T t = default)
            where T : unmanaged
                => Nor256<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor128<T> vxnor<T>(N128 w, T t = default)
            where T : unmanaged
                => Xnor128<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor256<T> vxnor<T>(N256 w, T t = default)
            where T : unmanaged
                => Xnor256<T>.Op;

        [MethodImpl(Inline)]
        public static XorNot128<T> vxornot<T>(N128 w, T t = default)
            where T : unmanaged
                => XorNot128<T>.Op;

        [MethodImpl(Inline)]
        public static XorNot256<T> vxornot<T>(N256 w, T t = default)
            where T : unmanaged
                => XorNot256<T>.Op;

        [MethodImpl(Inline)]
        public static Not128<T> vnot<T>(N128 w, T t = default)
            where T : unmanaged
                => Not128<T>.Op;

        [MethodImpl(Inline)]
        public static Not256<T> vnot<T>(N256 w, T t = default)
            where T : unmanaged
                => Not256<T>.Op;

        [MethodImpl(Inline)]
        public static Select128<T> vselect<T>(N128 w, T t = default)
            where T : unmanaged
                => Select128<T>.Op;

        [MethodImpl(Inline)]
        public static Select256<T> vselect<T>(N256 w, T t = default)
            where T : unmanaged
                => Select256<T>.Op;

        [MethodImpl(Inline)]
        public static Impl128<T> vimpl<T>(N128 w, T t = default)
            where T : unmanaged
                => Impl128<T>.Op;

        [MethodImpl(Inline)]
        public static Impl256<T> vimpl<T>(N256 w, T t = default)
            where T : unmanaged
                => Impl256<T>.Op;

        [MethodImpl(Inline)]
        public static NonImpl128<T> vnonimpl<T>(N128 w, T t = default)
            where T : unmanaged
                => NonImpl128<T>.Op;

        [MethodImpl(Inline)]
        public static NonImpl256<T> vnonimpl<T>(N256 w, T t = default)
            where T : unmanaged
                => NonImpl256<T>.Op;

        [MethodImpl(Inline)]
        public static CImpl128<T> vcimpl<T>(N128 w, T t = default)
            where T : unmanaged
                => CImpl128<T>.Op;

        [MethodImpl(Inline)]
        public static CImpl256<T> vcimpl<T>(N256 w, T t = default)
            where T : unmanaged
                => CImpl256<T>.Op;

        [MethodImpl(Inline)]
        public static CNonImpl128<T> vcnonimpl<T>(N128 w, T t = default)
            where T : unmanaged
                => CNonImpl128<T>.Op;

        [MethodImpl(Inline)]
        public static CNonImpl256<T> vcnonimpl<T>(N256 w, T t = default)
            where T : unmanaged
                => CNonImpl256<T>.Op;
   }
}