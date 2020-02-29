//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>
    /// Captures the length of a time period predicated on timer ticks
    /// </summary>
    [
        ConversionProvider(typeof(DurationConverter)),
        UserType(TypeCodes.DurationId)
    ]
    public readonly struct Duration : IFormattable<Duration>, IEquatable<Duration>, IComparable<Duration>
    {
        /// <summary>
        /// The number of elapsed timer ticks that determines the period length
        /// </summary>
        public readonly long Ticks;

        public static Duration Zero => new Duration(0);
        
        [MethodImpl(Inline)]
        public static Duration Define(long ticks)
            => new Duration(ticks);

        [MethodImpl(Inline)]
        public static Duration Define(TimeSpan ts)
            => new Duration(ts.Ticks);

        [MethodImpl(Inline)]
        Duration(long ticks)
        {
            this.Ticks = ticks;
        }


        [MethodImpl(Inline)]
        public static implicit operator TimeSpan(Duration src)
            => src.TimeSpan;

        [MethodImpl(Inline)]
        public static implicit operator Duration(TimeSpan src)
            => new Duration(src.Ticks);

        [MethodImpl(Inline)]
        public static implicit operator Duration(long ticks)
            => Define(ticks);

        [MethodImpl(Inline)]
        public static Duration operator +(Duration a, Duration b)
            => new Duration(a.Ticks + b.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator +(Duration a, TimeSpan b)
            => new Duration(a.Ticks + b.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator -(Duration a, Duration b)
            => new Duration(a.Ticks - b.Ticks);

        [MethodImpl(Inline)]
        public static Duration operator -(Duration a, TimeSpan b)
            => new Duration(a.Ticks - b.Ticks);

        [MethodImpl(Inline)]
        public static double operator /(Duration a, Duration b)        
            => Math.Round((double)a.Ticks / (double) b.Ticks, 4);

        [MethodImpl(Inline)]
        public static double operator /(Duration a, TimeSpan b)        
            => Math.Round((double)a.Ticks / (double) b.Ticks, 4);

        [MethodImpl(Inline)]
        public static bool operator !=(Duration a, Duration b)
            => a.Ticks != b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator ==(Duration a, Duration b)
            => a.Ticks == b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >(Duration lhs, Duration rhs)
            => lhs.Ticks > rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >(Duration lhs, TimeSpan rhs)
            => lhs.Ticks > rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <(Duration lhs, Duration rhs)
            => lhs.Ticks < rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <(Duration lhs, TimeSpan rhs)
            => lhs.Ticks < rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >=(Duration lhs, Duration rhs)
            => lhs.Ticks >= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >=(Duration lhs, TimeSpan rhs)
            => lhs.Ticks >= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <=(Duration lhs, Duration rhs)
            => lhs.Ticks <= rhs.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <=(Duration lhs, TimeSpan rhs)
            => lhs.Ticks <= rhs.Ticks;
            
        /// <summary>
        /// The duration expressed in nanoseconds
        /// </summary>
        public ulong Ns
        {
            [MethodImpl(Inline)]
            get => Z0.TimerTicks.ToNs(Ticks);
        }

        /// <summary>
        /// The duration expressed in timer ticks
        /// </summary>
        public ulong TickCount
        {
            [MethodImpl(Inline)]
            get => (ulong)Ticks;
        }

        /// <summary>
        /// The duration expressed in milliseconds
        /// </summary>
        public double Ms
        {
            [MethodImpl(Inline)]
            get => Z0.TimerTicks.ToMs(Ticks);
        }

        public TimeSpan TimeSpan
        {
            [MethodImpl(Inline)]
            get => new TimeSpan(Ticks);
        }

        [MethodImpl(Inline)]
        public bool Equals(Duration rhs)
            => this.Ticks == rhs.Ticks;

        [MethodImpl(Inline)]
        public int CompareTo(Duration other)
            => Ticks.CompareTo(other.Ticks);

        public string Format()
            => $"{Ms} ms";
        
        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Ticks.GetHashCode();

        public override bool Equals(object obj)            
            => obj is Duration x && Equals(x);
    }
}