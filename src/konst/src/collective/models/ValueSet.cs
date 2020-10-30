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
    public readonly struct ValueSet<T> : IValueSet<ValueSet<T>,T>, IEquatable<ValueSet<T>>
        where T : struct
    {
        internal readonly HashSet<T> Data;

        [MethodImpl(Inline)]
        public ValueSet(IEnumerable<T> src)
            => Data = z.hashset(src);

        [MethodImpl(Inline)]
        public ValueSet(HashSet<T> src)
            => Data = src;

        [MethodImpl(Inline)]
        public ValueSet(T[] src)
            => Data = z.hashset(src);

        public IEnumerable<T> Next()
            => Data;


        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Count;
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
        public bool IsSubset(in ValueSet<T> rhs, bool proper = true)
            => proper ? Data.IsProperSubsetOf(rhs.Data) : Data.IsSubsetOf(rhs.Data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="rhs">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]
        public bool IsSuperset(in ValueSet<T> rhs, bool proper)
            => proper ? Data.IsProperSupersetOf(rhs.Data) : Data.IsSubsetOf(rhs.Data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set with which to union/param>
        [MethodImpl(Inline)]
        public ValueSet<T> Union(in ValueSet<T> src)
        {
            Data.UnionWith(src.Data);
            return this;
        }

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set with which to intersect</param>
        [MethodImpl(Inline)]
        public ValueSet<T> Intersect(in ValueSet<T> src)
        {
            Data.IntersectWith(src.Data);
            return this;
        }

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current set and a specified set
        /// and returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        [MethodImpl(Inline)]
        public ValueSet<T> Difference(ValueSet<T> src, bool symmetric)
        {
            if(symmetric)
                Data.SymmetricExceptWith(src.Data);
            else
                Data.ExceptWith(src.Data);

            return this;
        }

        /// <summary>
        /// Determine whether the current set and a specified set have a nonemtpy intersection
        /// </summary>
        /// <param name="rhs">The set to compare</param>
        [MethodImpl(Inline)]
        public bool Intersects(in ValueSet<T> rhs)
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

        bool IValueSet<ValueSet<T>,T>.Contains(in T candidate)
            => Contains(candidate);

        ValueSet<T> IValueSet<ValueSet<T>,T>.Union(in ValueSet<T> rhs)
            => Union(rhs);

        ValueSet<T> IValueSet<ValueSet<T>,T>.Intersect(in ValueSet<T> rhs)
            => Intersect(rhs);

        ValueSet<T> IValueSet<ValueSet<T>,T>.Difference(in ValueSet<T> rhs, bool symmetric)
            => Difference(rhs,symmetric);

        bool IValueSet<ValueSet<T>,T>.IsSubset(in ValueSet<T> rhs, bool proper)
            => IsSubset(rhs,proper);

        bool IValueSet<ValueSet<T>,T>.IsSuperset(in ValueSet<T> rhs, bool proper)
            => IsSuperset(rhs,proper);


        [MethodImpl(Inline)]
        public static implicit operator ValueSet<T>(HashSet<T> src)
            => new ValueSet<T>(src);

        [MethodImpl(Inline)]
        public static ValueSet<T> operator +(ValueSet<T> a, ValueSet<T> b)
            => a.Union(b);

        [MethodImpl(Inline)]
        public static ValueSet<T> operator -(ValueSet<T> a, ValueSet<T> b)
            => a.Difference(b,false);

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
    }
}