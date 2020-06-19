//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Characterizes a discrete partition over a discrete set and, consequently, 
    /// is a constructive presentation of an equivalence relation. In this context, a parition
    /// is a collection of mutually disjoint subsets of a given set whose union
    /// is recovers the original set
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Setoid</remarks>
    public interface ISetoid<C,T> : IQuotientSet<C,T>
        where C : IDiscreteEqivalenceClass<C,T>, new()
        where T : ISemigroup<T>, new()
    {

    }
}