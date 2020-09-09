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
    using System.Collections.Generic;

    using static Konst;

    [ApiHost]
    public readonly struct Time
    {
        [MethodImpl(Inline), Op]
        public static DateRange range(Date min, Date max)
            => new DateRange(min,max);

        /// <summary>
        /// Determines whether the test value is within the range
        /// </summary>
        /// <param name="test">The date to test</param>
        [MethodImpl(Inline), Op]
        public static bool contains(in DateRange src, Date test)
            => test >= src.Min && test <= src.Max;

        /// <summary>
        /// Determines whether the test value is outside the range
        /// </summary>
        /// <param name="test">The date to test</param>
        [MethodImpl(Inline), Op]
        public static bool external(in DateRange src, Date test)
            => test < src.Min || test > src.Max;

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
        /// Captures a stopwatch duration
        /// </summary>
        /// <param name="sw">A running/stopped stopwatch</param>
        [MethodImpl(Inline), Op]
        public static Duration snapshot(Stopwatch sw)
            => Duration.Define(sw.ElapsedTicks);

        public static Date[] partition(in ClosedInterval<Date> src, uint width)
        {
            var points = z.list<Date>(new Date[]{src.Min});
            var last = src.Min;
            var finished = false;
            while (!finished)
            {
                var next = last.AddDays((int)width);
                if (next >= src.Max)
                {
                    points.Add(src.Max);
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

        /// <summary>
        /// Renders a string in a more rational manner than the default behavior
        /// </summary>
        /// <param name="t">The instant to render</param>
        /// <param name="accuracy">The accuracy with which to render the instant</param>
        [Op]
        public static string lexical(DateTime t, DateTimeAccuracy accuracy = DateTimeAccuracy.Millisecond)
        {
            var format = String.Empty;
            var date = t.ToString("yyyy-MM-dd");
            var hour = t.Hour.ToString().PadLeft(2, '0');
            var minute = t.Minute.ToString().PadLeft(2, '0');
            var second = t.Second.ToString().PadLeft(2, '0');
            var ms = t.Millisecond.ToString().PadLeft(3, '0');
            switch (accuracy)
            {
                case DateTimeAccuracy.Date:
                    format = date;
                    break;
                case DateTimeAccuracy.Hour:
                    format = String.Format("{0} {1}:00:00.000", date, hour);
                    break;
                case DateTimeAccuracy.Minute:
                    format = String.Format("{0} {1}:{2}:00.000", date, hour, minute);
                    break;
                case DateTimeAccuracy.Second:
                    format = String.Format("{0} {1}:{2}:{3}.000", date, hour, minute, second);
                    break;
                case DateTimeAccuracy.Millisecond:
                    format = String.Format("{0} {1}:{2}:{3}.{4}", date, hour, minute, second, ms);
                    break;
                default:
                    format = EmptyString;
                    break;
            }
            return format;
        }

        /// <summary>
        /// The days that comprise the range
        /// </summary>
        [Op]
        public static IEnumerable<Date> dates(DateRange period)
        {
            foreach (var i in Enumerable.Range(0, period.TotalDays + 1))
                yield return period.Min.AddDays(i);
        }

        [Op]
        public static IEnumerable<DateRange> partition(DateRange period, int MaxLen)
            => from dates in period.GetDates().Partition(MaxLen)
               let min = dates.First()
               let max = dates.Last()
               select min.To(max);

    }
}