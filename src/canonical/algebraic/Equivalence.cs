//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    /// <summary>
    /// Characterizes a constructive equivalence class, i.e. an equivalence class 
    /// with enumerable content
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    public interface IDiscreteEqivalenceClass<S,T> : IEquivalenceClass<S,T>, IDiscreteSet<S,T> 
        where S : IDiscreteEqivalenceClass<S,T>, new() { }

    /// <summary>
    /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
    /// an equivalence relation
    /// </summary>
    /// <typeparam name="T">The classified type</typeparam>
    public interface IFiniteEquivalenceClass<S,T> : IDiscreteEqivalenceClass<S,T>
        where S : IFiniteEquivalenceClass<S,T>, new()
    { }
}