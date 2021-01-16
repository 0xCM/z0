//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CellOps, true)]
    public readonly partial struct CellOps
    {
        const NumericKind Closure = Integers;

        /// <summary>
        /// Applies a unary operator to an input sequence and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(ReadOnlySpan<T> src, UnaryOp<T> f, Span<T> dst)
        {
            var count = root.length(src,dst);
            for(var i= 0u; i<count; i++)
                seek(dst,i) = f(skip(src,i));
        }

        /// <summary>
        /// Projects a pair of source spans to target span via a binary operator
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <param name="f">The operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(ReadOnlySpan<T> x, ReadOnlySpan<T> y, BinaryOp<T> f, Span<T> dst)
        {
            var count = root.length(x,y);
            for(var i= 0u; i<count; i++)
                seek(dst,i) = f(skip(x,i), skip(y,i));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static UnaryOp<T> uFx<T>(MethodInfo src, UnaryOpClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static BinaryOp<T> bFx<T>(MethodInfo src, BinaryOpClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);
    }
}