//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class gspan
    {
        /// <summary>
        /// Computes the bitwise and between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.and<T>(), l,r,dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> and<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => SFuncs.apply(MathSvc.and<T>(),lhs,rhs);

        /// <summary>
        /// Computes the bitwise or between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.or<T>(), l, r, dst);

        /// <summary>
        /// Computes the aggregate bitwise or of the source elements
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static T or<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var result = default(T);
            for(var i=0; i<src.Length; i++)
                result = MathSvc.or<T>().Invoke(result, skip(src,i));
            return result;
        }                

        /// <summary>
        /// Computes the bitwise xor between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.xor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> nand<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.nand<T>(), l,r,dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.nor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.xnor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.impl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.nonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> cimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.cimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.cnonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> select<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.select<T>(), a, b, c, dst);

        [MethodImpl(Inline), SpanOp, Closures(Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SFuncs.apply(MathSvc.not<T>(), src, dst);
    }
}