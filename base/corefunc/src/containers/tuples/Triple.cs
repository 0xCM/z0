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
    /// An homogenous mutable 3-tuple
    /// </summary>
    public struct Triple<T> : IMutableTuple<Triple<T>,T,T,T>
        where T : unmanaged
    {
        /// <summary>
        /// The first member
        /// </summary>
        public T A;
        
        /// <summary>
        /// The second member
        /// </summary>
        public T B;

        /// <summary>
        /// The third member
        /// </summary>
        public T C;

        [MethodImpl(Inline)]
        public static implicit operator Triple<T>((T a, T b, T c) src)
            => new Triple<T>(src.a, src.b, src.c);
        
        [MethodImpl(Inline)]
        public static bool operator ==(Triple<T> x, Triple<T> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Triple<T> x, Triple<T> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Triple(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out T a, out T b, out T c)
        {
            a = this.A;
            b = this.B;
            c = this.C;
        }

        [MethodImpl(Inline)]
        public T Get(N0 n)
            => A;

        [MethodImpl(Inline)]
        public T Get(N1 n)
            => B;

        [MethodImpl(Inline)]
        public T Get(N2 n)
            => C;

        [MethodImpl(Inline)]
        public void Set(N0 n, T a)
            => this.A = a;

        [MethodImpl(Inline)]
        public void Set(N1 n, T b)
            => this.B = b;

        [MethodImpl(Inline)]
        public void Set(N2 n, T c)
            => this.C = c;

        public T this[int i]
        {
            [MethodImpl(Inline)]
            get => i == 0 ? A : i == 1 ? B : C;

            [MethodImpl(Inline)]
            set 
            {
                if(i == 0)
                    A = value;
                else if(i == 2)
                    B = value;
                else
                    C = value;
            }
        }

        /// <summary>
        /// Interprets the pair over an alternate domain
        /// </summary>
        /// <typeparam name="U">The alternate type</typeparam>
        [MethodImpl(Inline)]
        public Triple<U> As<U>()
            where U : unmanaged
                => new Triple<U>(Unsafe.As<T,U>(ref A), Unsafe.As<T,U>(ref B), Unsafe.As<T,U>(ref C));

        [MethodImpl(Inline)]
        public bool Equals(Triple<T> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B) && C.Equals(rhs.C);

        public string Format(TupleFormat style = TupleFormat.Coordinate)
            => style == TupleFormat.Coordinate ? $"({A},{B},{C})" : $"{A}x{B}x{C}";

        public override int GetHashCode()
            => HashCode.Combine(A,B,C);
        
        public override bool Equals(object obj)
            => obj is Triple<T> x && Equals(x);

        public override string ToString()
            => Format();
    }
}