//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;

    public enum VslPoissonMethod
    {
        ///<summary>
        /// Pif lambda>=27, acceptance/rejection method is used with decomposition onto 4 regions:
        /// - 2 parallelograms;
        /// - triangle;
        /// - left exponential tail;
        /// - right exponential tail.
        /// othewise table lookup method is used        
        ///</summary>
        PTPE  =   0,
        
        ///<summary>
        ///for lambda>=1 method is based on Poisson inverse CDF approximation by 
        /// Gaussian inverse CDF; for lambda < 1 table lookup method is used.    
        ///</summary>
        POISNORM  = 1
    }
}