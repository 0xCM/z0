//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Captures and explores the relationship between hardware ticks and measured time
    /// </summary>
    public readonly struct TimerTicks
    {
        readonly ulong TicksPerSecond;

        public static TimerTicks Default 
        {
            [MethodImpl(Inline)]
            get => new TimerTicks((ulong)Stopwatch.Frequency);
        }

        /// <summary>
        /// Computes the number of milliseconds accounted for by a specified number of ticks
        /// </summary>
        /// <param name="ticks">The tick count</param>
        [MethodImpl(Inline)]
        public static double ms(long ticks)
            => ((double)ticks)/Default.TicksPerMs;

        /// <summary>
        /// Computes the number of nanoseconds accounted for by a specified number of ticks
        /// </summary>
        /// <param name="ticks">The tick count</param>
        [MethodImpl(Inline)]
        public static ulong ns(long ticks)
            => Default.NsPerTick * (ulong)ticks;        
        
        [MethodImpl(Inline)]        
        internal TimerTicks(ulong frequency)
            => TicksPerSecond = frequency;
        
        /// <summary>
        /// The number of nanoseconds that elapse during a timer tick
        /// </summary>
        public ulong NsPerTick 
        {
            [MethodImpl(Inline)]
            get => 1_000_000_000/TicksPerSecond;
        }

        /// <summary>
        /// The number of ticks per second
        /// </summary>
        public double TicksPerMs 
        {
            [MethodImpl(Inline)]
            get => (double)TicksPerSecond/1000.0;
        }    
    }
}