//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IValueSet<F,T> : ISet<F,T>, ICounted, INullity
        where F : struct, IValueSet<F,T>
        where T : struct
    {
        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member</param>
        bool Contains(in T candidate);

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSubset(in F rhs, bool proper);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSuperset(in F rhs, bool proper);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        F Union(in F rhs);

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        F Intersect(in F rhs);

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current
        /// set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        F Difference(in F rhs, bool symmetric);

        bool ISet<F,T>.Contains(T candidate)
            => Contains(in candidate);

        bool ISet<F,T>.IsSubset(F rhs, bool proper)
            => IsSubset(rhs,proper);

        bool ISet<F,T>.IsSuperset(F rhs, bool proper)
            => IsSuperset(rhs,proper);

        F ISet<F,T>.Union(F rhs)
            => Union(rhs);

        F ISet<F,T>.Intersect(F rhs)
            => Intersect(rhs);

        F ISet<F,T>.Difference(F rhs, bool symmetric)
            => Difference(rhs,symmetric);
    }
}