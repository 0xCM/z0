//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using D = CellDelegates;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost]
    public readonly partial struct CellOps
    {
        const NumericKind Closure = Integers;


        [Free]
        public interface IBinaryCellOp<T>
            where T : unmanaged, IDataCell<T>
        {

        }

        /// <summary>
        /// Applies a unary operator to an input sequence and deposits the result to a caller-supplied target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void apply<T>(ReadOnlySpan<T> src, UnaryOp<T> f, Span<T> dst)
        {
            var count = length(src,dst);
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
            var count = length(x,y);
            for(var i= 0u; i<count; i++)
                seek(dst,i) = f(skip(x,i), skip(y,i));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static UnaryOp<T> uFx<T>(MethodInfo src, UnaryOperatorClass<T> k)
            where T : unmanaged
                => Delegates.unary<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static BinaryOp<T> bFx<T>(MethodInfo src, BinaryOperatorClass<T> K)
            where T : unmanaged
                => Delegates.binary<T>(src);

        /// <summary>
        /// Evaluates a 128-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> apply<T>(D.UnaryOp128 f, Vector128<T> x)
            where T : unmanaged
                => f(x.ToCell()).ToVector<T>();

        /// <summary>
        /// Evaluates a 256-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> apply<T>(D.UnaryOp256 f, Vector256<T> x)
            where T : unmanaged
                => f(x.ToCell()).ToVector<T>();

        /// <summary>
        /// Evaluates a 512-bit unary operator over a vector
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector512<T> apply<T>(D.UnaryOp512 f, in Vector512<T> x)
            where T : unmanaged
                => f(x.ToCell()).ToVector<T>();

        /// <summary>
        /// Evaluates a 128-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> apply<T>(D.BinaryOp128 f, Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => f(x.ToCell(), y.ToCell()).ToVector<T>();

        /// <summary>
        /// Evaluates a 256-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> apply<T>(D.BinaryOp256 f, Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => f(x.ToCell(), y.ToCell()).ToVector<T>();

        /// <summary>
        /// Evaluates a 512-bit binary operator over a pair of vectors
        /// </summary>
        /// <param name="f">The operator</param>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector512<T> apply<T>(D.BinaryOp512 f, Vector512<T> x, Vector512<T> y)
            where T : unmanaged
                => f(x.ToCell(), y.ToCell()).ToVector<T>();

        [MethodImpl(Inline), Op]
        public static D.Emitter1 cellop1(Emitter<bit> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter8 cellop8(Emitter<sbyte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter8 cellop8(Emitter<byte> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter16 cellop16(Emitter<short> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter16 cellop16(Emitter<ushort> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter32 cellop32(Emitter<int> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter32 cellop32(Emitter<uint> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter64 cellop64(Emitter<long> f)
            => () => f();

        [MethodImpl(Inline), Op]
        public static D.Emitter64 cellop64(Emitter<ulong> f)
            => () => f();
    }
}