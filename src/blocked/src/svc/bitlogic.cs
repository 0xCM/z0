
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BSvcHosts;

    partial class BSvc
    {
        [MethodImpl(Inline)]
        public static Not128<T> not<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Not128<T>);

        [MethodImpl(Inline)]
        public static Not256<T> not<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Not256<T>);

        [MethodImpl(Inline)]
        public static And128<T> and<T>(W128 w, T t = default)
            where T : unmanaged
                => default(And128<T>);

        [MethodImpl(Inline)]
        public static And256<T> and<T>(W256 w, T t = default)
            where T : unmanaged
                => default(And256<T>);

        [MethodImpl(Inline)]
        public static Nand128<T> nand<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Nand128<T>);

        [MethodImpl(Inline)]
        public static Nand256<T> nand<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Nand256<T>);

        [MethodImpl(Inline)]
        public static Or128<T> or<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Or128<T>);

        [MethodImpl(Inline)]
        public static Or256<T> or<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Or256<T>);

        [MethodImpl(Inline)]
        public static Nor128<T> nor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Nor128<T>);

        [MethodImpl(Inline)]
        public static Nor256<T> nor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Nor256<T>);

        [MethodImpl(Inline)]
        public static Xor128<T> xor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Xor128<T>);

        [MethodImpl(Inline)]
        public static Xor256<T> xor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Xor256<T>);

        [MethodImpl(Inline)]
        public static Xnor128<T> xnor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Xnor128<T>);

        [MethodImpl(Inline)]
        public static Xnor256<T> xnor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Xnor256<T>);

       [MethodImpl(Inline)]
        public static XorNot128<T> xornot<T>(W128 w, T t = default)
            where T : unmanaged
                => default(XorNot128<T>);

        [MethodImpl(Inline)]
        public static XorNot256<T> xornot<T>(W256 w, T t = default)
            where T : unmanaged
                => default(XorNot256<T>);


        [MethodImpl(Inline)]
        public static Select128<T> select<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Select128<T>);

        [MethodImpl(Inline)]
        public static Select256<T> select<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Select256<T>);

        [MethodImpl(Inline)]
        public static Impl128<T> impl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Impl128<T>);

        [MethodImpl(Inline)]
        public static Impl256<T> impl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Impl256<T>);

        [MethodImpl(Inline)]
        public static NonImpl128<T> nonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(NonImpl128<T>);

        [MethodImpl(Inline)]
        public static NonImpl256<T> nonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(NonImpl256<T>);

        [MethodImpl(Inline)]
        public static CImpl128<T> cimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(CImpl128<T>);

        [MethodImpl(Inline)]
        public static CImpl256<T> cimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(CImpl256<T>);

        [MethodImpl(Inline)]
        public static CNonImpl128<T> cnonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(CNonImpl128<T>);

        [MethodImpl(Inline)]
        public static CNonImpl256<T> cnonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(CNonImpl256<T>);
    }
}