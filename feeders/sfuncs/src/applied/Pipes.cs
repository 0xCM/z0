//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static SFuncs;

    public static class SPipes
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
            where F : ISUnaryOpApi<T>
            where G : ISUnaryOpApi<T>
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
            where F : ISUnaryOpApi<T>
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
            where F : ISBinaryOpApi<T>
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
            where F : ISBinaryOpApi<T>
            where G : ISUnaryOpApi<T>
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
            where F : ISBinaryOpApi<T>
            where G : ISUnaryOpApi<T>
                => f.Invoke(g.Invoke(x), g.Invoke(y));
    }
}