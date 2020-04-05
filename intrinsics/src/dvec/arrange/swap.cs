//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Core;

    partial class dvec
    {
        // [7      6     5    4     3     2     1     0    ]
        // [15_14 13_12 11_10 09_08 07_06 05_04 03_02 01_00]
        // [2*k + 1 2*k | k=0,..,7]
        // 2 <-> 3
        // [15_14 13_12 11_10 09_08 05_04 07_06 03_02 01_00 ]

        [MethodImpl(Inline)]        
        public static Vector128<byte> vswap(Vector128<byte> src, int i, int j)
        {
            var perm = Data.vincrements<byte>(n128);
            perm = perm.Cell(j,(byte)i);
            perm = perm.Cell(i,(byte)j);
            return vshuf16x8(src,perm);            
        }
        
        public static Vector128<ushort> vswap(Vector128<ushort> src, int i, int j)
        {
            var perm = Data.vincrements<byte>(n128);

            static byte index8x16(int i, bit parity)
                => uint8(i*2 + (int)parity);

            var i0 = index8x16(i,bit.Off);
            var i1 = index8x16(i,bit.On);

            var j0 = index8x16(j,bit.Off);
            var j1 = index8x16(j,bit.On);

            perm = vcell(i0, j0, perm);
            perm = vcell(i1, j1, perm);
            perm = vcell(j0, i0, perm);
            perm = vcell(j1, i1, perm);

            return vshuf16x8(src,perm);            
        }
    }
}