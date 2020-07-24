//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// A stopwatch-like type in the form of a struct rather than a class
    /// </summary>
    public struct SystemCounter
    {
        internal long Total;

        internal long Started;

        internal bool Running;

        [MethodImpl(Inline)]
        public static implicit operator long(SystemCounter counter)
        {
            counter.Stop();
            var counted = counter.Count;
            counter.Start();
            return counted;
        }

        [MethodImpl(Inline)]
        public static implicit operator TimeSpan(SystemCounter counter)
        {
            counter.Stop();
            var time =  TimeSpan.FromTicks(counter.Count);
            counter.Start();
            return time;
        }

        [MethodImpl(Inline)]
        public static implicit operator Duration(SystemCounter counter)
        {
            counter.Stop();
            var time =  TimeSpan.FromTicks(counter.Count);
            counter.Start();
            return time;
        }

        [MethodImpl(Inline)]
        public void Start()
        {
            Running = true;
            SystemCounters.GetCount(ref Started);
        }

        [MethodImpl(Inline)]
        public Duration Stop()
        {
            Running = false;
            var stopped = 0L;
            SystemCounters.GetCount(ref stopped);
            Total += (stopped - Started);
            return Total;
        }

        [MethodImpl(Inline)]
        readonly long Measure()
        {
            var current = 0L;
            SystemCounters.GetCount(ref current);
            return Total + (current - Started);                
        }

        /// <summary>
        /// Measures the accumulated duration
        /// </summary>
        public readonly Duration Elapsed
        {
            [MethodImpl(Inline)]
            get => Running ? Measure() : Total;
        }

        /// <summary>
        /// Clears the counter's state
        /// </summary>
        [MethodImpl(Inline)]
        public void Reset()
        {
            Total = 0;
            Started = 0;
        }

        /// <summary>
        /// Gets the total number of timer ticks
        /// </summary>
        public readonly long Count
        {
            [MethodImpl(Inline)]
            get => Total;
        }

        /// <summary>
        /// Gets the elapsed time implied by the tick count
        /// </summary>
        public readonly TimeSpan Time
        {
            [MethodImpl(Inline)]
            get => TimeSpan.FromTicks(Count);
        }         
    }
}