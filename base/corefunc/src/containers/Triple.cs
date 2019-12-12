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
    /// Defines Triple api surface
    /// </summary>
    public static class Triple
    {
        /// <summary>
        /// Creates an empty triple
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<T> alloc<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Creates an empty triple
        /// </summary>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<X,Y,Z> alloc<X,Y,Z>()
            where X: unmanaged
            where Y : unmanaged
            where Z : unmanaged
                => default;

        /// <summary>
        /// Defines an homogenous triple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <typeparam name="T">The member type</typeparam>
        [MethodImpl(Inline)]
        public static Triple<T> define<T>(T a, T b, T c)
            where T : unmanaged
                => new Triple<T>(a,b,c);

        /// <summary>
        /// Defines a non-homogenous triple
        /// </summary>
        /// <param name="a">The first member</param>
        /// <param name="b">The second member</param>
        /// <param name="c">The third member</param>
        /// <typeparam name="X">The type of the first member</typeparam>
        /// <typeparam name="Y">The type of the second member</typeparam>
        /// <typeparam name="Z">The type of the third member</typeparam>
        [MethodImpl(Inline)]
        public static Triple<X,Y,Z> tripled<X,Y,Z>(X a, Y b, Z c)
            where X: unmanaged
            where Y : unmanaged
            where Z : unmanaged
                 => new Triple<X,Y,Z>(a,b,c);
    }

    /// <summary>
    /// An homogenous 3-tuple
    /// </summary>
    public struct Triple<T>
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
            => Triple.define(src.a, src.b, src.c);
        
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

        public string Format()
            => $"({A},{B},{C})";

        public override int GetHashCode()
            => HashCode.Combine(A,B,C);
        
        public override bool Equals(object obj)
            => obj is Triple<T> x && Equals(x);

        public override string ToString()
            => Format();
    }


    /// <summary>
    /// An non-homogenous 2-tuple
    /// </summary>
    /// <typeparam name="X">The type of the first member</typeparam>
    /// <typeparam name="Y">The type of the second member</typeparam>
    /// <typeparam name="Z">The type of the third member</typeparam>
   public struct Triple<X,Y,Z>
        where X: unmanaged
        where Y : unmanaged
        where Z : unmanaged
    {
        /// <summary>
        /// The first member
        /// </summary>
        public X A;
        
        /// <summary>
        /// The second member
        /// </summary>
        public Y B;

        /// <summary>
        /// The third member
        /// </summary>
        public Z C;

        [MethodImpl(Inline)]
        public static implicit operator Triple<X,Y,Z>((X a, Y b, Z c) src)
            => Triple.tripled(src.a, src.b, src.c);

        [MethodImpl(Inline)]
        public static bool operator ==(Triple<X,Y,Z> x, Triple<X,Y,Z> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Triple<X,Y,Z> x, Triple<X,Y,Z> y)        
            => x.Equals(y);

        [MethodImpl(Inline)]
        public Triple(X a, Y b, Z c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }                

        [MethodImpl(Inline)]
        public void Deconstruct(out X a, out Y b, out Z c)
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
        public Triple<S,T,U> As<S,T,U>()
            where S : unmanaged
            where T : unmanaged        
            where U : unmanaged                      
                => Unsafe.As<Triple<X,Y,Z>,Triple<S,T,U>>(ref this);

        [MethodImpl(Inline)]
        public bool Equals(Triple<X,Y,Z> rhs)
            => A.Equals(rhs.A) && B.Equals(rhs.B);

        public string Format()
            => $"({A},{B},{C})";

        public override int GetHashCode()
            => HashCode.Combine(A,B);
        
        public override bool Equals(object obj)
            => obj is Pair<X,Y> x && Equals(x);

        public override string ToString()
            => Format();
    }
}