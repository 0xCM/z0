//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Describes the relationship between hardware ticks and measured time
    /// </summary>
    public readonly struct TimerTicks
    {
        static readonly TimerTicks The = new TimerTicks(0);
        
        public static ref readonly TimerTicks Info
        {
            [MethodImpl(Inline)]
            get => ref The;
        }

        /// <summary>
        /// Computes the number of milliseconds accounted for by a specified number of ticks
        /// </summary>
        /// <param name="ticks">The tick count</param>
        [MethodImpl(Inline)]
        public static double ToMs(long ticks)
            => Info.ms(ticks);

        /// <summary>
        /// Computes the number of nanoseconds accounted for by a specified number of ticks
        /// </summary>
        /// <param name="ticks">The tick count</param>
        [MethodImpl(Inline)]
        public static ulong ToNs(long ticks)
            => Info.ns(ticks);

        [MethodImpl(Inline)]
        TimerTicks(int dummy)
        {
            TicksPerSecond = (ulong)Stopwatch.Frequency;
            NsPerTick = 1_000_000_000/TicksPerSecond;
            TicksPerMs  = (double)TicksPerSecond/1000.0;
        }

        /// <summary>
        /// The number of ticks per second
        /// </summary>
        readonly ulong TicksPerSecond;

        /// <summary>
        /// The number of nanoseconds that elapse during a timer tick
        /// </summary>
        readonly ulong NsPerTick;

        /// <summary>
        /// The number of ticks per second
        /// </summary>
        readonly double TicksPerMs;

        /// <summary>
        /// Computes the number of milliseconds accounted for by a specified number of ticks
        /// </summary>
        /// <param name="ticks">The tick count</param>
        [MethodImpl(Inline)]
        double ms(long ticks)
            => ((double)ticks)/TicksPerMs;

        [MethodImpl(Inline)]
        ulong ns(long ticks)
            => NsPerTick * (ulong)ticks;
    }
}