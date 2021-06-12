//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using K = IntervalKind;

    /// <summary>
    /// Defines a closed T-interval where an ordering on T is assumed to exist and be well-defined
    /// </summary>
    [Datatype]
    public readonly struct ClosedInterval<T> : IInterval<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left endpoint
        /// </summary>
        public T Min {get;}

        /// <summary>
        /// The right endpoint
        /// </summary>
        public T Max {get;}

        [MethodImpl(Inline)]
        public ClosedInterval(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public ConstPair<T> Pair
        {
            [MethodImpl(Inline)]
            get => new ConstPair<T>(Min, Max);
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => RightU64 - LeftU64 + 1;
        }

        /// <summary>
        /// Specifies whether the left and right endpoints are the same
        /// </summary>
        public bool Degenerate
        {
            [MethodImpl(Inline)]
            get => Min.Equals(Max);
        }

        /// <summary>
        /// Specifies whether the interval is the zero interval
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Min.Equals(Max);
        }

        /// <summary>
        /// Converts the left and right underlying values
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ClosedInterval<U> Convert<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new ClosedInterval<U>(@as<T,U>(Min), @as<T,U>(Max));

        /// <summary>
        /// Creates a view of the data in the interval as seen through the
        /// lens of another type, but performs no conversion
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ClosedInterval<U> As<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new ClosedInterval<U>(@as<T,U>(Min), @as<T,U>(Max));

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = Min;
            right = Max;
        }

        public string Format()
            => string.Concat(Chars.LBracket, Min, Chars.Comma, Max, Chars.RBracket);

        [MethodImpl(Inline)]
        public string Format(TupleFormatKind style)
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ClosedInterval<T> src)
            => Min.Equals(src.Min) && Max.Equals(src.Max);

        public override string ToString()
            => Format();

        ulong LeftU64
        {
            [MethodImpl(Inline)]
            get => @as<T,ulong>(Min);
        }

        ulong RightU64
        {
            [MethodImpl(Inline)]
            get => @as<T,ulong>(Max);
        }

        T IInterval<T>.Left
            => Min;

        T IInterval<T>.Right
            => Max;

        bool IInterval.LeftClosed
            => true;

        bool IInterval.RightClosed
            => true;

        /// <summary>
        /// The interval classification
        /// </summary>
        K IInterval.Kind
            => K.Closed;

        [MethodImpl(Inline)]
        public static implicit operator ClosedInterval<T>((T left, T right) x)
            => new ClosedInterval<T>(x.left, x.right);

        [MethodImpl(Inline)]
        public static implicit operator Interval<T>(ClosedInterval<T> src)
            => new Interval<T>(src.Min, src.Max, IntervalKind.Closed);

        [MethodImpl(Inline)]
        public static implicit operator (T left, T right)(ClosedInterval<T> x)
            => (x.Min, x.Max);

        [MethodImpl(Inline)]
        public static implicit operator ConstPair<T>(ClosedInterval<T> x)
            => x.Pair;

        [MethodImpl(Inline)]
        public static implicit operator ClosedInterval<T>(ConstPair<T> x)
            => new ClosedInterval<T>(x.Left, x.Right);

        /// <summary>
        /// The interval of nothingness
        /// </summary>
        public static ClosedInterval<T> Empty
            => default;

        /// <summary>
        /// The interval of everything
        /// </summary>
        public static ClosedInterval<T> Full
        {
            [MethodImpl(Inline)]
            get => new ClosedInterval<T>(Limits.minval<T>(), Limits.maxval<T>());
        }
    }
}