//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static Z0.Seed;

    using Z0;

    public partial struct Date
    {
        /// <summary>
        /// Defines a <see cref="DateRange"/> bounded below by <paramref name="MinDate"/>
        /// and above by <paramref name="MaxDate"/>
        /// </summary>
        /// <param name="MinDate">The range minimum</param>
        /// <param name="MaxDate">The range maximum</param>
        [MethodImpl(Inline)]
        public static DateRange Between(Date MinDate, Date MaxDate)
            => new DateRange(MinDate, MaxDate);

        [MethodImpl(Inline)]
        public static Date Jan(int Year, byte Day = 1)
            => new Date(Year, 1, Day);

        [MethodImpl(Inline)]
        public static Date Feb(int Year, byte Day = 1)
            => new Date(Year, 2, Day);

        [MethodImpl(Inline)]
        public static Date Mar(int Year, byte Day = 1)
            => new Date(Year, 3, Day);

        [MethodImpl(Inline)]
        public static Date Apr(int Year, byte Day = 1)
            => new Date(Year, 4, Day);

        [MethodImpl(Inline)]
        public static Date May(int Year, byte Day = 1)
            => new Date(Year, 5, Day);

        [MethodImpl(Inline)]
        public static Date Jun(int Year, byte Day = 1)
            => new Date(Year, 6, Day);

        [MethodImpl(Inline)]
        public static Date Jul(int Year, byte Day = 1)
            => new Date(Year, 7, Day);

        [MethodImpl(Inline)]
        public static Date Aug(int Year, byte Day = 1)
            => new Date(Year, 8, Day);

        [MethodImpl(Inline)]
        public static Date Sep(int Year, byte Day = 1)
            => new Date(Year, 9, Day);

        [MethodImpl(Inline)]
        public static Date Oct(int Year, byte Day = 1)
            => new Date(Year, 10, Day);

        [MethodImpl(Inline)]
        public static Date Nov(int Year, byte Day = 1)
            => new Date(Year, 11, Day);

        [MethodImpl(Inline)]
        public static Date Dec(int Year, byte Day = 1)
            => new Date(Year, 12, Day);

        [MethodImpl(Inline)]
        public Date EndOfMonth()
              => new Date(Year, Month, this.AddMonths(1).AddDays(-1).Day);

        [MethodImpl(Inline)]
        public Date FirstOfMonth()
            => FirstDayOfMonth;

        [MethodImpl(Inline)]
        public DateRange To(Date MaxDate)
            => new DateRange(this, MaxDate);

        [MethodImpl(Inline)]
        public DateRange ToEndOfMonth()
            => new DateRange(this, this.EndOfMonth());

        [MethodImpl(Inline)]
        public DateRange FromFirstOfMonth()
            => new DateRange(FirstOfMonth(), this);

        [MethodImpl(Inline)]
        public DateRange FromFirstDayOfLastMonth()
            => new DateRange(this.AddMonths(-1).FirstOfMonth(), this);

        [MethodImpl(Inline)]
        public DateRange ToLastDayOfNextMonth()
            => new DateRange(this, this.AddMonths(1).EndOfMonth());

        [MethodImpl(Inline)]
        public bool IsBetween(Date MinDate, Date MaxDate)
            => this >= MinDate && this <= MaxDate;

        [MethodImpl(Inline)]
        public bool IsIn(DateRange Range)
            => IsBetween(Range.Min, Range.Max);

        public static IEnumerable<Date> Parse(string first, string second, params string[] more)
        {
            yield return Parse(first);
            yield return Parse(second);
            foreach (var next in more)
                yield return Parse(next);
        }

        public static IEnumerable<Date> Days(Date min, Date max)
        {
            var current = min;
            while (current <= max)
            {
                yield return current;
                current = current.AddDays(1);
            }
        }

        public static IEnumerable<Date> Years(int min, int max)
        {
            var current = new Date(min, 1, 1);
            var maxYear = new Date(max, 1, 1);
            while (current <= maxYear)
            {
                yield return current;
                current = current.AddYears(1);
            }
        }

        public static implicit operator Date(string x) 
            => Date.Parse(x);

        [MethodImpl(Inline)]
        public DateTime ToDateTime() 
            => new Date(Year, Month, Day);

        public Date FirstDayOfMonth
        {
            [MethodImpl(Inline)]
            get => new Date(Year, Month, 1);
        }

        public Date LastDayOfMonth
        {
            [MethodImpl(Inline)]
            get => new Date(Year, Month + 1, 1).AddDays(-1);
        }

        /// <summary>
        /// Renders a <see cref="Date"/> to the form YYYY-MM-DD
        /// </summary>
        public string ToLexicalString()
            => this.ToString("yyyy-MM-dd");

        public Date(string x)
        {
            var _parsed = Date.Parse(x);
            _dayNumber = DateToDayNumber(_parsed.Year, _parsed.Month, _parsed.Day);
        }
    }
}