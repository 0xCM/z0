//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Encloses a finite set of structural values
    /// </summary>
    public readonly struct DataSet<T> : ISet<DataSet<T>,T>, IEquatable<DataSet<T>>
    {
        internal readonly HashSet<T> Data;

        [MethodImpl(Inline)]
        public DataSet(IEnumerable<T> src)
            => Data = root.hashset(src);

        [MethodImpl(Inline)]
        public DataSet(HashSet<T> src)
            => Data = src;

        [MethodImpl(Inline)]
        public DataSet(T[] src)
            => Data = root.hashset(src);

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
        public bool IsMember(object candidate)
            => candidate is T ? Contains((T)candidate) :false;

        public IEnumerable<T> Content
            => Data;

        /// <summary>
        /// Determines whether the current set is a subset of a specified set.
        /// </summary>
        /// <param name="src">The candidate superset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]
        public bool IsSubset(in DataSet<T> src, bool proper = true)
            => proper ? Data.IsProperSubsetOf(src.Data) : Data.IsSubsetOf(src.Data);

        [MethodImpl(Inline)]
        public bool IsSubset(DataSet<T> src, bool proper)
            => proper ? Data.IsProperSubsetOf(src.Data) : Data.IsSubsetOf(src.Data);

        /// <summary>
        /// Determines whether the current set is a superset of a specified set.
        /// </summary>
        /// <param name="src">The candidate subset</param>
        /// <param name="proper">Specifies whether only proper subsets are considered "subsets"</param>
        [MethodImpl(Inline)]
        public bool IsSuperset(in DataSet<T> src, bool proper)
            => proper ? Data.IsProperSupersetOf(src.Data) : Data.IsSupersetOf(src.Data);

        [MethodImpl(Inline)]
        public bool IsSuperset(DataSet<T> src, bool proper)
             => proper ? Data.IsProperSupersetOf(src.Data) : Data.IsSupersetOf(src.Data);

        /// <summary>
        /// Calculates the union between the current set and a specified set and returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set with which to union/param>
        [MethodImpl(Inline)]
        public DataSet<T> Union(in DataSet<T> src)
        {
            Data.UnionWith(src.Data);
            return this;
        }

        [MethodImpl(Inline)]
        public DataSet<T> Union(DataSet<T> src)
        {
            Data.UnionWith(src.Data);
            return this;
        }

        /// <summary>
        /// Determine whether the current set and a specified set have a nonemtpy intersection
        /// </summary>
        /// <param name="rhs">The set to compare</param>
        [MethodImpl(Inline)]
        public bool Intersects(in DataSet<T> rhs)
            => Data.Overlaps(rhs.Data);

        /// <summary>
        /// Calculates the intersection between the current set and a specified set and
        /// returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set with which to intersect</param>
        [MethodImpl(Inline)]
        public DataSet<T> Intersect(in DataSet<T> src)
        {
            Data.IntersectWith(src.Data);
            return this;
        }

        [MethodImpl(Inline)]
        public DataSet<T> Intersect(DataSet<T> src)
        {
            Data.IntersectWith(src.Data);
            return this;
        }

        [MethodImpl(Inline)]
        public bool Contains(in T candidate)
            => Data.Contains(candidate);

        [MethodImpl(Inline)]
        public bool Contains(T candidate)
            => Data.Contains(candidate);

        /// <summary>
        /// Calculates the set difference, or symmetric difference, between the current set and a specified set
        /// and returns a new set that embodies this result
        /// </summary>
        /// <param name="src">The set that should be differenced</param>
        /// <remarks>See https://en.wikipedia.org/wiki/Symmetric_difference</remarks>
        [MethodImpl(Inline)]
        public DataSet<T> Difference(DataSet<T> src, bool symmetric)
        {
            if(symmetric)
                Data.SymmetricExceptWith(src.Data);
            else
                Data.ExceptWith(src.Data);

            return this;
        }

         [MethodImpl(Inline)]
         public DataSet<T> Difference(in DataSet<T> src, bool symmetric)
         {
            if(symmetric)
                Data.SymmetricExceptWith(src.Data);
            else
                Data.ExceptWith(src.Data);

            return this;
        }

        static IEqualityComparer<HashSet<T>> Comparer
            => HashSet<T>.CreateSetComparer();

        [MethodImpl(Inline)]
        public bool Equals(DataSet<T> src)
            => Comparer.Equals(Data, src.Data);

        public override bool Equals(object obj)
            => obj is DataSet<T> x && Equals(x);

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public static implicit operator DataSet<T>(HashSet<T> src)
            => new DataSet<T>(src);

        [MethodImpl(Inline)]
        public static DataSet<T> operator +(DataSet<T> a, DataSet<T> b)
            => a.Union(b);

        [MethodImpl(Inline)]
        public static DataSet<T> operator -(DataSet<T> a, DataSet<T> b)
            => a.Difference(b,false);

        [MethodImpl(Inline)]
        public static DataSet<T> operator *(DataSet<T> a, DataSet<T> b)
            => a.Intersect(b);

        [MethodImpl(Inline)]
        public static bool operator <(DataSet<T> a, DataSet<T> b)
            => b.IsSuperset(a, true);

        [MethodImpl(Inline)]
        public static bool operator >(DataSet<T> a, DataSet<T> b)
            => a.IsSuperset(b, true);

        [MethodImpl(Inline)]
        public static bool operator <=(DataSet<T> a, DataSet<T> b)
            => b.IsSuperset(a, false);

        [MethodImpl(Inline)]
        public static bool operator >=(DataSet<T> a, DataSet<T> b)
            => a.IsSuperset(b, false);

        public static bool operator <(T a, DataSet<T> b)
            => b.Contains(a);

        [MethodImpl(Inline)]
        public static bool operator >(T a, DataSet<T> b)
            => b.Contains(a) && b.Count == 1;

        [MethodImpl(Inline)]
        public static bool operator ==(DataSet<T> a, DataSet<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(DataSet<T> a, DataSet<T> b)
            => !a.Equals(b);
    }
}