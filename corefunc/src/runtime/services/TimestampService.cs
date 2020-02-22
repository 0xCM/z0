//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Timers;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    public readonly struct TimestampService
    {
        [MethodImpl(Inline)]
        public static ulong Timestamp(uint ServerId = 0)        
            => (ulong)(now().Ticks - TimeOrigin.Ticks);                

        static ulong NsPerTimerTick => 1_000_000_000/(ulong)Stopwatch.Frequency;

        static DateTime TimeOrigin => new DateTime(2019,01,01);        
    }
}