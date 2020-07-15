//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;

    using K = IntervalKind;

    /// <summary>
    /// Defines a closed T-interval  where an ordering on T is assumed to exist and be well-defined
    /// </summary>
    public readonly struct ClosedInterval<T> : IInterval<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left endpoint
        /// </summary>
        public readonly T Left;

        /// <summary>
        /// The right endpoint
        /// </summary>
        public readonly T Right;

        [MethodImpl(Inline)]
        public ClosedInterval(T left, T right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClosedInterval<T>((T left, T right) x)
            => new ClosedInterval<T>(x.left, x.right);

        [MethodImpl(Inline)]
        public static implicit operator (T left, T right)(ClosedInterval<T> x)
            => (x.Left, x.Right);

        [MethodImpl(Inline)]
        public static implicit operator ConstPair<T>(ClosedInterval<T> x)
            => x.Pair;

        [MethodImpl(Inline)]
        public static implicit operator ClosedInterval<T>(ConstPair<T> x)
            => new ClosedInterval<T>(x.Left, x.Right);

        public ConstPair<T> Pair
        {
            [MethodImpl(Inline)]
            get => new ConstPair<T>(Left, Right);
        }

        public ulong Width
        {
            [MethodImpl(Inline)]
            get => RightU64 - LeftU64;
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
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Left.Equals(Right);
        }
        
        [MethodImpl(Inline)]
        public bool Contains(T point)
            => between(uint64(point), LeftU64, RightU64);
        
        /// <summary>
        /// Converts the left and right underlying values
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ClosedInterval<U> Convert<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new ClosedInterval<U>(Cast.to<T,U>(Left), Cast.to<T,U>(Right));

        /// <summary>
        /// Creates a view of the data in the inverval as seen through the
        /// lens of another type, but performs no conversion
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ClosedInterval<U> As<U>()
            where U : unmanaged, IComparable<U>, IEquatable<U>
                => new ClosedInterval<U>(In.generic<T,U>(Left), In.generic<T,U>(Right));

        [MethodImpl(Inline)]
        public void Deconstruct(out T left, out T right)
        {
            left = Left;
            right = Right;
        }

        [MethodImpl(Inline)]
        public ClosedInterval<T> New(T left, T right)
            => new ClosedInterval<T>(left,right);

        [MethodImpl(Inline)]
        public string Format()
            => text.concat(Chars.LBracket, Left, Chars.Comma, Right, Chars.RBracket);

        [MethodImpl(Inline)]
        public string Format(TupleFormat style)
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ClosedInterval<T> src)
            => Left.Equals(src.Left) && Right.Equals(src.Right);

        public override string ToString()
            => Format();        

        ulong LeftU64
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Left);
        }

        ulong RightU64
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Right);
        }

        T IInterval<T>.Left 
            => Left;

        T IInterval<T>.Right 
            => Right;

        bool IInterval.LeftClosed 
            => true;

        bool IInterval.RightClosed 
            => true;
       
        /// <summary>
        /// The interval classification
        /// </summary>
        K IInterval.Kind 
            => K.Closed;

        /// <summary>
        /// The interval of nothingness
        /// </summary>
        public static ClosedInterval<T> Empty 
            => default;
    }
}