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
    /// A non-homogenous mutable 2-tuple
    /// </summary>
    public struct Pair<L,R>
        where L: unmanaged
        where R : unmanaged
    {
        /// <summary>
        /// The left member of the pair
        /// </summary>
        public L A;
        
        /// <summary>
        /// The right member of the pair
        /// </summary>
        public R B;

        [MethodImpl(Inline)]
        public static implicit operator Pair<L,R>((L a, R b) src)
            => new Pair<L, R>(src.a, src.b);

        [MethodImpl(Inline)]
        public static bool operator ==(Pair<L,R> x, Pair<L,R> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Pair<L,R> x, Pair<L,R> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Pair(L left, R right)
        {
            this.A = left;
            this.B = right;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out L a, out R b)
        {
            a = this.A;
            b = this.B;
        }

        /// <summary>
        /// Interprets the pair over alternate domains
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Pair<S,T> As<S,T>()
            where S : unmanaged
            where T : unmanaged        
                => Unsafe.As<Pair<L,R>,Pair<S,T>>(ref this);


        [MethodImpl(Inline)]
        public bool Equals(Pair<L,R> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<L,R> x && Equals(x);

        public override string ToString()
            => Format();
    }


}