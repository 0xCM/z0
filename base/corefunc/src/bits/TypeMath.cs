//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    /// <summary>
    /// Implements parametric computations
    /// </summary>
    public static class TypeMath
    {        
        /// <summary>
        /// Computes the product p := natval[M] * bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A bit width type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static int mul<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() * bitsize<T>();

        /// <summary>
        /// Computes the product p := natval[M] * natval[N] * bitsize[T]
        /// </summary>
        /// <param name="m">The representative of the first parameter</param>
        /// <param name="n">The representative of the second parameter</param>
        /// <param name="t">A representative of the bit width type</param>
        /// <typeparam name="M">The type of the first parameter</typeparam>
        /// <typeparam name="N">The type of the second parameter</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static int mul<M,N,T>(M m = default, N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => NatMath.mul<M,N>() * bitsize<T>();

        /// <summary>
        /// Computes the quotient q := natval[N] / bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static int div<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() / bitsize<T>();

        /// <summary>
        /// Computes the remainder r := natval[N] % bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static int mod<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() % bitsize<T>();

        /// <summary>
        /// Computes the upward-rounded quotient 
        /// q := natval[N] % bitsize[T] == 0 ? natval[N] / bitsize[T] : (natval[N] / bitsize[T]) + 1
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The width type</typeparam>
        [MethodImpl(Inline)]
        public static int divceil<N,T>(N n = default, T t = default)                
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => mod(n,t) == 0 ? div(n,t) : div(n,t) + 1;

        /// <summary>
        /// Computes the predicate p := natval[N] == bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static bit eq<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() == bitsize<T>();

        /// <summary>
        /// Computes the predicate p := natval[N] < bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static bit lt<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() < bitsize<T>();

        /// <summary>
        /// Computes the predicate p := natval[N] <= bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The width type</typeparam>
        [MethodImpl(Inline)]
        public static bit lteq<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() <= bitsize<T>();

        /// <summary>
        /// Computes the predicate p := natval[N] > bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static bit gt<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() > bitsize<T>();

        /// <summary>
        /// Computes the predicate p := natval[N] >= bitsize[T]
        /// </summary>
        /// <param name="n">The natural representative</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The bit width type</typeparam>
        [MethodImpl(Inline)]
        public static bit gteq<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => natval<N>() >= bitsize<T>();
    }
}