//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Histograms;

    public struct Histogram<T>
        where T : unmanaged, IComparable<T>
    {
        public ClosedInterval<T> Domain {get;}

        public T Grain {get;}

        public T[] Partitions {get;}

        internal readonly uint[] Counts;

        [MethodImpl(Inline)]
        internal Histogram(in ClosedInterval<T> domain, T grain,  T[] partitions, uint[] counts)
        {
            Domain = domain;
            Grain = grain;
            Partitions = partitions;
            Counts = counts;
        }

        [MethodImpl(Inline)]
        public void Deposit(ReadOnlySpan<T> points)
            => api.deposit(points,this);

        [MethodImpl(Inline)]
        public uint BinCount(uint index)
            => api.count(this, index);
    }
}