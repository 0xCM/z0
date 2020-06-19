//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes free moinoidial operations
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid 
    /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
    public interface IFreeMonoidOps<T> : IMonoidOps<T>, IConcatenableOps<T>
        where T : unmanaged
    {
        T IsEmpty {get;}
    }
}