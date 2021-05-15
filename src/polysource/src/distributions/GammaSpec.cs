//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Characterizes a Gamma distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Gamma_distribution</remarks>
    public readonly struct GammaSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        internal GammaSpec(T alpha, T dx, T beta)
        {
            Alpha = alpha;
            Dx = dx;
            Beta = beta;
        }

        public readonly T Alpha;

        public readonly T Dx;

        public readonly T Beta;

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistributionKind DistKind
            => DistributionKind.Gamma;
    }
}