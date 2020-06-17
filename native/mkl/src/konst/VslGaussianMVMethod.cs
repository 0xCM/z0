//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;

    using static VslRngMethod;

    /// <summary>
    ///  Multivariate (correlated) normal random number generator is based on uncorrelated 
    /// Gaussian random number generator (see vslsRngGaussian and vsldRngGaussian functions)
    /// </summary>
    public enum VslGaussianMVMethod
    {
        /// <summary>
        /// BOXMULLER  generates normally distributed random number x thru the pair of uniformly distributed 
        /// numbers u1 and u2 according to the formula: x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>
        BoxMuller1 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER,

        /// <summary>
        /// generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly 
        /// dustributed numbers u1 and u2 according to the formula x1=sqrt(-ln(u1))*sin(2*Pi*u2) 
        /// and x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// </summary>
        BoxMuller2 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2,
        
        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>
        ICDF    = VSL_RNG_METHOD_GAUSSIAN_ICDF 
    }
}