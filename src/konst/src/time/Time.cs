//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Diagnostics;

    using static Konst;

    [ApiHost]
    public readonly partial struct Time
    {
        /// <summary>
        /// Right now
        /// </summary>
        [MethodImpl(Inline), Op]   
        public static DateTime now()
            => DateTime.Now;

        [MethodImpl(Inline), Op]   
        public static TimerTicks ticks()
            => new TimerTicks();

        /// <summary>
        /// Creates a <see cref='Timestamp'/> populated with the system-reported time
        /// </summary>
        [MethodImpl(Inline), Op]   
        public static Timestamp timestamp()
            => new Timestamp((ulong)DateTime.Now.Ticks);

        /// <summary>
        /// Creates a new stopwatch and optionally start it
        /// </summary>
        /// <param name="start">Whether to start the new stopwatch</param>
        [MethodImpl(Inline), Op]   
        public static Stopwatch stopwatch(bool start = true) 
            => start ? Stopwatch.StartNew() : new Stopwatch();

        /// <summary>
        /// Allocates and optionally starts a <see cref='SystemCounter'>
        /// </summary>
        /// <param name="start">Whether to start the count</param>
        [MethodImpl(Inline), Op]   
        public static SystemCounter counter(bool start = false) 
            => SystemCounters.counter(start);

        /// <summary>
        /// Initializes a <see cref='SystemCounters'/> structure with the frequency reported by the OS
        /// </summary>
        [MethodImpl(Inline), Op]   
        public static SystemCounters counters()
            => SystemCounters.init();

        /// <summary>
        /// Initializes a <see cref='SystemCounters'/> structure with a specified frequency
        /// </summary>
        /// <param name="f">The counter frequency</param>
        [MethodImpl(Inline), Op]   
        public static SystemCounters counters(ulong f)
            => SystemCounters.init((long)f);

        public static Date[] partition(in ClosedInterval<Date> src, uint width)
        {
            var points = z.list<Date>(new Date[]{src.Left});
            var last = src.Left;
            var finished = false;
            while (!finished)
            {
                var next = last.AddDays((int)width);
                if (next >= src.Right)
                {
                    points.Add(src.Right);
                    finished = true;
                }
                else
                {
                    points.Add(next);
                    last = next;
                }
            }

            return points.Array();
        }
    }
}