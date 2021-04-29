//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static MSvcHosts;

    partial class MSvc
    {
       [MethodImpl(Inline), Op, Closures(Integers)]
       public static And<T> and<T>()
            where T : unmanaged
                => default(And<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged
                => default(Or<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged
                => default(Xor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged
                => default(Nand<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged
                => default(Nor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged
                => default(Xnor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Select<T> select<T>(T t = default)
            where T : unmanaged
                => default(Select<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged
                => default(Not<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Impl<T> impl<T>(T t = default)
            where T : unmanaged
                => default(Impl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static NonImpl<T> nonimpl<T>(T t = default)
            where T : unmanaged
                => default(NonImpl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static CImpl<T> cimpl<T>(T t = default)
            where T : unmanaged
                => default(CImpl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static CNonImpl<T> cnonimpl<T>(T t = default)
            where T : unmanaged
                => default(CNonImpl<T>);
    }
}