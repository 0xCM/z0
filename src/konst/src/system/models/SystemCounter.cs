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

    /// <summary>
    /// A stopwatch-like type in the form of a struct rather than a class
    /// </summary>
    public struct SystemCounter
    {
        long Total;

        long Started;

        bool Running;

        [MethodImpl(Inline)]
        public void Start()
        {
            Running = true;
            SystemCounters.count(ref Started);
        }

        [MethodImpl(Inline)]
        public Duration Stop()
        {
            Running = false;
            var stopped = 0L;
            SystemCounters.count(ref stopped);
            Total += (stopped - Started);
            return Total;
        }

        [MethodImpl(Inline)]
        readonly long Measure()
        {
            var current = 0L;
            SystemCounters.count(ref current);
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
        /// Resets and restarts the clock
        /// </summary>
        [MethodImpl(Inline)]
        public void Restart()
        {
            Reset();
            Start();
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
    }
}