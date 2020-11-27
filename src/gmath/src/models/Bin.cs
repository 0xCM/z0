//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Histograms;

    /// <summary>
    /// Represents one or more occurrence of a value within an interval
    /// </summary>
    /// <typeparam name="T">The value domain</typeparam>
    public struct Bin<T>
        where T : unmanaged
    {
        internal int Counter;

        public ClosedInterval<T> Domain {get;}

        [MethodImpl(Inline)]
        public Bin(in ClosedInterval<T> domain, uint count = 0)
        {
            Domain = domain;
            Counter = (int)count;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Counter;
        }

        public string Format()
            => $"{Domain}: {Count}";

        [MethodImpl(Inline)]
        public Bin<T> Increment()
            => api.next(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static Bin<T> operator ++(in Bin<T> src)
            => src.Increment();
    }
}