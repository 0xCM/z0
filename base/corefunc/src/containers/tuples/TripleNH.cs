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
    /// An non-homogenous mutable 3-tuple
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
            => new Triple<X, Y, Z>(src.a, src.b, src.c);

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