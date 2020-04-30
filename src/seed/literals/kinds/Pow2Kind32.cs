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
    using K16 = Pow2Kind16;

    /// <summary>
    /// Defines integers of the form 2^n where n = 0,..,31 and of the form  2^n - 1 where n = 0,..,32
    /// </summary>
    [Flags]
    public enum Pow2Kind32 : uint
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
        T08 = K16.T08,

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        T09 = K16.T09,

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        T10 = K16.T10,
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        T11 = K16.T11,
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        T12 = K16.T12,

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        T13 = K16.T13,

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        T14 = K16.T14,
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        T15 = K16.T15,

        /// <summary>
        /// 2^16 = 65,536 = UInt16.MaxValue + 1
        /// </summary>
        T16 = 2*T15,
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        T17 = 2*T16,

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        T18 = 2*T17,

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        T19 = 2*T18,

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        T20 = 2*T19,
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        T21 = 2*T20,

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        T22 = 2*T21,

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        T23 = 2*T22,
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        T24 = 2*T23,

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        T25 = 2*T24,
        
        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        T26 = 2*T25,
        
        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        T27 = 2*T26,
        
        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        T28 = 2*T27,
        
        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000,
        /// </summary>
        T29 = 2*T28,
        
        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        T30 = 2*T29,

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        T31 = 2*(uint)T30,


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
        /// 2^17 - 1
        /// </summary> 
        T17m1 = T17 - 1,

        /// <summary> 
        /// 2^18 - 1
        /// </summary> 
        T18m1 = T18 - 1,

        /// <summary> 
        /// 2^19 - 1
        /// </summary> 
        T19m1 = T19 - 1,

        T20m1 = T20 - 1,
        
        T21m1 = T21 - 1,

        T22m1 = T22 - 1,

        T23m1 = T23 - 1,
        
        T24m1 = T24 - 1,

        T25m1 = T25 - 1,
        
        T26m1 = T26 - 1,
        
        T27m1 = T27 - 1,
        
        T28m1 = T28 - 1,
        
        T29m1 = T29 - 1,
        
        T30m1 = T30 - 1,
        
        T31m1 = int.MaxValue, 

        T32m1 = uint.MaxValue, 

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
        Max5 = K8.T05m1,

        /// <summary> 
        /// The maximum value representable by a 6-bit unsigned integer
        /// </summary> 
        Max6 = K8.T06m1,

        /// <summary> 
        /// The maximum value representable by a 7-bit unsigned integer
        /// </summary> 
        Max7 = K8.T07m1,

        /// <summary> 
        /// The maximum value representable by an 8-bit unsigned integer
        /// </summary> 
        Max8 = K8.Max8,

        /// <summary> 
        /// The maximum value representable by a 16-bit unsigned integer
        /// </summary> 
        Max16 = K16.Max16,
  
        /// <summary> 
        /// The maximum value representable by a 32-bit unsigned integer
        /// </summary> 
        Max32 = T32m1,
    }
}