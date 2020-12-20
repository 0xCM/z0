//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    public readonly struct Partition<T>
        where T : unmanaged
    {
        /// <summary>
        /// The range of the defining elements
        /// </summary>
        public ClosedInterval<T> Range {get;}

        readonly Index<PartitionRange<T>> Data;

        [MethodImpl(Inline)]
        public Partition(T min, T max, params PartitionRange<T>[] parts)
        {
            Range = (min,max);
            Data = parts;
        }

        public ReadOnlySpan<PartitionRange<T>> Parts
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }
    }
}