//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// An homogenous mutable 2-tuple
    /// </summary>
    public struct Pair<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first/left/lo member of the pair
        /// </summary>
        public T A;
        
        /// <summary>
        /// The second/right/hi member of the pair
        /// </summary>
        public T B;

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
            this.A = left;
            this.B = right;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b)
        {
            a = this.A;
            b = this.B;
        }

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? A : B;

            [MethodImpl(Inline)]
            set 
            {
                if(i == 0)
                    A = value;
                else 
                    B = value;
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
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }
}