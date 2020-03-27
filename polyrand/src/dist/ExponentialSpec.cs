//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Polyfun;

    /// <summary>
    /// Characterizes a Exponential (normal) distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Normal_distribution</remarks>
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct ExponentialSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static ExponentialSpec<T> Define(T a, T b)
            => new ExponentialSpec<T>(a,b);        

        [MethodImpl(Inline)]
        public static implicit operator (T a, T b)(ExponentialSpec<T> spec)
            => (spec.a, spec.b);

        [MethodImpl(Inline)]
        public static implicit operator ExponentialSpec<T>((T a, T b) x )
            => Define(x.a, x.b);

        [MethodImpl(Inline)]
        public ExponentialSpec(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public readonly T a;

        public readonly T b;

         /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind DistKind 
            => DistKind.Exponential; 
    }
}