//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a set that, if nonempty, contains elements of unknown type
    /// </summary>
    public interface IFormalSet
    {
        /// <summary>
        /// Specifies whether the set is void of elements
        /// </summary>
        bool IsEmpty {get;}

        /// <summary>
        /// Specifies whether the set is finite
        /// </summary>
        bool IsFinite {get;}

        /// <summary>
        /// Specifies whether the set is discrete
        /// </summary>
        bool IsDiscrete {get;}
    }


    /// <summary>
    /// Characteriizes a reified set for which there are a countable number of members
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IDiscreteSet<S,T> : IFormalSet, IEnumerableContainer<S,T>
        where S: IDiscreteSet<S,T>, new()
    {

    }

    /// <summary>
    /// Characteriizes a reified set that contains a finite number of values
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="T">The member type</typeparam>
    public interface IFiniteSet<S,T> : IDiscreteSet<S,T>
        where S : IFiniteSet<S,T>, new()
    {
        /// <summary>
        /// Evidence that the set is indeed finite
        /// </summary>
        int Count {get;}

        /// <summary>
        /// Determines whether a value is a member
        /// </summary>
        /// <param name="candidate">The potential member to check</param>
        bool Contains(T candidate);

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSubset(S rhs, bool proper = true);
        
        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        bool IsSuperset(S rhs, bool proper = true);

        /// <summary>
        /// Calculates the union between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        S Union(S rhs);
        
        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        S Intersect(S rhs);
        
        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current 
        /// set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        S Difference(S rhs, bool symmetric = false);
    }    
}