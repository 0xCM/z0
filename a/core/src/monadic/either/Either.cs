//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// A value that realizes exactly one of two alternatives, 
    /// named "left" and "right"
    /// </summary>
    /// <typeparam name="L">The type of the left alternative</typeparam>
    /// <typeparam name="R">The type of the right alternative</typeparam>
    public readonly struct Either<L, R> : IEither<L,R>, IEquatable<Either<L, R>>
    {
        /// <summary>
        /// Tracks the chosen alternative
        /// </summary>
        EitherCase Selected { get; }

        /// <summary>
        /// Specifies the left alternative
        /// </summary>
        public L Left { get; }

        /// <summary>
        /// Specivies the right alternative
        /// </summary>
        public R Right { get; }

        public static implicit operator Either<L,R>(L left)
            => new Either<L, R>(left);

        public static implicit operator Either<L, R>(R right)
            => new Either<L, R>(right);

        public static bool operator ==(Either<L, R> x, Either<L, R> y)
            => x.Equals(y);

        public static bool operator !=(Either<L, R> x, Either<L, R> y)
            => !x.Equals(y);

        /// <summary>
        /// Constructs a left-valued alternative
        /// </summary>
        /// <param name="left">The alternative value</param>
        internal Either(L left)
        {
            this.Left = left;
            this.Selected = EitherCase.Left;
            this.Right = default;
        }

        /// <summary>
        /// Constructs a right-valued alternative
        /// </summary>
        /// <param name="right">The alternative value</param>
        internal Either(R right)
        {
            this.Right = right;
            this.Selected = EitherCase.Right;
            this.Left = default;
        }
        
        internal enum EitherCase { Left, Right }

        /// <summary>
        /// Indicates whether the left alternative is specified
        /// </summary>
        public bool IsLeft
            => Selected == EitherCase.Left;

        /// <summary>
        /// Indicates whether the right alternative is specified
        /// </summary>
        public bool IsRight
            => Selected == EitherCase.Right;

        /// <summary>
        /// Invokes an action if the alternative is left-valued
        /// </summary>
        /// <param name="action">The action to invoke</param>
        public Either<L, R> OnLeft(Action<L> action)
        {
            if (Selected == EitherCase.Left)
                action(Left);
            return this;
        }
    
        /// <summary>
        /// Invokes an action if the alternative is right values
        /// </summary>
        /// <param name="action">The action to invoke</param>
        public Either<L, R> OnRight(Action<R> action)
        {
            if (Selected == EitherCase.Right)
                action(Right);
            return this;
        }

        /// <summary>
        /// Invokes exactly one of two alternative actions
        /// </summary>
        /// <param name="left">The action to invoke when the altenative is left-valued</param>
        /// <param name="right">The action to invoke when the altenative is right-valued</param>
        public void OnValue(Action<L> left, Action<R> right)
            => OnLeft(left).OnRight(right);

        /// <summary>
        /// Applies exactly one of two transformations
        /// </summary>
        /// <typeparam name="Y">The type of the output value</typeparam>
        /// <param name="ifLeft">The transformation to invoke when the alternative is left-valued</param>
        /// <param name="ifRight">The transformation to invoke when the alternative is right-valued</param>
        public Y Apply<Y>(Func<L, Y> ifLeft, Func<R, Y> ifRight)
            => IsLeft ? ifLeft(Left) : ifRight(Right);

        public Either<L, Y> Select<Y>(Func<R, Y> selector)
                => IsRight  ? selector(Right) : new Either<L, Y>(Left);

        public Either<L, Z> SelectMany<Y,Z>(Func<R, Either<L, Y>> selector, Func<R, Y, Z> projector)
        {
            if (IsLeft)
                return new Either<L, Z>(Left);

            var selected = selector(Right);
            if (selected.IsLeft)
                return new Either<L, Z>(selected.Left);
            else
                return new Either<L, Z>(projector(Right, selected.Right));
        }

        /// <summary>
        /// Adjudicates structural equality
        /// </summary>
        /// <param name="other">The other either</param>
        public bool Equals(Either<L, R> other)
        {
            if (IsLeft && other.IsLeft)
                return Equals(Left, other.Left);
            else if (IsRight && other.IsRight)
                return Equals(Right, other.Right);
            else
                return false;
        }

        public override string ToString()
            => Apply(left => $"Left({left})",
                        right => $"Right({right})");

        public override int GetHashCode()
            => IsLeft ? Left.GetHashCode() 
                : Right.GetHashCode();

        public override bool Equals(object obj)
            => obj is Either<L, R> 
            ? Equals((Either<L, R>)obj) : false;
    }
}