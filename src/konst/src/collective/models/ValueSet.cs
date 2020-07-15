//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Contains a finite set of values
    /// </summary>
    public readonly struct ValueSet<T> : IDeferredSet<ValueSet<T>,T>, IEquatable<ValueSet<T>>
        where T : struct
    {
        internal readonly HashSet<T> Data;

        [MethodImpl(Inline)]   
        public ValueSet(IEnumerable<T> src)
            => Data = hashset(src);

        [MethodImpl(Inline)]   
        public ValueSet(HashSet<T> src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator ValueSet<T>(HashSet<T> src)
            => new ValueSet<T>(src);

        [MethodImpl(Inline)]
        public static ValueSet<T> operator +(ValueSet<T> a, ValueSet<T> b)
            => a.Union(b);

        [MethodImpl(Inline)]
        public static ValueSet<T> operator -(ValueSet<T> a, ValueSet<T> b)
            => a.Difference(b);

        [MethodImpl(Inline)]
        public static ValueSet<T> operator *(ValueSet<T> a, ValueSet<T> b)
            => a.Intersect(b);

        [MethodImpl(Inline)]
        public static bool operator <(ValueSet<T> a, ValueSet<T> b)
            => b.IsSuperset(a, true);

        [MethodImpl(Inline)]
        public static bool operator >(ValueSet<T> a, ValueSet<T> b)
            => a.IsSuperset(b, true);

        [MethodImpl(Inline)]
        public static bool operator <=(ValueSet<T> a, ValueSet<T> b)
            => b.IsSuperset(a, false);

        [MethodImpl(Inline)]
        public static bool operator >=(ValueSet<T> a, ValueSet<T> b)
            => a.IsSuperset(b, false);

        public static bool operator <(T a, ValueSet<T> b)
            => b.Contains(a);

        [MethodImpl(Inline)]
        public static bool operator >(T a, ValueSet<T> b)
            => b.Contains(a) && b.Count == 1;

        [MethodImpl(Inline)]
        public static bool operator ==(ValueSet<T> a, ValueSet<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ValueSet<T> a, ValueSet<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]   
        public ValueSet<T> WithContent(IEnumerable<T> src)
            => new ValueSet<T>(src);

        public int Count 
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }
        
        [MethodImpl(Inline)]   
        public bool Contains(T candidate)
            => Data.Contains(candidate);

        [MethodImpl(Inline)]   
        public bool IsMember(object candidate)
            => candidate is T ? Contains((T)candidate) :false;
        
        public IEnumerable<T> Content
            => Data;

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSubset(ValueSet<T> rhs, bool proper = true)
            => proper ? Data.IsProperSubsetOf(rhs.Data) : Data.IsSubsetOf(rhs.Data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]   
        public bool IsSuperset(ValueSet<T> rhs, bool proper = true)
            => proper ? Data.IsProperSupersetOf(rhs.Data) : Data.IsSubsetOf(rhs.Data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to union/param>
        [MethodImpl(Inline)]   
        public ValueSet<T> Union(ValueSet<T> rhs)
        {
            var result = hashset(Data);
            result.UnionWith(rhs.Data);
            return result;
        }

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set with which to intersect</param>
        [MethodImpl(Inline)]   
        public ValueSet<T> Intersect(ValueSet<T> rhs)
        {
            var result = hashset(Data);
            result.IntersectWith(rhs.Data);
            return result;
        }

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current set and a specified set 
        /// and returns a new set that embodies this result
        /// </summary>
        /// <param name="rhs">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        [MethodImpl(Inline)]   
        public ValueSet<T> Difference(ValueSet<T> rhs, bool symmetric = false)
        {
            var result = hashset(Data);
            if(symmetric)
                result.SymmetricExceptWith(rhs.Data);
            else
                result.ExceptWith(rhs.Data);
            return result;
        }
    
        /// <summary>
        /// Determine whether the current set and a specified set have a nonemtpy intersection
        /// </summary>
        /// <param name="rhs">The set to compare</param>
        [MethodImpl(Inline)]   
        public bool Intersects(ValueSet<T> rhs)
            => Data.Overlaps(rhs.Data);

        static IEqualityComparer<HashSet<T>> Comparer 
            => HashSet<T>.CreateSetComparer(); 

        [MethodImpl(Inline)]   
        public bool Equals(ValueSet<T> src)
            => Comparer.Equals(Data, src.Data);

        public override bool Equals(object obj)
            => obj is ValueSet<T> x && Equals(x);

        public override int GetHashCode()
            => Data.GetHashCode();
        
        [MethodImpl(Inline)]   
        static HashSet<T> hashset(IEnumerable<T> members)
            => new HashSet<T>(members);
    }
}