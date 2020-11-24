//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

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

        /// <summary>
        /// Returns a mutable reference to an index-identified sequence element
        /// </summary>
        /// <param name="index">The zero-based sequence index</param>
        [MethodImpl(Inline)]
        public ref Pair<T> Select(int index)
            => ref z.seek(Data, (uint)index);

        /// <summary>
        /// Returns a mutable reference to an index-identified sequence element
        /// </summary>
        /// <param name="index">The zero-based sequence index</param>
        public ref Pair<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Select(index);
        }

        /// <summary>
        /// Specifies the number of elements in the sequence
        /// </summary>
        public int PointCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
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
    }
}