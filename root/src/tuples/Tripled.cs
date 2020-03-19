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
    /// A non-homogenous mutable 3-tuple
    /// </summary>
    /// <typeparam name="T0">The type of the first member</typeparam>
    /// <typeparam name="T1">The type of the second member</typeparam>
    /// <typeparam name="T2">The type of the third member</typeparam>
    public struct Tripled<T0,T1,T2> : ITupled<Tripled<T0,T1,T2>,T0,T1,T2>
    {
        /// <summary>
        /// The first member
        /// </summary>
        public T0 A;
        
        /// <summary>
        /// The second member
        /// </summary>
        public T1 B;

        /// <summary>
        /// The third member
        /// </summary>
        public T2 C;

        [MethodImpl(Inline)]
        public static implicit operator Tripled<T0,T1,T2>((T0 a, T1 b, T2 c) src)
            => new Tripled<T0, T1, T2>(src.a, src.b, src.c);

        [MethodImpl(Inline)]
        public static bool operator ==(Tripled<T0,T1,T2> x, Tripled<T0,T1,T2> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Tripled<T0,T1,T2> x, Tripled<T0,T1,T2> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Tripled(T0 a, T1 b, T2 c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T0 a, out T1 b, out T2 c)
        {
            a = this.A;
            b = this.B;
            c = this.C;
        }

        /// <summary>
        /// Interprets the pair over alternate domains
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Tripled<S,T,U> As<S,T,U>()
            where S : unmanaged
            where T : unmanaged        
            where U : unmanaged                      
                => Unsafe.As<Tripled<T0,T1,T2>,Tripled<S,T,U>>(ref this);

        [MethodImpl(Inline)]
        public bool Equals(Tripled<T0,T1,T2> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B},{C})" : $"{A}x{B}x{C}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Paired<T0,T1> x && Equals(x);

        public override string ToString()
            => Format();
    }
}