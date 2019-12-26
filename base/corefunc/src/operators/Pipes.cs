//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class Pipes
    {
        /// <summary>
        /// Computes y := x |> f |> g := g(f(x)) for unary operators f and g
        /// </summary>
        /// <param name="x">The input value</param>
        /// <param name="f">A unary operator</param>
        /// <param name="g">A unary operator</param>
        /// <typeparam name="F">The type of the first unary operator</typeparam>
        /// <typeparam name="G">The type of the second unary operator</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static T pipe<F,G,T>(T x, F f, G g)
            where F : IUnaryOp<T>
            where G : IUnaryOp<T>
                => g.Invoke(f.Invoke(x));

        /// <summary>
        /// Computes y := x |> f = f(x) for a unary operator f
        /// </summary>
        /// <param name="x">The left domain value</param>
        /// <param name="y">The right domain value</param>
        /// <param name="f">The binary operator</param>
        /// <typeparam name="F">The binary operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static T apply<F,T>(T x, F f)
            where F : IUnaryOp<T>
                => f.Invoke(x);

        /// <summary>
        /// Computes z := y |> f x := f(x,y) for a binary operator f
        /// </summary>
        /// <param name="x">The left domain value</param>
        /// <param name="y">The right domain value</param>
        /// <param name="f">The binary operator</param>
        /// <typeparam name="F">The binary operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static T apply<F,T>(T x, T y, F f)
            where F : IBinaryOp<T>
                => f.Invoke(x,y);

        /// <summary>
        /// Computes y := f(x,g(x)) for a unary operator g, and binary operator f
        /// </summary>
        /// <param name="x">The input value</param>
        /// <param name="f">A binary operator</param>
        /// <param name="g">A unary operator</param>
        /// <typeparam name="F">The binary operator type</typeparam>
        /// <typeparam name="G">The unary operator type</typeparam>
        /// <typeparam name="T">The type over which the operators are defined</typeparam>
        [MethodImpl(Inline)]
        public static T compose<F,G,T>(T x, F f, G g)
            where F : IBinaryOp<T>
            where G : IUnaryOp<T>
                => f.Invoke(x, g.Invoke(x));

        /// <summary>
        /// Computes y := f(g(x),g(y)) for a unary operator g, and binary operator f
        /// </summary>
        /// <param name="x">The input value</param>
        /// <param name="f">A binary operator</param>
        /// <param name="g">A unary operator</param>
        /// <typeparam name="F">The binary operator type</typeparam>
        /// <typeparam name="G">The unary operator type</typeparam>
        /// <typeparam name="T">The type over which the operators are defined</typeparam>
        [MethodImpl(Inline)]
        public static T compose<F,G,T>(T x, T y, F f, G g)
            where F : IBinaryOp<T>
            where G : IUnaryOp<T>
                => f.Invoke(g.Invoke(x), g.Invoke(y));
    }
}