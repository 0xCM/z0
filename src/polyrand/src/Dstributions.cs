//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct Distributions
    {
        /// <summary>
        /// Interprets a supplied spec as a gamma spec; an error
        /// is raised if the spec does not define gamma distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static GammaSpec<T> gamma<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (GammaSpec<T>)src;

        /// <summary>
        /// Defines a gamma distribution
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="dx"></param>
        /// <param name="beta"></param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static GammaSpec<T> gamma<T>(T alpha, T dx, T beta)
            where T : unmanaged
                => new GammaSpec<T>(alpha : alpha, dx : RngMath.recip(beta), beta : beta);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinomialSpec<T> binomial<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (BinomialSpec<T>)src;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinomialSpec<T> binomial<T>(T n, double p)
            where T : unmanaged
                => new BinomialSpec<T>(n,p);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static RVar<T> rvar<T>(IDomainSource src, Interval<T> domain)
            where T : unmanaged
                => new RVar<T>(domain,src);

        /// <summary>
        /// Casts a supplied distribution to a Bernoulli distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BernoulliSpec<T> bernoulli<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (BernoulliSpec<T>)src;

        /// <summary>
        /// Specifies a Bernoulli distribution predicated on the probability of trial success
        /// </summary>
        /// <param name="p">The probability of success</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BernoulliSpec<T> bernoulli<T>(double p)
            where T : unmanaged
                => new BernoulliSpec<T>(p);

        /// <summary>
        /// Interprets a supplied spec as a uniform spec; an error
        /// is raised if the spec does not define a uniform distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> uniform<T>(IDistributionSpec<T> spec)
            where T : unmanaged
                => (UniformSpec<T>)spec;

        /// <summary>
        /// Defines a uniform distribution bound between lower and upper bounds
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> uniform<T>(T min, T max)
            where T : unmanaged
                => new UniformSpec<T>(min,max);

        /// <summary>
        /// Defines a uniform distribution bound to an interval domain
        /// </summary>
        /// <param name="domain">The potential range of sample values</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UniformSpec<T> uniform<T>(in Interval<T> domain)
            where T : unmanaged
                => new UniformSpec<T>(domain);

        /// <summary>
        /// Interprets a supplied spec as a Gaussian spec; an error
        /// is raised if the spec does not define a Gaussian distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static GaussianSpec<T> gaussian<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (GaussianSpec<T>)src;

        /// <summary>
        /// Defines a Gaussian distribution with specified mean and standard deviation
        /// </summary>
        /// <param name="mu">The distribution mean</param>
        /// <param name="sigma">The standard deviation</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static GaussianSpec<T> gaussian<T>(T mu, T sigma)
            where T : unmanaged
                => GaussianSpec<T>.Define(mu,sigma);

        /// <summary>
        /// Interprets a supplied spec as a uniform spec; an error
        /// is raised if the spec does not define a uniform bits distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UniformBitsSpec<T> uniformbits<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (UniformBitsSpec<T>)src;

        /// <summary>
        /// Defines a unform bits distribution
        /// </summary>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UniformBitsSpec<T> uniformbits<T>()
            where T : unmanaged
                => default;
    }
}