//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Literals;

    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints, enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : IInterval<Interval<T>, T>
        where T : unmanaged
    {
        public static Interval<T> Zero => default;

        /// <summary>
        /// The left endpoint
        /// </summary>
        public readonly T Left;

        /// <summary>
        /// The right endpoint
        /// </summary>
        public readonly T Right;

        /// <summary>
        /// The interval classification
        /// </summary>
        public IntervalKind Kind {get;}

        /// <summary>
        /// Specifies the canonical closed unit interval over the underlying primitive
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static Interval<T> U01 
            => new Interval<T>(zero<T>(), one<T>(), IntervalKind.Closed);

        /// <summary>
        /// Defines a closed interval that subsumes all points representable by the primal type
        /// </summary>
        public static Interval<T> Full 
            => new Interval<T>(minval<T>(), maxval<T>(), IntervalKind.Closed);

        /// <summary>
        /// Defines an open interval that subsumes all points representable by the primal type and all points represented 
        /// by increasing the size of the primal type without altering other characteristics
        /// </summary>
        public static Interval<T> Unbound
            => new Interval<T>(minval<T>(), maxval<T>(), IntervalKind.Open);

        [MethodImpl(Inline)]
        public static Interval<T> LeftUnbound(T right)
            => new Interval<T>(minval<T>(), right, IntervalKind.LeftOpen);

        [MethodImpl(Inline)]
        public static Interval<T> RightUnbound(T left)
            => new Interval<T>(left, maxval<T>(), IntervalKind.RightOpen);
        
        [MethodImpl(Inline)]
        public static implicit operator Interval<T>((T left, T right) x)
            => new Interval<T>(x.left, true, x.right, true);

        [MethodImpl(Inline)]
        public static implicit operator (T left, T right)(Interval<T> x)
            => (x.Left, x.Right);

        [MethodImpl(Inline)]
        static IntervalKind Classify(bool leftclosed, bool rightclosed)
        {
            var closed = leftclosed && rightclosed;
            var open =  !leftclosed && !rightclosed;
            return    
                  closed ? IntervalKind.Closed
                : open ? IntervalKind.Open
                : leftclosed && !rightclosed ? IntervalKind.LeftClosed
                : IntervalKind.RightClosed;
        }

        [MethodImpl(Inline)]
        public Interval(T left, bool leftclosed, T right, bool rightclosed)
        {
            this.Left = left;
            this.Right = right;
            this.Kind = Classify(leftclosed,rightclosed);
        }

        [MethodImpl(Inline)]
        public Interval(T left, T right, IntervalKind kind)
        {
            this.Left = left;
            this.Right = right;
            this.Kind = kind;
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Right) - Cast.to<T,ulong>(Left);
        }

        /// <summary>
        /// Specifies whether the interval is left-closed, or equivalently right-open, denoted by [Left,Right),
        /// </summary>
        public bool LeftClosed 
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.LeftClosed;
        }

        /// <summary>
        /// Specifies whether the interval is right-closed, or equivalently left-open, denoted by (Left,Right],
        /// </summary>
        public bool RightClosed
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.RightClosed;
        }

        /// <summary>
        /// Specifies whether the interval is open, denoted by (Left,Right)
        /// </summary>
        public bool Open
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.Open;
        }

        /// <summary>
        /// Specifies whether the interval is closed, denoted by [Left,Right]
        /// </summary>
        public bool Closed
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.Closed;
        }

        /// <summary>
        /// Specifies whether the interval is open on the right and closed on the left, denoted by [Left,Right)
        /// </summary>
        public bool RightOpen
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.RightOpen;
        }

        /// <summary>
        /// Specifies whether the interval is open on the left and closed on the right, denoted by (Left,Right]
        /// </summary>
        public bool LeftOpen
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.LeftOpen;
        }

        /// <summary>
        /// Specifies whether the interval is unbounded on the left, denoted by (-∞, right).
        /// </summary>
        public bool LeftUnbounded
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.LeftOpen &&  Left.Equals(minval<T>());
        }

        /// <summary>
        /// Specifies whether the interval is unbounded on the left, denoted by (left, ∞).
        /// </summary>
        public bool RightUnbounded
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.RightOpen &&  Right.Equals(maxval<T>());
        }

        /// <summary>
        /// Specifies whether the interval is unbounded on the left and right, denoted by (-∞, ∞).
        /// </summary>
        public bool Unbounded
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.Open &&  Left.Equals(minval<T>()) && Right.Equals(maxval<T>());
        }

        /// <summary>
        /// Specifies whether the left and right enpoints are the same
        /// </summary>
        public bool Degenerate
        {
            [MethodImpl(Inline)]
            get => Left.Equals(Right);
        }

        /// <summary>
        /// Specifies whether the interval is the zero interval
        /// </summary>
        public bool Empty
        {
            [MethodImpl(Inline)]
            get => Left.Equals(default) && Right.Equals(default) && Closed;
        }

        T IInterval<T>.Left 
            => Left;

        T IInterval<T>.Right 
            => Right;

        /// <summary>
        /// Creates an open interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToOpen()
            => new Interval<T>(Left, Right, IntervalKind.Open);

        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToLeftOpen()
            => new Interval<T>(Left, Right, IntervalKind.LeftOpen);

        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToRightClosed()
            => new Interval<T>(Left, Right, IntervalKind.RightClosed);

        /// <summary>
        /// Creates a left-open/right-closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToRightOpen()
            => new Interval<T>(Left, Right, IntervalKind.RightOpen);

        /// <summary>
        /// Creates a left-closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToLeftClosed()
            => new Interval<T>(Left, Right, IntervalKind.LeftClosed);

        /// <summary>
        /// Creates a closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToClosed()
            => new Interval<T>(Left, Right, IntervalKind.Closed);

        /// <summary>
        /// Converts the left and right underlying values
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public Interval<U> Convert<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new Interval<U>(Cast.to<T,U>(Left), Cast.to<T,U>(Right),Kind);

        /// <summary>
        /// Creates a view of the data in the inverval as seen through the
        /// lens of another type, but performs no conversion
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public Interval<U> As<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new Interval<U>(Z0.AsIn.generic<T,U>(in Left), Z0.AsIn.generic<T,U>(in Right), Kind);

        public string Format()
            => string.Concat(LeftSymbol, LeftFormat, Separator, RightFormat, RightSymbol);

        public override string ToString()
            => Format();        

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = Left;
            right = Right;
        }

        [MethodImpl(Inline)]
        public Interval<T> New(T left, T right, IntervalKind kind)
            => new Interval<T>(left,right, kind);

        public string Format(TupleFormat style)
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(Interval<T> src)
            => Kind == src.Kind && Left.Equals(src.Left) && Right.Equals(src.Right);

        string LeftFormat => LeftUnbounded ? "-∞" : Left.ToString();

        string RightFormat => RightUnbounded ? "∞" : Right.ToString();

        const char LBracket = '[';

        const char RBracket = ']';

        const char LParen = '(';

        const char RParen = ')';

        const char Comma = ',';

        char LeftSymbol =>  (LeftClosed  || Closed) ? LBracket : LParen;

        char RightSymbol => (RightClosed || Closed) ? RBracket : RParen;
        
        char Separator => Comma;

        T IPair<Interval<T>, T>.Left 
        {
            [MethodImpl(Inline)]
            get => Left;
        }

        T IPair<Interval<T>, T>.Right 
        {
            [MethodImpl(Inline)]
            get => Right;
        }
    }
}