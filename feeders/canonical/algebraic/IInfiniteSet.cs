//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a type that represents an infinite number of values
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface IInfiniteSet<S> : IFormalSet
        where S : IInfiniteSet<S>, new()
    {
        bool IFormalSet.IsFinite => false;
    }

    /// <summary>
    /// Characterizes a type that represents an infinite number of values
    /// </summary>
    /// <typeparam name="T">The member type</typeparam>
    public interface IInfiniteSet<S,T> : IInfiniteSet<S>
        where S : IInfiniteSet<S,T>, new()
    {

    }
}