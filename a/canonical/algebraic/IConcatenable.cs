//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an operator that merges two elements into one with preservation
    /// of constituent order if such an ordering is defined. In the situation where
    /// no ordering exist, the concatenation operator is effectively reduced to
    /// an addition operator
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IConcatenableOps<T>
    {
        T Concat(T lhs, T rhs);
    }

}