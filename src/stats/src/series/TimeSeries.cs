//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class TimeSeries<T> : ITimeSeries<T>
        where T : unmanaged
    {
        [MethodImpl]
        public TimeSeries(long Id, Interval<T> Domain, SeriesTerm<T> FirstTerm)
        {
            this.Id = Id;
            this.Domain = Domain;
            this.Observed = FirstTerm;
        }

        public void Witnessed(SeriesTerm<T> term)
            => Observed = term;

        public long Id {get;}

        /// <summary>
        /// Specifies the observation domain
        /// </summary>
        public Interval<T> Domain {get;}    

        public SeriesTerm<T> Observed {get; private set;}
 
        [MethodImpl]
        public TimeSeries<T> Snapshot()
            => new TimeSeries<T>(Id, Domain, Observed);
    }
}