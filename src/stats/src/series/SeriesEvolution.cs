//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SeriesEvolution<T>
        where T : unmanaged
    {
        public ulong[] Seed {get;}

        public Interval<T> Domain {get;}

        public SeriesTerm<T> FirstTerm {get;}

        public SeriesTerm<T> FinalTerm {get;}

        public Duration Time {get;}

        [MethodImpl(Inline)]
        public SeriesEvolution(ulong[] seed, in Interval<T> domain, in SeriesTerm<T> first, in SeriesTerm<T> final, in Duration time)
        {
            Seed = seed;
            Domain = domain;
            FirstTerm = first;
            FinalTerm = final;
            Time = time;
        }
    }
}