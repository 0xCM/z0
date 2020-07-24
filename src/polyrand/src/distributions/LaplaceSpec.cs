
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a Laplace distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Laplace_distribution</remarks>
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct LaplaceSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        /// <summary>
        /// The distribution mean
        /// </summary>
        public readonly T Location;

        /// <summary>
        /// The standard deviation
        /// </summary>
        public readonly T Scale;

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistributionKind DistKind 
            => DistributionKind.Laplace;        
        
        [MethodImpl(Inline)]
        public static LaplaceSpec<T> Define(T loc, T scale)
            => new LaplaceSpec<T>(loc, scale);

        [MethodImpl(Inline)]
        public static implicit operator (T loc, T scale)(LaplaceSpec<T> spec)
            => (spec.Location, spec.Scale);

        [MethodImpl(Inline)]
        public static implicit operator LaplaceSpec<T>((T loc, T scale) x)
            => Define(x.loc,x.scale);
        
        [MethodImpl(Inline)]
        public LaplaceSpec(T loc, T scale)
        {
            Location = loc;
            Scale = scale;
        }
    }
}