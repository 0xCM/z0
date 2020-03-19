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
    /// An homogenous immutable 4-tuple
    /// </summary>
    public readonly struct ConstQuad<T> : ITupled<ConstQuad<T>,T,T,T,T>, IFormattable<ConstQuad<T>>
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
        
        /// <summary>
        /// The fourth member
        /// </summary>
        public readonly T D;

        [MethodImpl(Inline)]
        public static implicit operator ConstQuad<T>(in (T a, T b, T c, T d) src)
            => new ConstQuad<T>(src.a,src.b,src.c,src.d);

        [MethodImpl(Inline)]
        public static implicit operator ConstQuad<T>(in (ConstPair<T> a, ConstPair<T> b) src)
            => new ConstQuad<T>(src.a.Left,src.a.Right, src.b.Left,src.b.Right);

        [MethodImpl(Inline)]
        public static bool operator ==(in ConstQuad<T> a, in ConstQuad<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(in ConstQuad<T> a, in ConstQuad<T> b)        
            => a.Equals(b);

        [MethodImpl(Inline)]
        public ConstQuad(T a, T b, T c, T d)
        {
            A = a; B = b; C = c; D = d;
        }                

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? A : i == 1 ? B : i == 2 ? C : D;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b, out T c, out T d)
        {
            a = A; b = B; c = C; d = D;
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public ConstQuad<U> As<U>()
            where U : unmanaged
                => Unsafe.As<ConstQuad<T>,ConstQuad<U>>(ref Unsafe.AsRef(in this));

        [MethodImpl(Inline)]
        public bool Equals(ConstQuad<T> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B) && C.Equals(rhs.C) && D.Equals(rhs.D);

        public string Format(TupleFormat style)
            => style == TupleFormat.Coordinate ? $"({A},{B},{C},{D})" : $"{A}x{B}x{C}x{D}";

        public string Format()
            => Format(TupleFormat.Coordinate);

        public override int GetHashCode()
            => HashCode.Combine(A,B,C);
        
        public override bool Equals(object obj)
            => obj is ConstQuad<T> x && Equals(x);

        public override string ToString()
            => Format();
    }

}