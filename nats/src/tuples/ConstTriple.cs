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
    /// An homogenous immutable 3-tuple
    /// </summary>
    public readonly struct ConstTriple<T> : ITuple<ConstTriple<T>,T,T,T>
    {
        /// <summary>
        /// The first member
        /// </summary>
        public readonly T A;
        
        /// <summary>
        /// The second member
        /// </summary>
        public readonly T B;

        /// <summary>
        /// The third member
        /// </summary>
        public readonly T C;        

        [MethodImpl(Inline)]
        public static implicit operator ConstTriple<T>((T a, T b, T c) src)
            => new ConstTriple<T>(src.a,src.b,src.c);

        [MethodImpl(Inline)]
        public static bool operator ==(in ConstTriple<T> a, in ConstTriple<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(in ConstTriple<T> a, in ConstTriple<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public ConstTriple(T a, T b, T c)
        {
            A = a; B = b; C = c; 
        }                

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? A : i == 1 ? B : C;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b, out T c)
        {
            a = A; b = B; c = C;
        }

        [MethodImpl(Inline)]
        public T Get(N0 n) => A;

        [MethodImpl(Inline)]
        public T Get(N1 n) => B;

        [MethodImpl(Inline)]
        public T Get(N2 n) => C;

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public ConstTriple<U> As<U>()
            where U : unmanaged
                => Unsafe.As<ConstTriple<T>,ConstTriple<U>>(ref Unsafe.AsRef(in this));

        [MethodImpl(Inline)]
        public bool Equals(ConstTriple<T> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B) && C.Equals(rhs.C);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B},{C})" : $"{A}x{B}x{C}";

        public override int GetHashCode()
            => HashCode.Combine(A,B,C);
        
        public override bool Equals(object obj)
            => obj is ConstTriple<T> x && Equals(x);

        public override string ToString()
            => Format();
    }
}