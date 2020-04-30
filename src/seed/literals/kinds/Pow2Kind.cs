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
    using K32 = Pow2Kind32;

    /// <summary>
    /// Defines primal-representable powers of 2 and integers of the form 2^n - 1 where n = 0,..,64
    /// </summary>
    [Flags]
    public enum Pow2Kind : ulong
    {
        /// <summary> 
        /// 2^0 - 1 = 0
        /// </summary> 
        T00m1 = K2.T00m1,

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        T00 = K2.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        T01 = K2.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        T02 = K3.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        T03 = K4.T03,

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
        T16 = K32.T16,
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        T17 = K32.T17,

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        T18 = K32.T18,

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        T19 = K32.T19,

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        T20 = K32.T20,
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        T21 = K32.T21,

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        T22 = K32.T22,

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        T23 = K32.T23,
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        T24 = K32.T24,

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        T25 = K32.T25,
        
        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        T26 = K32.T26,
        
        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        T27 = K32.T27,
        
        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        T28 = K32.T28,
        
        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000,
        /// </summary>
        T29 = K32.T29,
        
        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        T30 = K32.T30,

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        T31 = K32.T31,

        /// <summary>
        /// 2^32 = 4,294,967,296 = 0x100000000
        /// </summary>
        T32 = 2*(long)T31,
                                                         
        /// <summary>
        /// 2^33
        /// </summary>
        T33 = 2*T32,
        
        /// <summary>
        /// 2^34
        /// </summary>
        T34 = 2*T33,
        
        /// <summary>
        /// 2^35
        /// </summary>
        T35 = 2*T34,
        
        /// <summary>
        /// 2^36
        /// </summary>
        T36 = 2*T35,
        
        /// <summary>
        /// 2^37
        /// </summary>
        T37 = 2*T36,
        
        /// <summary>
        /// 2^38
        /// </summary>
        T38 = 2*T37,
        
        /// <summary>
        /// 2^39
        /// </summary>
        T39 = 2*T38,
        
        /// <summary>
        /// 2^40
        /// </summary>
        T40 = 2*T39,
        
        /// <summary>
        /// 2^41
        /// </summary>
        T41 = 2*T40,
        
        /// <summary>
        /// 2^42
        /// </summary>
        T42 = 2*T41,
        
        /// <summary>
        /// 2^43
        /// </summary>
        T43 = 2*T42,
        
        /// <summary>
        /// 2^44
        /// </summary>
        T44 = 2*T43,
        
        /// <summary>
        /// 2^45
        /// </summary>
        T45 = 2*T44,
        
        T46 = 2*T45,

        T47 = 2*T46,
        
        T48 = 2*T47,
        
        T49 = 2*T48,

        T50 = 2*T49,

        T51 = 2*T50,
                
        T52 = 2*T51,

        T53 = 2*T52,

        T54 = 2*T53,

        T55 = 2*T54,

        T56 = 2*T55,

        T57 = 2*T56,

        T58 = 2*T57,

        T59 = 2*T58,
        
        T60 = 2*T59,

        T61 = 2*T60,

        T62 = 2*T61,        

        /// <summary>
        /// T63 = 9223372036854775808 
        /// </summary>
        T63 = 2*(ulong)T62,


        /// <summary> 
        /// 2^1 - 1
        /// </summary> 
        T01m1 = K8.T01m1,

        /// <summary> 
        /// 2^2 - 1
        /// </summary> 
        T02m1 = K8.T02m1,

        /// <summary> 
        /// 2^3 - 1
        /// </summary> 
        T03m1 = K8.T03m1,

        /// <summary> 
        /// 2^4 - 1
        /// </summary> 
        T04m1 = K8.T04m1,

        /// <summary> 
        /// 2^5 - 1
        /// </summary> 
        T05m1 = K8.T05m1,

        /// <summary> 
        /// 2^6 - 1
        /// </summary> 
        T06m1 = K8.T06m1,

        /// <summary> 
        /// 2^7 - 1
        /// </summary> 
        T07m1 = K8.T07m1,

        /// <summary> 
        /// 2^8 - 1
        /// </summary> 
        T08m1 = K8.T08m1,

        /// <summary> 
        /// 2^9 - 1
        /// </summary> 
        T09m1 = K16.T09m1,

        /// <summary> 
        /// 2^10 - 1
        /// </summary> 
        T10m1 = K16.T10m1,
        
        /// <summary> 
        /// 2^11 - 1
        /// </summary> 
        T11m1 = K16.T11m1,
        
        /// <summary> 
        /// 2^12 - 1
        /// </summary> 
        T12m1 = K16.T12m1,

        /// <summary> 
        /// 2^13 - 1
        /// </summary> 
        T13m1 = K16.T13m1,

        T14m1 = K16.T14m1,
        
        T15m1 = K16.T15m1,

        T16m1 = K16.T16m1,
        
        T17m1 = K32.T17m1,

        T18m1 = K32.T18m1,

        T19m1 = K32.T19m1,

        T20m1 = K32.T20m1,
        
        T21m1 = K32.T21m1,

        T22m1 = K32.T22m1,

        T23m1 = K32.T23m1,
        
        T24m1 = K32.T24m1,

        T25m1 = K32.T25m1,
        
        T26m1 = K32.T26m1,
        
        T27m1 = K32.T27m1,
        
        T28m1 = K32.T28m1,
        
        T29m1 = K32.T29m1,
        
        T30m1 = K32.T30m1,
        
        T31m1 = K32.T31m1,

        T32m1 = K32.T32m1,
                                                         
        T33m1 = T33 - 1,
        
        T34m1 = T34 - 1,
        
        T35m1 = T35 - 1,
        
        T36m1 = T36 - 1,
        
        T37m1 = T37 - 1,
        
        T38m1 = T38 - 1,
        
        T39m1 = T39 - 1,
        
        T40m1 = T40 - 1,
        
        T41m1 = T41 - 1,
        
        T42m1 = T42 - 1,
        
        T43m1 = T43 - 1,
        
        T44m1 = T44 - 1,
        
        T45m1 = T45 - 1,
        
        T46m1 = T46 - 1,

        T47m1 = T47 - 1,
        
        T48m1 = T48 - 1,
        
        T49m1 = T49 - 1,

        T50m1 = T50 - 1,

        T51m1 = T51 - 1,
                
        T52m1 = T52 - 1,

        T53m1 = T53 - 1,

        T54m1 = T54 - 1,

        T55m1 = T55 - 1,

        T56m1 = T56 - 1,

        T57m1 = T57 - 1,

        T58m1 = T58 - 1,

        T59m1 = T59 - 1,
        
        T60m1 = T60 - 1,

        T61m1 = T61 - 1,

        T62m1 = T62 - 1,

        T63m1 = long.MaxValue,

        T64m1 = ulong.MaxValue,        

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
        Max32 = K32.Max32,
        
        /// <summary> 
        /// The maximum value representable by a 64-bit unsigned integer
        /// </summary> 
        Max64 = T64m1,
    }
}