//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;

    public enum VslRngMethod
    {
        VSL_RNG_METHOD_UNIFORM_STD = 0,
        
        VSL_RNG_METHOD_UNIFORMBITS32_STD = 0, 
        
        VSL_RNG_METHOD_UNIFORMBITS64_STD = 0,

        /// <summary>
        /// Generates normally distributed random number x thru the pair of uniformly distributed numbers u1 and u2 according to the formula:
        /// x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER = 0,

        /// <summary>
        /// Generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly distributed numbers u1 and u2
        /// according to the formula 
        /// x1=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// NOTE: implementation correctly works with odd vector lengths
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2 = 1, 

        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>       
        VSL_RNG_METHOD_GAUSSIAN_ICDF = 2,

        VSL_RNG_METHOD_ACCURACY_FLAG  = (1<<30),

        VSL_RNG_METHOD_GAMMA_GNORM = 0,

        VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE = VSL_RNG_METHOD_GAMMA_GNORM | VSL_RNG_METHOD_ACCURACY_FLAG,
    }
}