//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using K1 = Pow2n1;
    using K2 = Pow2n2;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,2
    /// </summary>
    [Flags]
    public enum Pow2n3 : byte
    {
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
        T02 = 2*T01,

        /// <summary> 
        /// 2^3 - 1 = 7
        /// </summary> 
        T03m1 = 7,
    }
}