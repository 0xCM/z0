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
    /// An homogenous mutable 2-tuple
    /// </summary>
    public struct Pair<T> : IPair<Pair<T>, T>, IFormattable<Pair<T>>
    {
        /// <summary>
        /// The first member
        /// </summary>
        public T Left;
        
        /// <summary>
        /// The second member
        /// </summary>
        public T Right;

        [MethodImpl(Inline)]
        public static implicit operator Pair<T>((T a, T b) src)
            => new Pair<T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static bool operator ==(Pair<T> x, Pair<T> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Pair<T> x, Pair<T> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Pair(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b)
        {
            a = this.Left;
            b = this.Right;
        }

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? Left : Right;

            [MethodImpl(Inline)]
            set 
            {
                if(i == 0)
                    Left = value;
                else 
                    Right = value;
            }
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Pair<U> As<U>()
            where U : unmanaged
                => Unsafe.As<Pair<T>,Pair<U>>(ref this);

        [MethodImpl(Inline)]
        public bool Equals(Pair<T> rhs)
            => Left.Equals(rhs.Left) && Right.Equals(rhs.Right);

        public string Format(TupleFormat style)
            => style == TupleFormat.Coordinate ? $"({Left},{Right})" : $"{Left}x{Right}";

        public string Format()
            => Format(TupleFormat.Coordinate);

        public override int GetHashCode()
            => HashCode.Combine(Left,Right);
        
        public override bool Equals(object obj)
            => obj is Pair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }
}