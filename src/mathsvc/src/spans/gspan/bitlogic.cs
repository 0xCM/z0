//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; 
    using static Memories;
    using static Structured;

    partial class gspan
    {
        [MethodImpl(Inline), And, Closures(Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.and<T>(), l,r,dst);

        [MethodImpl(Inline), Or, Closures(Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.or<T>(), l, r, dst);

        [MethodImpl(Inline), Xor, Closures(Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.xor<T>(), l, r, dst);

        [MethodImpl(Inline), Nand, Closures(Integers)]
        public static Span<T> nand<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.nand<T>(), l,r,dst);

        [MethodImpl(Inline), Nor, Closures(Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.nor<T>(), l, r, dst);

        [MethodImpl(Inline), Xnor, Closures(Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.xnor<T>(), l, r, dst);

        [MethodImpl(Inline), Impl, Closures(Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.impl<T>(), l, r, dst);

        [MethodImpl(Inline), NonImpl, Closures(Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.nonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), CImpl, Closures(Integers)]
        public static Span<T> cimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.cimpl<T>(), l, r, dst);

        [MethodImpl(Inline), CNonImpl, Closures(Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.cnonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), Select, Closures(Integers)]
        public static Span<T> select<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.select<T>(), a, b, c, dst);

        [MethodImpl(Inline), Not, Closures(Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => apply(MSvc.not<T>(), src, dst);
    }
}