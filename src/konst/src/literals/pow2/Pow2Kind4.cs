//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K1 = Pow2Kind1;
    using K2 = Pow2Kind2;
    using K3 = Pow2Kind3;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,3 and of the form  2^n - 1 where n = 0,..,4
    /// </summary>
    [Flags]
    public enum Pow2Kind4 : byte
    {
        /// <summary> 
        /// 2^0 - 1 = 0
        /// </summary> 
        T00m1 = K1.T00m1,

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        T00 = K1.T00,

        /// <summary> 
        /// 2^1 - 1 = 1
        /// </summary> 
        T01m1 = K1.T01m1,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        T01 = K2.T01,

        /// <summary> 
        /// 2^2 - 1 = 3
        /// </summary> 
        T02m1 = K2.T02m1,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        T02 = K3.T02,

        /// <summary> 
        /// 2^3 - 1 = 7
        /// </summary> 
        T03m1 = K3.T03m1,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        T03 = 2*T02,
  
        /// <summary> 
        /// 2^4 - 1
        /// </summary> 
        T04m1 = 15,

        /// <summary> 
        /// The maximum value representable by a 1-bit unsigned integer
        /// </summary> 
        Max1 = K1.Max1,

        /// <summary> 
        /// The maximum value representable by a 2-bit unsigned integer
        /// </summary> 
        Max2 = K2.Max2,

        /// <summary> 
        /// The maximum value representable by a 3-bit unsigned integer
        /// </summary> 
        Max3 = K3.Max3,

        /// <summary> 
        /// The maximum value representable by a 4-bit unsigned integer
        /// </summary> 
        Max4 = T04m1,
    }
}