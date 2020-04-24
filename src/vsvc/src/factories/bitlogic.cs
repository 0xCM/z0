//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static VSvcHosts;

    partial class VSvc
    {
        [MethodImpl(Inline)]
        public static And128<T> vand<T>(W128 w, T t = default)
            where T : unmanaged
                => default(And128<T>);

        [MethodImpl(Inline)]
        public static And256<T> vand<T>(W256 w, T t = default)
            where T : unmanaged
                => default(And256<T>);

        [MethodImpl(Inline)]
        public static Nand128<T> vnand<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Nand128<T>);

        [MethodImpl(Inline)]
        public static Nand256<T> vnand<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Nand256<T>);

        [MethodImpl(Inline)]
        public static Or128<T> vor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Or128<T>);

        [MethodImpl(Inline)]
        public static Or256<T> vor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Or256<T>);

        [MethodImpl(Inline)]
        public static Nor128<T> vnor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Nor128<T>);

        [MethodImpl(Inline)]
        public static Nor256<T> vnor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Nor256<T>);

        [MethodImpl(Inline)]
        public static Xor128<T> vxor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Xor128<T>);

        [MethodImpl(Inline)]
        public static Xor256<T> vxor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Xor256<T>);

        [MethodImpl(Inline)]
        public static Xnor128<T> vxnor<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Xnor128<T>);

        [MethodImpl(Inline)]
        public static Xnor256<T> vxnor<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Xnor256<T>);

        [MethodImpl(Inline)]
        public static XorNot128<T> vxornot<T>(W128 w, T t = default)
            where T : unmanaged
                => default(XorNot128<T>);

        [MethodImpl(Inline)]
        public static XorNot256<T> vxornot<T>(W256 w, T t = default)
            where T : unmanaged
                => default(XorNot256<T>);

        [MethodImpl(Inline)]
        public static Not128<T> vnot<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Not128<T>);

        [MethodImpl(Inline)]
        public static Not256<T> vnot<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Not256<T>);

        [MethodImpl(Inline)]
        public static Select128<T> vselect<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Select128<T>);

        [MethodImpl(Inline)]
        public static Select256<T> vselect<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Select256<T>);

        [MethodImpl(Inline)]
        public static Impl128<T> vimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(Impl128<T>);

        [MethodImpl(Inline)]
        public static Impl256<T> vimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(Impl256<T>);

        [MethodImpl(Inline)]
        public static NonImpl128<T> vnonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(NonImpl128<T>);

        [MethodImpl(Inline)]
        public static NonImpl256<T> vnonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(NonImpl256<T>);

        [MethodImpl(Inline)]
        public static CImpl128<T> vcimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(CImpl128<T>);

        [MethodImpl(Inline)]
        public static CImpl256<T> vcimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(CImpl256<T>);

        [MethodImpl(Inline)]
        public static CNonImpl128<T> vcnonimpl<T>(W128 w, T t = default)
            where T : unmanaged
                => default(CNonImpl128<T>);

        [MethodImpl(Inline)]
        public static CNonImpl256<T> vcnonimpl<T>(W256 w, T t = default)
            where T : unmanaged
                => default(CNonImpl256<T>);
   }
}