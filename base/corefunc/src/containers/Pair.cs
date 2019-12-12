//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public enum PairFormat
    {
        
        /// <summary>
        /// Specifies a pair of values a and b is rendered as (a,b)
        /// </summary>
        Tuple,

        /// <summary>
        /// Specifies a pair of values a and b is rendered as axb
        /// </summary>
        Dim
    }

    /// <summary>
    /// Defines api surface for pair
    /// </summary>
    public static class Pair
    {
        /// <summary>
        /// Creates an empty pair
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> alloc<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates an empty pair
        /// </summary>
        /// <typeparam name="L">The left member type</typeparam>
        /// <typeparam name="R">The right member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<L,R> alloc<L,R>()
            where L : unmanaged
            where R : unmanaged
                => default;

        /// <summary>
        /// Defines an homogenous pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> define<T>(T a, T b)
            where T : unmanaged
                => new Pair<T>(a,b);

        /// <summary>
        /// Defines a non-homogenous pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="L">The left member type</typeparam>
        /// <typeparam name="R">The right member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<L,R> paired<L,R>(L a, R b)
            where L : unmanaged
            where R : unmanaged
                => new Pair<L,R>(a,b);
    }


    /// <summary>
    /// An homogenous 2-tuple
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
            => Pair.define<T>(src.a, src.b);

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

        public string Format(PairFormat style = PairFormat.Tuple)
            => style == PairFormat.Tuple ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }

    /// <summary>
    /// An non-homogenous 2-tuple
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
            => Pair.paired(src.a, src.b);

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

        public string Format(PairFormat style = PairFormat.Tuple)
            => style == PairFormat.Tuple ? $"({A},{B})" : $"{A}x{B}";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<L,R> x && Equals(x);

        public override string ToString()
            => Format();
    }
}