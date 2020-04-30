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
    using K8 = Pow2Kind8;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,15 and of the form  2^n - 1 where n = 0,..,16
    /// </summary>
    [Flags]
    public enum Pow2Kind16 : ushort
    {
        /// <summary> 
        /// 2^0 - 1 = 0
        /// </summary> 
        T00m1 = K8.T00m1,

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        T00 = K8.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        T01 = K8.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        T02 = K8.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        T03 = K8.T03,

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        T04 = K8.T04,

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        T05 = K8.T05,

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        T06 = K8.T06,

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        T07 = K8.T07,

        /// <summary>
        /// 2^8 = 256 = UInt8.MaxValue + 1
        /// </summary>
        T08 = 2*T07,

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        T09 = 2*T08,

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        T10 = 2*T09,
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        T11 = 2*T10,
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        T12 = 2*T11,

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        T13 = 2*T12,

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        T14 = 2*T13,
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        T15 = 2*T14,

        /// <summary> 
        /// 2^1 - 1
        /// </summary> 
        T01m1 = T01 - 1,

        /// <summary> 
        /// 2^2 - 1
        /// </summary> 
        T02m1 = T02 - 1,

        /// <summary> 
        /// 2^3 - 1
        /// </summary> 
        T03m1 = T03 - 1,

        /// <summary> 
        /// 2^4 - 1
        /// </summary> 
        T04m1 = T04 - 1,

        /// <summary> 
        /// 2^5 - 1
        /// </summary> 
        T05m1 = T05 - 1,

        /// <summary> 
        /// 2^6 - 1
        /// </summary> 
        T06m1 = T06 - 1,

        /// <summary> 
        /// 2^7 - 1
        /// </summary> 
        T07m1 = (byte)sbyte.MaxValue,

        /// <summary> 
        /// 2^8 - 1
        /// </summary> 
        T08m1 = byte.MaxValue,
        
        /// <summary> 
        /// 2^9 - 1
        /// </summary> 
        T09m1 = T09 - 1,

        /// <summary> 
        /// 2^10 - 1
        /// </summary> 
        T10m1 = T10 - 1,
        
        /// <summary> 
        /// 2^11 - 1
        /// </summary> 
        T11m1 = T11 - 1,
        
        /// <summary> 
        /// 2^12 - 1
        /// </summary> 
        T12m1 = T12 - 1,

        /// <summary> 
        /// 2^13 - 1
        /// </summary> 
        T13m1 = T13 - 1,

        /// <summary> 
        /// 2^14 - 1
        /// </summary> 
        T14m1 = T14 - 1,
        
        /// <summary> 
        /// 2^15 - 1
        /// </summary> 
        T15m1 = (ushort)short.MaxValue, 

        /// <summary> 
        /// 2^16 - 1
        /// </summary> 
        T16m1 = ushort.MaxValue, 

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
        Max8 = K8.Max8,

        /// <summary> 
        /// The maximum value representable by a 16-bit unsigned integer
        /// </summary> 
        Max16 = T16m1,
    }
}