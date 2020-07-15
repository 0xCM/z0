//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public struct Histogram<T>
        where T : unmanaged
    {
        public readonly ClosedInterval<T> Domain;

        public readonly T Grain;

        public readonly T[] Partitions;

        internal readonly uint[] Counts;

        [MethodImpl(Inline)]
        internal Histogram(in ClosedInterval<T> domain, T grain,  T[] partitions, uint[] counts)
        {
            Domain = domain;
            Grain = grain;
            Partitions = partitions;
            Counts = counts;
        }
    }
}