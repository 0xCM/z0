//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K1 = Pow2Kind1;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,1 and of the form  2^n - 1 where n = 0,..,2
    /// </summary>
    [Flags]
    public enum Pow2Kind2 : byte
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
        T01 = 2*T00,

        /// <summary> 
        /// 2^2 - 1 = 3
        /// </summary> 
        T02m1 = 3,

        /// <summary> 
        /// The maximum value representable by a 1-bit unsigned integer
        /// </summary> 
        Max1 = T01m1,

        /// <summary> 
        /// The maximum value representable by a 2-bit unsigned integer
        /// </summary> 
        Max2 = T02m1,
    }
}