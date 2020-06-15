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
    using K4 = Pow2Kind4;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,7 and of the form  2^n - 1 where n = 0,..,8
    /// </summary>
    [Flags]
    public enum Pow2Kind8 : byte
    {
        /// <summary> 
        /// 2^0 - 1 = 0
        /// </summary> 
        T00m1 = K4.T00m1,

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
        Max4 = K4.Max4,
 
        /// <summary> 
        /// The maximum value representable by a 5-bit unsigned integer
        /// </summary> 
        Max5 = T05m1,

        /// <summary> 
        /// The maximum value representable by a 6-bit unsigned integer
        /// </summary> 
        Max6 = T06m1,

        /// <summary> 
        /// The maximum value representable by a 7-bit unsigned integer
        /// </summary> 
        Max7 = T07m1,

        /// <summary> 
        /// The maximum value representable by an 8-bit unsigned integer
        /// </summary> 
        Max8 = T08m1,
    }
}