//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface INegatableOps<T>
    {
        /// <summary>
        /// Unary negation of input
        /// </summary>
        /// <param name="x">The input value</param>
        T Negate(T x);
    }
}