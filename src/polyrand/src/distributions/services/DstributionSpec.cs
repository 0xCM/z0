//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;    
        
    using static Konst;

    [ApiHost]
    public readonly struct DistributionSpec : IApiHost<DistributionSpec>
    {
        /// <summary>
        /// Casts a supplied distribution to a Bernoulli distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static BernoulliSpec<T> bernoulli<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (BernoulliSpec<T>)src;

        /// <summary>
        /// Specifies a Bernoulli distribution predicated on the probability of trial success
        /// </summary>
        /// <param name="p">The probability of success</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static BernoulliSpec<T> Define<T>(double p)
            where T : unmanaged
                => BernoulliSpec<T>.Define(p);

    }
}