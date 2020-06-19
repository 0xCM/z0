//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace  Z0
{
    using System;

    /// <summary>
    /// Characterizes operational multiplication
    /// </summary>
    /// <typeparam name="T">The type subject to multiplication</typeparam>
    public interface IMultiplicativeOps<T>
    {
        T Mul(T lhs, T rhs);
    }    
}