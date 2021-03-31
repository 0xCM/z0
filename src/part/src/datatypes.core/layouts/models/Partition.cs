//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a partition over an interval
    /// </summary>
    public readonly struct Partition<T>
        where T : unmanaged
    {
        /// <summary>
        /// The range of the defining elements
        /// </summary>
        public ClosedInterval<T> Range {get;}

        readonly Index<PartitionSegment<T>> Data;

        [MethodImpl(Inline)]
        public Partition(T min, T max, params PartitionSegment<T>[] segs)
        {
            Range = (min,max);
            Data = segs;
        }

        public ReadOnlySpan<PartitionSegment<T>> Segments
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }
    }
}