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
    using static SFx;

    partial struct Calcs
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Or<T> or<T>()
            where T : unmanaged
                => default(Or<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Xor<T> xor<T>()
            where T : unmanaged
                => default(Xor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nand<T> nand<T>()
            where T : unmanaged
                => default(Nand<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Nor<T> nor<T>()
            where T : unmanaged
                => default(Nor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Xnor<T> xnor<T>()
            where T : unmanaged
                => default(Xnor<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Select<T> select<T>()
            where T : unmanaged
                => default(Select<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Impl<T> impl<T>()
            where T : unmanaged
                => default(Impl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static NonImpl<T> nonimpl<T>()
            where T : unmanaged
                => default(NonImpl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static CImpl<T> cimpl<T>()
            where T : unmanaged
                => default(CImpl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static CNonImpl<T> cnonimpl<T>()
            where T : unmanaged
                => default(CNonImpl<T>);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T or<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var result = default(T);
            for(var i=0; i<src.Length; i++)
                result = or<T>().Invoke(result, memory.skip(src,(uint)i));
            return result;
        }


        [MethodImpl(Inline), Or, Closures(Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(or<T>(), a, b, dst);

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(xor<T>(), a, b, dst);

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static Span<T> nand<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(nand<T>(), a, b,dst);

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(nor<T>(), a, b, dst);

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(xnor<T>(), a, b, dst);

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(impl<T>(), a, b, dst);

        [MethodImpl(Inline), NonImpl, Closures(Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(nonimpl<T>(), a, b, dst);

        [MethodImpl(Inline), CImpl, Closures(Integers)]
        public static Span<T> cimpl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(cimpl<T>(), a, b, dst);

        [MethodImpl(Inline), CNonImpl, Closures(Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
                => apply(cnonimpl<T>(), a, b, dst);

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static Span<T> select<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => apply(select<T>(), a, b, c, dst);

    }
}