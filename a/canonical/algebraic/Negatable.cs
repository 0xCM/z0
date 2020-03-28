//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface INegatableOps<T>
        where T : unmanaged
    {
        /// <summary>
        /// Unary negation of input
        /// </summary>
        /// <param name="x">The input value</param>
        T Negate(T x);

    }

    public interface INegatable<S>
        where S : INegatable<S>, new()
    {
        /// <summary>
        /// Unary structural negation
        /// </summary>
        /// <param name="a">The input value</param>
        S Negate();
    }
}