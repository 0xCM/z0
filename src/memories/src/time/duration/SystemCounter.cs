//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// A stopwatch-like type in the form of a struct rather than a class
    /// </summary>
    public struct SystemCounter
    {
        long total;

        long started;

        bool running;

        [MethodImpl(Inline)]
        public static SystemCounter Create(bool start = false)
        {
            var counter = default(SystemCounter);
            if(start)
                counter.Start();
            return counter;
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

        [MethodImpl(Inline)]
        public void Start()
        {
            running = true;
            SystemCounters.GetCount(ref started);
        }

        [MethodImpl(Inline)]
        public Duration Stop()
        {
            running = false;
            var stopped = 0L;
            SystemCounters.GetCount(ref stopped);
            total += (stopped - started);
            return total;
        }

        [MethodImpl(Inline)]
        readonly long Measure()
        {
            var current = 0L;
            SystemCounters.GetCount(ref current);
            return total + (current - started);                
        }

        /// <summary>
        /// Measures the accumulated duration
        /// </summary>
        public readonly Duration Elapsed
        {
            [MethodImpl(Inline)]
            get => running ? Measure() : total;
        }

        /// <summary>
        /// Clears the counter's state
        /// </summary>
        [MethodImpl(Inline)]
        public void Reset()
        {
            total = 0;
            started = 0;
        }

        /// <summary>
        /// Gets the total number of timer ticks
        /// </summary>
        public readonly long Count
        {
            [MethodImpl(Inline)]
            get => total;
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