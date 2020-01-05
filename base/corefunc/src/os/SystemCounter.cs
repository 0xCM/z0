//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// A stopwatch-like type in the form of a struct rather than a class
    /// </summary>
    public struct SystemCounter
    {
        long total;

        long started;

        public static implicit operator long(SystemCounter counter)
        {
            counter.Stop();
            var counted = counter.Count;
            counter.Start();
            return counted;
        }

        public static implicit operator TimeSpan(SystemCounter counter)
        {
            counter.Stop();
            var time =  TimeSpan.FromTicks(counter.Count);
            counter.Start();
            return time;
        }

        [MethodImpl(Inline)]
        public static SystemCounter New(bool start = false)
        {
            var counter = default(SystemCounter);
            if(start)
                counter.Start();
            return counter;
        }        

        [MethodImpl(Inline)]
        public void Start()
        {
            OS.GetCount(ref started);
        }

        [MethodImpl(Inline)]
        public TimeSpan Stop()
        {
            var stopped = 0L;
            OS.GetCount(ref stopped);
            total += (stopped - started);
            return Time;
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