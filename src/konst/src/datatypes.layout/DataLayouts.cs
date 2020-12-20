//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /*
    Taken from: https://planetmath.org/goodhashtableprimes
    Partition Range :    Prime
    --------------------------------
    [2^5, 2^6):53
    [2^6, 2^7):97
    [2^7, 2^8):193
    [2^8, 2^9):389
    [2^9, 2^10 	769
    [2^10, 2^11) 	1543
    [2^11, 2^12) 	3079
    [2^12, 2^13) 	6151
    [2^13, 2^14) 	12289
    [2^14, 2^15) 	24593
    [2^15, 2^16) 	49157
    [2^16, 2^17) 	98317
    [2^17, 2^18) 	196613
    [2^18, 2^19) 	393241
    [2^19, 2^20) 	786433
    [2^20, 2^21) 	1572869
    [2^21, 2^22) 	3145739
    [2^22, 2^23) 	6291469
    [2^23, 2^24) 	12582917
    [2^24, 2^25) 	25165843
    [2^25, 2^26) 	50331653
    [2^26, 2^27) 	100663319
    [2^27, 2^28) 	201326611
    [2^28, 2^29) 	402653189
    [2^29, 2^30) 	805306457
    [2^30, 2^31) 	1610612741
    */

    public readonly struct HashPrimes
    {

    }
    [ApiHost]
    public readonly partial struct DataLayouts
    {
        const NumericKind Closure = UnsignedInts;

        // [Op]
        // public static DataLayout<CorSigField> coresig()
        // {
        //     var id = identify(0, CorSigField.None);
        //     var p0 = partition(0, CorSigField.CallingConvention, 0, 3);
        //     return specify(0, id, p0);
        // }
    }
}