//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericCast;    

    /// <summary>
    /// Defines operations specific to Gaussian distributions
    /// </summary>
    public static class GaussianSpec
    {
        /// <summary>
        /// Interprets a supplied spec as a Gaussian spec; an error
        /// is raised if the spec does not define a Gaussian distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static GaussianSpec<T> From<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (GaussianSpec<T>)src;        

        /// <summary>
        /// Defines a Gaussian distribution with specified mean and standard deviation
        /// </summary>
        /// <param name="mu">The distribution mean</param>
        /// <param name="sigma">The standard deviation</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static GaussianSpec<T> Define<T>(T mu, T sigma)
            where T : unmanaged
                => GaussianSpec<T>.Define(mu,sigma);
    }

}