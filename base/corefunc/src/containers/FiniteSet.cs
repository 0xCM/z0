//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class FiniteSet
    {
        /// <summary>
        /// Constructs a finite set from supplied members
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static FiniteSet<T> define<T>(params T[] members)
            where T : ISemigroup<T>, new()
                => new FiniteSet<T>(members);

        /// <summary>
        /// Constructs a finite set from supplied sequence
        /// </summary>
        /// <param name="members">The defining members</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static FiniteSet<T> define<T>(IEnumerable<T> members)
            where T : ISemigroup<T>, new()
                => new FiniteSet<T>(members);
    }    


    /// <summary>
    /// Contains a finite set of values
    /// </summary>
    public readonly struct FiniteSet<T> : IFiniteSet<FiniteSet<T>,T>, IEquatable<FiniteSet<T>>
        where T : ISemigroup<T>, new()
    {
        readonly HashSet<T> data;
            
        [MethodImpl(Inline)]
        public static implicit operator FiniteSet<T>(HashSet<T> src)
            => new FiniteSet<T>(src);

        [MethodImpl(Inline)]
        public static FiniteSet<T> operator +(FiniteSet<T> a, FiniteSet<T> b)
            => a.Union(b);

        [MethodImpl(Inline)]
        public static FiniteSet<T> operator -(FiniteSet<T> a, FiniteSet<T> b)
            => a.Difference(b);

        [MethodImpl(Inline)]
        public static FiniteSet<T> operator *(FiniteSet<T> a, FiniteSet<T> b)
            => a.Intersect(b);

        [MethodImpl(Inline)]
        public static bool operator <(FiniteSet<T> a, FiniteSet<T> b)
            => b.IsSuperset(a, true);

        [MethodImpl(Inline)]
        public static bool operator >(FiniteSet<T> a, FiniteSet<T> b)
            => a.IsSuperset(b, true);

        [MethodImpl(Inline)]
        public static bool operator <=(FiniteSet<T> a, FiniteSet<T> b)
            => b.IsSuperset(a, false);

        [MethodImpl(Inline)]
        public static bool operator >=(FiniteSet<T> a, FiniteSet<T> b)
            => a.IsSuperset(b, false);

        public static bool operator <(T a, FiniteSet<T> b)
            => b.Contains(a);

        [MethodImpl(Inline)]
        public static bool operator >(T a, FiniteSet<T> b)
            => b.Contains(a) && b.Count == 1;

        [MethodImpl(Inline)]
        public static bool operator ==(FiniteSet<T> a, FiniteSet<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(FiniteSet<T> a, FiniteSet<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]   
        public FiniteSet(IEnumerable<T> members)
            => this.data = hashset(members);

        [MethodImpl(Inline)]   
        public FiniteSet(HashSet<T> members)
            => this.data = members;

        public int Count 
        {
            [MethodImpl(Inline)]
            get => data.Count;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }

        public bool IsFinite
        {
            [MethodImpl(Inline)]
            get => true;
        }

        public bool IsDiscrete
        {
            [MethodImpl(Inline)]
            get => true;
        }
        
        [MethodImpl(Inline)]   
        public bool Contains(T candidate)
            => data.Contains(candidate);

        [MethodImpl(Inline)]   
        public bool IsMember(object candidate)
            => candidate is T ? Contains((T)candidate) :false;
        
        public IEnumerable<T> Content
            => data;

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSubset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSubsetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSuperset(FiniteSet<T> rhs, bool proper = true)
            => proper ? data.IsProperSupersetOf(rhs.data) : data.IsSubsetOf(rhs.data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        [MethodImpl(Inline)]   
        public FiniteSet<T> Union(FiniteSet<T> rhs)
        {
            var result = hashset(data);
            result.UnionWith(rhs.data);
            return result;
        }

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        [MethodImpl(Inline)]   
        public FiniteSet<T> Intersect(FiniteSet<T> rhs)
        {
            var result = hashset(data);
            result.IntersectWith(rhs.data);
            return result;
        }

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current set and a specified set 
        /// and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        [MethodImpl(Inline)]   
        public FiniteSet<T> Difference(FiniteSet<T> rhs, bool symmetric = false)
        {
            var result = hashset(data);
            if(symmetric)
                result.SymmetricExceptWith(rhs.data);
            else
                result.ExceptWith(rhs.data);
            return result;
        }
    
        /// <summary>
        /// Determine whether the current set and a specified set have a nonemtpy intersection
        /// </summary>
        /// <param name="rhs">The set to compare</param>
        [MethodImpl(Inline)]   
        public bool Intersects(FiniteSet<T> rhs)
            => data.Overlaps(rhs.data);

        static readonly IEqualityComparer<HashSet<T>> setcomparer = HashSet<T>.CreateSetComparer(); 

        [MethodImpl(Inline)]   
        public bool Equals(FiniteSet<T> other)
            => setcomparer.Equals(data, other.data);

        public override bool Equals(object obj)
            => obj is FiniteSeq<T> x && Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();
        
        [MethodImpl(Inline)]   
        static HashSet<T> hashset(IEnumerable<T> members)
            => new HashSet<T>(members);

    }
}