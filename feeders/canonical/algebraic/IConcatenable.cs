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

    /// <summary>
    /// Characterizes a reification that defines an intrinsic concatentation operator
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<S> : IConcrete<S>
        where S : IConcatenable<S>, new()
    {
        /// <summary>
        /// Concatenates the intrinsic value with a suplied value 
        /// </summary>
        /// <param name="rhs">The right value supplied to the concatenation operator</param>
        S Concat(S rhs);
    }

    /// <summary>
    /// Characterizes a parametric conatenable thing 
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface IConcatenable<S,T> : IConcatenable<S>
        where S : IConcatenable<S,T>, new()
    {

    }
}