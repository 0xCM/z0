//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Delegates
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T> func<T>(Emitter<T> f)
            => new System.Func<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T> func<T>(Z0.UnaryOp<T> f)
            => new System.Func<T,T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T> func<T>(BinaryOp<T> f)
            => new System.Func<T,T,T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,T,T> func<T>(Z0.TernaryOp<T> f)
            => new System.Func<T,T,T,T>(f);

        [MethodImpl(Inline)]
        public static System.Func<T> func<T,C>(Emitter<T,C> f)
            where T : unmanaged
            where C : unmanaged
                => new System.Func<T>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,Bit32> func<T>(BinaryPredicate<T> f)
            => new System.Func<T,T,Bit32>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,T,bool> func<T>(BinaryPredicate8<T> f)
            => new System.Func<T,T,bool>(f);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static System.Func<T,Bit32> func<T>(UnaryPredicate<T> f)
            => new System.Func<T,Bit32>(f);

        /// <summary>
        /// Creates a function delegate of generic arity 1 from a static method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="x0">A representative value for the first argument, used only for type inference</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        [MethodImpl(Inline)]
        public static Func<X0> func<X0>(MethodInfo src, X0 x0 = default)
            => from<Func<X0>>(src);

        /// <summary>
        /// Creates a function delegate of generic arity 2 from a static method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="x0">A representative value of the first argument, used only for type inference</param>
        /// <param name="x1">A representative value of the second argument, used only for type inference</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        [MethodImpl(Inline)]
        public static Func<X0,X1> func<X0,X1>(MethodInfo src, X0 x0 = default, X1 x1= default)
            => from<Func<X0,X1>>(src);

        /// <summary>
        /// Creates a function delegate of generic arity 3 from a static method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="x0">A representative value of the first argument, used only for type inference</param>
        /// <param name="x1">A representative value of the second argument, used only for type inference</param>
        /// <param name="x2">A representative value of the third argument, used only for type inference</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        [MethodImpl(Inline)]
        public static Func<X0,X1,X2> func<X0,X1,X2>(MethodInfo src, X0 x0 = default, X1 x1= default, X2 x2= default)
            => from<Func<X0,X1,X2>>(src);

        /// <summary>
        /// Creates a function delegate of generic arity 4 from a static method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="x0">A representative value of the first argument, used only for type inference</param>
        /// <param name="x1">A representative value of the second argument, used only for type inference</param>
        /// <param name="x2">A representative value of the third argument, used only for type inference</param>
        /// <param name="x3">A representative value of the fourth argument, used only for type inference</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        /// <typeparam name="X3">The fourth argument type</typeparam>
        [MethodImpl(Inline)]
        public static Func<X0,X1,X2,X3> func<X0,X1,X2,X3>(MethodInfo src, X0 x0 = default, X1 x1= default, X2 x2= default, X3 x3 = default)
            => from<Func<X0,X1,X2,X3>>(src);
    }
}