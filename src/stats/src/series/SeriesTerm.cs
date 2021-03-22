//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct SeriesTerm<T>
        where T : unmanaged
    {
        public SeriesTerm(long index, T observation)
        {
            Index = index;
            Observed = observation;
        }

        public readonly long Index;

        public readonly T Observed;

        public string Format()
            => $"({Index}, {Observed})";

        public override string ToString()
            => Format();
    }
}