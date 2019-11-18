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
        /// Defines a pair
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Pair<T> define<T>(T a, T b)
            where T : unmanaged
                => new Pair<T>(a,b);
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
            => Pair.define(src.a, src.b);

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
                => new Pair<U>(Unsafe.As<T,U>(ref A), Unsafe.As<T,U>(ref B));

        [MethodImpl(Inline)]
        public bool Equals(Pair<T> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format()
            => $"({A},{B})";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<T> x && Equals(x);

        public override string ToString()
            => Format();
    }

}