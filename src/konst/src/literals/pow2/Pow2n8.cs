//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K4 = Pow2n4;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,7
    /// </summary>
    [Flags]
    public enum Pow2n8 : byte
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        T00 = K4.T00,

        /// <summary> 
        /// 2^1 - 1
        /// </summary> 
        T01m1 = K4.T01m1,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        T01 = K4.T01,

        /// <summary> 
        /// 2^2 - 1
        /// </summary> 
        T02m1 = K4.T02m1,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        T02 = K4.T02,

        /// <summary> 
        /// 2^3 - 1
        /// </summary> 
        T03m1 = K4.T03m1,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        T03 = K4.T03,

        /// <summary> 
        /// 2^4 - 1
        /// </summary> 
        T04m1 = K4.T04m1,

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        T04 = 2*T03,

        /// <summary> 
        /// 2^5 - 1
        /// </summary> 
        T05m1 = T05 - 1,

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        T05 = 2*T04,

        /// <summary> 
        /// 2^6 - 1
        /// </summary> 
        T06m1 = T06 - 1,

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        T06 = 2*T05,

        /// <summary> 
        /// 2^7 - 1
        /// </summary> 
        T07m1 = (byte)sbyte.MaxValue,

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        T07 = 2*T06,
 
        /// <summary> 
        /// 2^8 - 1
        /// </summary> 
        T08m1 = byte.MaxValue,
    }
}