//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static MSvcHosts;

    partial class MSvc
    {
       [MethodImpl(Inline)]
       public static And<T> and<T>(T t = default)
            where T : unmanaged
                => default(And<T>);

        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged
                => default(Or<T>);

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged
                => default(Xor<T>);

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged
                => default(Nand<T>);

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged
                => default(Nor<T>);

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged
                => default(Xnor<T>);

        [MethodImpl(Inline)]
        public static Select<T> select<T>(T t = default)
            where T : unmanaged
                => default(Select<T>);

        [MethodImpl(Inline)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged
                => default(Not<T>);

        [MethodImpl(Inline)]
        public static Impl<T> impl<T>(T t = default)
            where T : unmanaged
                => default(Impl<T>);

        [MethodImpl(Inline)]
        public static NonImpl<T> nonimpl<T>(T t = default)
            where T : unmanaged
                => default(NonImpl<T>);

        [MethodImpl(Inline)]
        public static CImpl<T> cimpl<T>(T t = default)
            where T : unmanaged
                => default(CImpl<T>);

        [MethodImpl(Inline)]
        public static CNonImpl<T> cnonimpl<T>(T t = default)
            where T : unmanaged
                => default(CNonImpl<T>);
    }
}