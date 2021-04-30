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

    using static Part;
    using static memory;
    using static Rules;

    [ApiHost]
    public readonly struct Time
    {
        [Op]
        public static Outcome parse(string src, out Timestamp dst)
        {
            var outcome = Outcome.Empty;
            dst = Timestamp.Zero;
            var dash = text.index(src, Chars.Dash);
            if(dash == NotFound)
                return (false, "Date separator not found");

            var date = dash - 4;
            if(date < 0)
                return (false, $"The date index {date} is negative");

            var dot = text.index(src,Chars.Dot);
            if(dot == NotFound)
                return (false, "Time separator not found");

            var time = dot + 1;
            if(time <= date)
                return (false, $"The time separator index {time} is invalid");

            var seg0 = text.slice(src, date, 10).Split(Chars.Dash);
            if(seg0.Length != 3)
                return (false, $"The date segment has {seg0.Length} segments and should have 3");

            var seg1 = text.slice(src, time + 1).Split(Chars.Dot);

            if(seg1.Length != 4)
                return (false, $"The time segment has {seg1.Length} segments and should have 4");

            var fffBounds = bounded(0,999);
            if(!Numeric.parse(skip(seg0,0), out int yyyy))
                return (false, "Attempt to parse year failed");
            if(!Numeric.parse(skip(seg0,1), out int MM))
                return (false, "Attempt to parse month failed");
            if(!Numeric.parse(skip(seg0,2), out int dd))
                return (false, "Attempt to parse day failed");
            if(!Numeric.parse(skip(seg1,0), out int HH))
                return (false, "Attempt to parse hour failed");
            if(!Numeric.parse(skip(seg1,1), out int mm))
                return (false, "Attempt to parse minutes failed");
            if(!Numeric.parse(skip(seg1,2), out int ss))
                return (false, "Attempt to parse seconds failed");
            if(!Rules.parse(skip(seg1,3), fffBounds, out int fff, out outcome))
                return outcome;

            dst =  new DateTime(yyyy,MM,dd,HH, mm, ss, fff);

            return true;
        }

        //"yyyy-MM-dd.HH.mm.ss.fff";

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
        /// Returns the <see cref="Date"/> part of the supplied <see cref="DateTime"/>
        /// </summary>
        /// <param name="d">The subject</param>
        [MethodImpl(Inline), Op]
        public static Date date(DateTime d)
            => new Date(d.Year, d.Month, d.Day);

        [MethodImpl(Inline), Op]
        public static uint key(Date d)
            => (uint)d.Year * 1000 + (uint)d.Month * 10 + (uint)d.Day;

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
            => Duration.init(sw.ElapsedTicks);

        public static Date[] partition(in ClosedInterval<Date> src, uint width)
        {
            var points = root.list<Date>(new Date[]{src.Min});
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
        public static string lexical(DateTime t, TimeResolution accuracy = TimeResolution.Ms)
        {
            var format = String.Empty;
            var date = t.ToString("yyyy-MM-dd");
            var hour = t.Hour.ToString().PadLeft(2, '0');
            var minute = t.Minute.ToString().PadLeft(2, '0');
            var second = t.Second.ToString().PadLeft(2, '0');
            var ms = t.Millisecond.ToString().PadLeft(3, '0');
            switch (accuracy)
            {
                case TimeResolution.Date:
                    format = date;
                    break;
                case TimeResolution.Hour:
                    format = String.Format("{0} {1}:00:00.000", date, hour);
                    break;
                case TimeResolution.Minute:
                    format = String.Format("{0} {1}:{2}:00.000", date, hour, minute);
                    break;
                case TimeResolution.Second:
                    format = String.Format("{0} {1}:{2}:{3}.000", date, hour, minute, second);
                    break;
                case TimeResolution.Ms:
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

        [Op]
        public static Span<ushort> parts(DateTime x, TimeResolution resolution = TimeResolution.Ms)
        {
            switch (resolution)
            {
                case TimeResolution.Date:
                    return array((ushort)x.Year, (ushort)x.Month, (ushort)x.Day);
                case TimeResolution.Hour:
                    return array((ushort)x.Year, (ushort)x.Month, (ushort)x.Day, (ushort)x.Hour);
                case TimeResolution.Minute:
                    return array((ushort)x.Year, (ushort)x.Month, (ushort)x.Day, (ushort)x.Hour, (ushort)x.Minute);
                case TimeResolution.Second:
                    return array((ushort)x.Year, (ushort)x.Month, (ushort)x.Day, (ushort)x.Hour, (ushort)x.Minute, (ushort)x.Second);
                default:
                    return array((ushort)x.Year, (ushort)x.Month, (ushort)x.Day, (ushort)x.Hour, (ushort)x.Minute, (ushort)x.Second, (ushort)x.Millisecond);
            }
        }
    }
}