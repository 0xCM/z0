//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
    public struct Pair<T0,T1> : IMutableTuple<Pair<T0,T1>, T0 ,T1>
        where T0: unmanaged
        where T1 : unmanaged
    {
        /// <summary>
        /// The first member
        /// </summary>
        public T0 A;
        
        /// <summary>
        /// The second member
        /// </summary>
        public T1 B;

        [MethodImpl(Inline)]
        public static implicit operator Pair<T0,T1>((T0 a, T1 b) src)
            => new Pair<T0, T1>(src.a, src.b);

        [MethodImpl(Inline)]
        public static bool operator ==(Pair<T0,T1> x, Pair<T0,T1> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Pair<T0,T1> x, Pair<T0,T1> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Pair(T0 left, T1 right)
        {
            this.A = left;
            this.B = right;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T0 a, out T1 b)
        {
            a = this.A;
            b = this.B;
        }

        [MethodImpl(Inline)]
        public T0 Get(N0 n)
            => A;

        [MethodImpl(Inline)]
        public T1 Get(N1 n)
            => B;

        [MethodImpl(Inline)]
        public void Set(N0 n, T0 a)
            => this.A = a;

        [MethodImpl(Inline)]
        public void Set(N1 n, T1 b)
            => this.B = b;

        /// <summary>
        /// Interprets the pair over alternate domains
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Pair<S,T> As<S,T>()
            where S : unmanaged
            where T : unmanaged        
                => Unsafe.As<Pair<T0,T1>,Pair<S,T>>(ref this);


        [MethodImpl(Inline)]
        public bool Equals(Pair<T0,T1> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<T0,T1> x && Equals(x);

        public override string ToString()
            => Format();
    }


}