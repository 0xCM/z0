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
    /// An homogenous immutable 2-tuple
    /// </summary>
    public readonly struct ConstPair<T>
        where T : unmanaged
    {
        /// <summary>
        /// The first/left/lo member of the pair
        /// </summary>
        public readonly T A;
        
        /// <summary>
        /// The second/right/hi member of the pair
        /// </summary>
        public readonly T B;

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
            this.A = a;
            this.B = b;
        }                

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? A : B;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b)
        {
            a = this.A;
            b = this.B;
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
        public bool Equals(in ConstPair<T> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is ConstPair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }

}