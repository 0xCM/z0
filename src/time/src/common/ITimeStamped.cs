//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public interface ITimeStamped : IFacet<DateTime>
    {
        DateTime Timestamp {get;}

        string IFacet.FacetName => nameof(Timestamp);

        DateTime IFacet<DateTime>.FacetValue => Timestamp;
    }

    public readonly struct TimeStamped : ITimeStamped
    {
        [MethodImpl(Inline)]
        public static TimeStamped Now()
            => new TimeStamped(DateTime.Now);

        [MethodImpl(Inline)]
        public static TimeStamped Define(DateTime time)
            => new TimeStamped(time);
        
        [MethodImpl(Inline)]
        TimeStamped(DateTime time)
        {
            this.Timestamp = time;
        }

        public DateTime Timestamp {get;}

    }
}