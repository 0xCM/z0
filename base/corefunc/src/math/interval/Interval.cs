//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;

    /// <summary>
    /// Defines a contiguous segment of homogenous values that lie within left and right boundaries 
    /// </summary>
    /// <remarks>
    /// Note that extended real numbers may also serve as endpoints, enabling representations such as (-∞,3] and (-3, ∞).
    /// </remarks>
    public readonly struct Interval<T> : IInterval<T>
        where T : unmanaged
    {
        /// <summary>
        /// Specifies the canonical closed unit interval over the underlying primitive
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        public static Interval<T> U01 
            => new Interval<T>(Zero, One, IntervalKind.Closed);

        /// <summary>
        /// Defines a closed interval that subsumes all points representable by the primal type
        /// </summary>
        public static Interval<T> Full 
            => new Interval<T>(MinTypeVal, MaxTypeVal, IntervalKind.Closed);

        [MethodImpl(Inline)]
        public static Interval<T> LeftUnbound(T right)
            => new Interval<T>(MinTypeVal, right, IntervalKind.LeftOpen);

        [MethodImpl(Inline)]
        public static Interval<T> RightUnbound(T left)
            => new Interval<T>(left, MaxTypeVal, IntervalKind.RightOpen);
        
        /// <summary>
        /// Defines an open interval that subsumes all points representable by the primal type and all points represented 
        /// by increasing the size of the primal type without altering other characteristics
        /// </summary>
        public static Interval<T> Unbound
            => new Interval<T>(MinTypeVal, MaxTypeVal, IntervalKind.Open);

        [MethodImpl(Inline)]
        public static implicit operator Interval<T>((T left, T right) x)
            => new Interval<T>(x.left, true, x.right, true);

        [MethodImpl(Inline)]
        public static implicit operator (T left, T right)(Interval<T> x)
            => (x.Left, x.Right);

        [MethodImpl(Inline)]
        static IntervalKind DetermineKind(bool leftclosed, bool rightclosed)
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
            if(left.Equals(right))
                Degenerate(left,right);

            this.Left = left;
            this.Right = right;
            this.Kind = DetermineKind(leftclosed,rightclosed);
        }

        [MethodImpl(Inline)]
        public Interval(T left, T right, IntervalKind kind)
        {
            if(left.Equals(right))
                Degenerate(left,right);

            this.Left = left;
            this.Right = right;
            this.Kind = kind;
        }

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
            get => Kind == IntervalKind.LeftOpen &&  Left.Equals(MinTypeVal);
        }

        /// <summary>
        /// Specifies whether the interval is unbounded on the left, denoted by (left, ∞).
        /// </summary>
        public bool RightUnbounded
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.RightOpen &&  Right.Equals(MaxTypeVal);
        }


        /// <summary>
        /// Specifies whether the interval is unbounded on the left and right, denoted by (-∞, ∞).
        /// </summary>
        public bool Unbounded
        {
            [MethodImpl(Inline)]
            get => Kind == IntervalKind.Open &&  Left.Equals(MinTypeVal) && Right.Equals(MaxTypeVal);
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
        /// Creates a left-open interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToLeftOpen()
            => new Interval<T>(Left, Right, IntervalKind.LeftOpen);

        /// <summary>
        /// Creates a left-closed interval with endpoints from the existing interval
        /// </summary>
        [MethodImpl(Inline)]
        public Interval<T> ToLeftClosed()
            => new Interval<T>(Left, Right, IntervalKind.LeftClosed);

        /// <summary>
        /// Creates a closed interval with endpoints from the existing interval
        /// </summary>
        public Interval<T> ToClosed()
            => new Interval<T>(Left, Right, IntervalKind.Closed);

        /// <summary>
        /// Converts the left and right underlying values
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public Interval<U> Convert<U>()
            where U : unmanaged
                => new Interval<U>(convert(Left, out U x),convert(Right, out U y),Kind);

        /// <summary>
        /// Creates a view of the data in the inverval as seen through the
        /// lens of another type, but performs no conversion
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public Interval<U> As<U>()
            where U : unmanaged
                => new Interval<U>(AsIn.generic<T,U>(in Left), AsIn.generic<T,U>(in Right), Kind);

        /// <summary>
        /// Creates the same kind of interval with alternate endpoints
        /// </summary>
        /// <param name="left">The left endpoint</param>
        /// <param name="right">The right endpoint</param>
        [MethodImpl(Inline)]
        public Interval<T> WithEndpoints(T left, T right)
            => new Interval<T>(left,right, Kind);

        string LeftFormat
            => LeftUnbounded ? "-∞" : Left.ToString();

        string RightFormat
            => RightUnbounded ? "∞" : Right.ToString();

        public string Format()
            => concat(LeftSymbol, LeftFormat, Separator, RightFormat, RightSymbol);

        public override string ToString()
            => Format();        

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = Left;
            right = Right;
        }

        char LeftSymbol
            =>  (LeftClosed  || Closed) ? AsciSym.LBracket : AsciSym.LParen;

        char RightSymbol
            => (RightClosed || Closed) ? AsciSym.RBracket : AsciSym.RParen;
        
        char Separator
            => AsciSym.Comma;

        static T MinTypeVal => PrimalInfo.minval<T>();

        static T MaxTypeVal => PrimalInfo.maxval<T>();

        static T Zero => PrimalInfo.zero<T>();

        static T One => PrimalInfo.one<T>();

        [MethodImpl(NotInline)]
        static void Degenerate(T left, T right)
            => throw new Exception($"Interval with left = {left} and right = {right} collapses to a point and is considered invalid");
   }

 
}