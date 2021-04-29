
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
        [MethodImpl(Inline)]
        public static Xor128<T> xor<T>(W128 w)
            where T : unmanaged
                => default(Xor128<T>);

        [MethodImpl(Inline)]
        public static Xor256<T> xor<T>(W256 w)
            where T : unmanaged
                => default(Xor256<T>);

        [MethodImpl(Inline)]
        public static Xnor128<T> xnor<T>(W128 w)
            where T : unmanaged
                => default(Xnor128<T>);

        [MethodImpl(Inline)]
        public static Xnor256<T> xnor<T>(W256 w)
            where T : unmanaged
                => default(Xnor256<T>);

       [MethodImpl(Inline)]
        public static XorNot128<T> xornot<T>(W128 w)
            where T : unmanaged
                => default(XorNot128<T>);

        [MethodImpl(Inline)]
        public static XorNot256<T> xornot<T>(W256 w)
            where T : unmanaged
                => default(XorNot256<T>);

        [MethodImpl(Inline)]
        public static Select128<T> select<T>(W128 w)
            where T : unmanaged
                => default(Select128<T>);

        [MethodImpl(Inline)]
        public static Select256<T> select<T>(W256 w)
            where T : unmanaged
                => default(Select256<T>);

        [MethodImpl(Inline)]
        public static Impl128<T> impl<T>(W128 w)
            where T : unmanaged
                => default(Impl128<T>);

        [MethodImpl(Inline)]
        public static Impl256<T> impl<T>(W256 w)
            where T : unmanaged
                => default(Impl256<T>);

        [MethodImpl(Inline)]
        public static NonImpl128<T> nonimpl<T>(W128 w)
            where T : unmanaged
                => default(NonImpl128<T>);

        [MethodImpl(Inline)]
        public static NonImpl256<T> nonimpl<T>(W256 w)
            where T : unmanaged
                => default(NonImpl256<T>);

        [MethodImpl(Inline)]
        public static CImpl128<T> cimpl<T>(W128 w)
            where T : unmanaged
                => default(CImpl128<T>);

        [MethodImpl(Inline)]
        public static CImpl256<T> cimpl<T>(W256 w)
            where T : unmanaged
                => default(CImpl256<T>);

        [MethodImpl(Inline)]
        public static CNonImpl128<T> cnonimpl<T>(W128 w)
            where T : unmanaged
                => default(CNonImpl128<T>);

        [MethodImpl(Inline)]
        public static CNonImpl256<T> cnonimpl<T>(W256 w)
            where T : unmanaged
                => default(CNonImpl256<T>);
    }
}