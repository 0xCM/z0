//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    /// <summary>
    /// Captures a pair sequence
    /// </summary>
    /// <typeparam name="T">The sequence element type</typeparam>
    public readonly ref struct Pairs<T>
    {
        /// <summary>
        /// The captured sequence
        /// </summary>
        public readonly Span<Pair<T>> Data;

        [MethodImpl(Inline)]
        public Pairs(Span<Pair<T>> data)
            => Data = data;

        public Span<Pair<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<Pair<T>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        /// <summary>
        /// Returns a mutable reference to an index-identified sequence element
        /// </summary>
        /// <param name="index">The zero-based sequence index</param>
        public ref Pair<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        /// <summary>
        /// Returns a mutable reference to an index-identified sequence element
        /// </summary>
        /// <param name="index">The zero-based sequence index</param>
        public ref Pair<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public ref Pair<T> First
        {
            [MethodImpl(Inline)]
            get => ref first(Data);
        }

        /// <summary>
        /// Specifies the number of elements in the sequence
        /// </summary>
        public uint PointCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        /// <summary>
        /// Lifts sequence content into the LINQ monad
        /// </summary>
        public IEnumerable<Pair<T>> Enumerate()
            => Data.ToEnumerable();

        [MethodImpl(Inline)]
        public static implicit operator Pairs<T>(Span<Pair<T>> src)
            => new Pairs<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Pairs<T>(Pair<T>[] src)
            => new Pairs<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Pairings<T,T>(Pairs<T> src)
            => new Pairings<T,T>(memory.recover<Pair<T>,Paired<T,T>>(src.Data));
    }
}