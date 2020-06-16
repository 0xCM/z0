//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum Pow2n1m1 : byte
    {
        /// <summary>
        /// 2^0 - 1 = 0
        /// </summary>
        T00m1 = Pow2n1.T00 - 1,

        /// <summary>
        /// 2^1 - 1 = 1
        /// </summary>
        T01m1 = Pow2n1.T01m1 - 1,

        /// <summary> 
        /// 2^2 - 1 = 3
        /// </summary> 
        T02m1 = Pow2n3.T02 - 1,

        /// <summary> 
        /// 2^3 - 1 = 7
        /// </summary> 
        T03m1 = Pow2n4.T03 - 1,

        /// <summary> 
        /// 2^4 - 1 = 15
        /// </summary> 
        T04m1 = Pow2n8.T04 - 1,
    }

    public enum Pow2n2m1 : byte
    {
        /// <summary>
        /// 2^0 - 1 = 0
        /// </summary>
        T00m1 = Pow2n2.T00 - 1,

        /// <summary> 
        /// 2^1 - 1 = 1
        /// </summary> 
        T01m1 = Pow2n2.T01 - 1,
    }
}