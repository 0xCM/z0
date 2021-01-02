//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using K = Pow2Literals;

    /// <summary>
    /// Defines primal-representable powers of 2 and integers of the form 2^n - 1 where n = 0,..,64
    /// </summary>
    [Flags, LiteralSet(typeof(Pow2))]
    public enum Pow2x64 : ulong
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        P2ᐞ00 = K.T00,

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        P2ᐞ01 = K.T01,

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        P2ᐞ02 = K.T02,

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        P2ᐞ03 = K.T03,

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        P2ᐞ04 = K.T04,

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        P2ᐞ05 = K.T05,

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        P2ᐞ06 = K.T06,

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        P2ᐞ07 = K.T07,

        /// <summary>
        /// 2^8 = 256
        /// </summary>
        P2ᐞ08 = K.T08,

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        P2ᐞ09 = K.T09,

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        P2ᐞ10 = K.T10,

        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        P2ᐞ11 = K.T11,

        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        P2ᐞ12 = K.T12,

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        P2ᐞ13 = K.T13,

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        P2ᐞ14 = K.T14,

        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        P2ᐞ15 = K.T15,

        /// <summary>
        /// 2^16 = 65,536
        /// </summary>
        P2ᐞ16 = K.T16,

        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        P2ᐞ17 = K.T17,

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        P2ᐞ18 = K.T18,

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        P2ᐞ19 = K.T19,

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        P2ᐞ20 = K.T20,

        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        P2ᐞ21 = K.T21,

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        P2ᐞ22 = K.T22,

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        P2ᐞ23 = K.T23,

        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        P2ᐞ24 = K.T24,

        /// <summary>
        /// 2^25 = 33,554,432
        /// </summary>
        P2ᐞ25 = K.T25,

        /// <summary>
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        P2ᐞ26 = K.T26,

        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        P2ᐞ27 = K.T27,

        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        P2ᐞ28 = K.T28,

        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000,
        /// </summary>
        P2ᐞ29 = K.T29,

        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        P2ᐞ30 = K.T30,

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        P2ᐞ31 = K.T31,

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
    }
}