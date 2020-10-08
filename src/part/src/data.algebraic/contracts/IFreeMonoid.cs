//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an operator that merges two elements into one with preservation
    /// of constituent order if such an ordering is defined. In the situation where
    /// no ordering exist, the concatenation operator is effectively reduced to
    /// an addition operator
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    [Free]
    public interface IConcatenableOps<T>
    {
        T Concat(T lhs, T rhs);
    }

    /// <summary>
    /// Characterizes free monoidal operations
    /// </summary>
    /// <typeparam name="T">The individual type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Free_monoid
    /// and http://localhost:9000/refs/books/Y2007GRAA.pdf#page=39&view=fit</remarks>
    public interface IFreeMonoidOps<T> : IMonoidal<T>, IConcatenableOps<T>
        where T : unmanaged
    {
        T IsEmpty {get;}
    }
}