//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Tuples;

    /// <summary>
    /// An homogenous immutable 2-tuple
    /// </summary>
    public readonly struct ConstPair<T> : IPair<ConstPair<T>, T>, IFormattable<ConstPair<T>>
    {
        /// <summary>
        /// The first/left/lo member of the pair
        /// </summary>
        public readonly T Left;
        
        /// <summary>
        /// The second/right/hi member of the pair
        /// </summary>
        public readonly T Right;

        [MethodImpl(Inline)]
        public static implicit operator ConstPair<T>((T a, T b) src)
            => new ConstPair<T>(src.a, src.b);

        [MethodImpl(Inline)]
        public static bool operator ==(in ConstPair<T> a, in ConstPair<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(in ConstPair<T> a, in ConstPair<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public ConstPair(T a, T b)
        {
            this.Left = a;
            this.Right = b;
        }                

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? Left : Right;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b)
        {
            a = this.Left;
            b = this.Right;
        }

        T IPair<ConstPair<T>, T>.Left 
        {
            [MethodImpl(Inline)]
            get => Left;
        }

        T IPair<ConstPair<T>, T>.Right 
        {
            [MethodImpl(Inline)]
            get => Right;
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public ConstPair<U> As<U>()
            where U : unmanaged
                => Unsafe.As<ConstPair<T>,ConstPair<U>>(ref Unsafe.AsRef(in this));

        [MethodImpl(Inline)]
        public bool Equals(ConstPair<T> rhs)
            => Left.Equals(rhs.Left) && Right.Equals(rhs.Right);

        public string Format(TupleFormat style)
            => style == TupleFormat.Coordinate ? $"({Left},{Right})" : $"{Left}x{Right}";

        public string Format()
            => Format(TupleFormat.Coordinate);

        public override int GetHashCode()
            => HashCode.Combine(Left,Right);
        
        public override bool Equals(object obj)
            => obj is ConstPair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }
}