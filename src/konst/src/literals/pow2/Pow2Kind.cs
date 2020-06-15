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
        P2ᐞ00m1 = K2.T00m1,

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        P2ᐞ00 = K2.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        P2ᐞ01 = K2.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        P2ᐞ02 = K3.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        P2ᐞ03 = K4.T03,

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        P2ᐞ04 = K8.T04,

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        P2ᐞ05 = K8.T05,

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        P2ᐞ06 = K8.T06,

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        P2ᐞ07 = K8.T07,

        /// <summary>
        /// 2^8 = 256 = UInt8.MaxValue + 1
        /// </summary>
        P2ᐞ08 = K16.T08,

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        P2ᐞ09 = K16.T09,

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        P2ᐞ10 = K16.T10,
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        P2ᐞ11 = K16.T11,
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        P2ᐞ12 = K16.T12,

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        P2ᐞ13 = K16.T13,

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        P2ᐞ14 = K16.T14,
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        P2ᐞ15 = K16.T15,

        /// <summary>
        /// 2^16 = 65,536 = UInt16.MaxValue + 1
        /// </summary>
        P2ᐞ16 = K32.T16,
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        P2ᐞ17 = K32.T17,

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        P2ᐞ18 = K32.T18,

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        P2ᐞ19 = K32.T19,

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        P2ᐞ20 = K32.T20,
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        P2ᐞ21 = K32.T21,

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        P2ᐞ22 = K32.T22,

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        P2ᐞ23 = K32.T23,
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        P2ᐞ24 = K32.T24,

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        P2ᐞ25 = K32.T25,
        
        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        P2ᐞ26 = K32.T26,
        
        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        P2ᐞ27 = K32.T27,
        
        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        P2ᐞ28 = K32.T28,
        
        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000,
        /// </summary>
        P2ᐞ29 = K32.T29,
        
        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        P2ᐞ30 = K32.T30,

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        P2ᐞ31 = K32.T31,

        /// <summary>
        /// 2^32 = 4,294,967,296 = 0x100000000
        /// </summary>
        P2ᐞ32 = 2*(long)P2ᐞ31,
                                                         
        /// <summary>
        /// 2^33
        /// </summary>
        P2ᐞ33 = 2*P2ᐞ32,
        
        /// <summary>
        /// 2^34
        /// </summary>
        P2ᐞ34 = 2*P2ᐞ33,
        
        /// <summary>
        /// 2^35
        /// </summary>
        P2ᐞ35 = 2*P2ᐞ34,
        
        /// <summary>
        /// 2^36
        /// </summary>
        P2ᐞ36 = 2*P2ᐞ35,
        
        /// <summary>
        /// 2^37
        /// </summary>
        P2ᐞ37 = 2*P2ᐞ36,
        
        /// <summary>
        /// 2^38
        /// </summary>
        P2ᐞ38 = 2*P2ᐞ37,
        
        /// <summary>
        /// 2^39
        /// </summary>
        P2ᐞ39 = 2*P2ᐞ38,
        
        /// <summary>
        /// 2^40
        /// </summary>
        P2ᐞ40 = 2*P2ᐞ39,
        
        /// <summary>
        /// 2^41
        /// </summary>
        P2ᐞ41 = 2*P2ᐞ40,
        
        /// <summary>
        /// 2^42
        /// </summary>
        P2ᐞ42 = 2*P2ᐞ41,
        
        /// <summary>
        /// 2^43
        /// </summary>
        P2ᐞ43 = 2*P2ᐞ42,
        
        /// <summary>
        /// 2^44
        /// </summary>
        P2ᐞ44 = 2*P2ᐞ43,
        
        /// <summary>
        /// 2^45
        /// </summary>
        P2ᐞ45 = 2*P2ᐞ44,
        
        P2ᐞ46 = 2*P2ᐞ45,

        P2ᐞ47 = 2*P2ᐞ46,
        
        P2ᐞ48 = 2*P2ᐞ47,
        
        P2ᐞ49 = 2*P2ᐞ48,

        P2ᐞ50 = 2*P2ᐞ49,

        P2ᐞ51 = 2*P2ᐞ50,
                
        P2ᐞ52 = 2*P2ᐞ51,

        P2ᐞ53 = 2*P2ᐞ52,

        P2ᐞ54 = 2*P2ᐞ53,

        P2ᐞ55 = 2*P2ᐞ54,

        P2ᐞ56 = 2*P2ᐞ55,

        P2ᐞ57 = 2*P2ᐞ56,

        P2ᐞ58 = 2*P2ᐞ57,

        P2ᐞ59 = 2*P2ᐞ58,
        
        P2ᐞ60 = 2*P2ᐞ59,

        P2ᐞ61 = 2*P2ᐞ60,

        P2ᐞ62 = 2*P2ᐞ61,        

        /// <summary>
        /// T63 = 9223372036854775808 
        /// </summary>
        P2ᐞ63 = 2*(ulong)P2ᐞ62,


        /// <summary> 
        /// 2^1 - 1
        /// </summary> 
        P2ᐞ01m1 = K8.T01m1,

        /// <summary> 
        /// 2^2 - 1
        /// </summary> 
        P2ᐞ02m1 = K8.T02m1,

        /// <summary> 
        /// 2^3 - 1
        /// </summary> 
        P2ᐞ03m1 = K8.T03m1,

        /// <summary> 
        /// 2^4 - 1
        /// </summary> 
        P2ᐞ04m1 = K8.T04m1,

        /// <summary> 
        /// 2^5 - 1
        /// </summary> 
        P2ᐞ05m1 = K8.T05m1,

        /// <summary> 
        /// 2^6 - 1
        /// </summary> 
        P2ᐞ06m1 = K8.T06m1,

        /// <summary> 
        /// 2^7 - 1
        /// </summary> 
        P2ᐞ07m1 = K8.T07m1,

        /// <summary> 
        /// 2^8 - 1
        /// </summary> 
        P2ᐞ08m1 = K8.T08m1,

        /// <summary> 
        /// 2^9 - 1
        /// </summary> 
        P2ᐞ09m1 = K16.T09m1,

        /// <summary> 
        /// 2^10 - 1
        /// </summary> 
        P2ᐞ10m1 = K16.T10m1,
        
        /// <summary> 
        /// 2^11 - 1
        /// </summary> 
        P2ᐞ11m1 = K16.T11m1,
        
        /// <summary> 
        /// 2^12 - 1
        /// </summary> 
        P2ᐞ12m1 = K16.T12m1,

        /// <summary> 
        /// 2^13 - 1
        /// </summary> 
        P2ᐞ13m1 = K16.T13m1,

        P2ᐞ14m1 = K16.T14m1,
        
        P2ᐞ15m1 = K16.T15m1,

        P2ᐞ16m1 = K16.T16m1,
        
        P2ᐞ17m1 = K32.T17m1,

        P2ᐞ18m1 = K32.T18m1,

        P2ᐞ19m1 = K32.T19m1,

        P2ᐞ20m1 = K32.T20m1,
        
        P2ᐞ21m1 = K32.T21m1,

        P2ᐞ22m1 = K32.T22m1,

        P2ᐞ23m1 = K32.T23m1,
        
        P2ᐞ24m1 = K32.T24m1,

        P2ᐞ25m1 = K32.T25m1,
        
        P2ᐞ26m1 = K32.T26m1,
        
        P2ᐞ27m1 = K32.T27m1,
        
        P2ᐞ28m1 = K32.T28m1,
        
        P2ᐞ29m1 = K32.T29m1,
        
        P2ᐞ30m1 = K32.T30m1,
        
        P2ᐞ31m1 = K32.T31m1,

        P2ᐞ32m1 = K32.T32m1,
                                                         
        P2ᐞ33m1 = P2ᐞ33 - 1,
        
        P2ᐞ34m1 = P2ᐞ34 - 1,
        
        P2ᐞ35m1 = P2ᐞ35 - 1,
        
        P2ᐞ36m1 = P2ᐞ36 - 1,
        
        P2ᐞ37m1 = P2ᐞ37 - 1,
        
        P2ᐞ38m1 = P2ᐞ38 - 1,
        
        P2ᐞ39m1 = P2ᐞ39 - 1,
        
        P2ᐞ40m1 = P2ᐞ40 - 1,
        
        P2ᐞ41m1 = P2ᐞ41 - 1,
        
        P2ᐞ42m1 = P2ᐞ42 - 1,
        
        P2ᐞ43m1 = P2ᐞ43 - 1,
        
        P2ᐞ44m1 = P2ᐞ44 - 1,
        
        P2ᐞ45m1 = P2ᐞ45 - 1,
        
        P2ᐞ46m1 = P2ᐞ46 - 1,

        P2ᐞ47m1 = P2ᐞ47 - 1,
        
        P2ᐞ48m1 = P2ᐞ48 - 1,
        
        P2ᐞ49m1 = P2ᐞ49 - 1,

        P2ᐞ50m1 = P2ᐞ50 - 1,

        P2ᐞ51m1 = P2ᐞ51 - 1,
                
        P2ᐞ52m1 = P2ᐞ52 - 1,

        P2ᐞ53m1 = P2ᐞ53 - 1,

        P2ᐞ54m1 = P2ᐞ54 - 1,

        P2ᐞ55m1 = P2ᐞ55 - 1,

        P2ᐞ56m1 = P2ᐞ56 - 1,

        P2ᐞ57m1 = P2ᐞ57 - 1,

        P2ᐞ58m1 = P2ᐞ58 - 1,

        P2ᐞ59m1 = P2ᐞ59 - 1,
        
        P2ᐞ60m1 = P2ᐞ60 - 1,

        P2ᐞ61m1 = P2ᐞ61 - 1,

        P2ᐞ62m1 = P2ᐞ62 - 1,

        P2ᐞ63m1 = long.MaxValue,

        P2ᐞ64m1 = ulong.MaxValue,        

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
        Max64 = P2ᐞ64m1,
    }
}