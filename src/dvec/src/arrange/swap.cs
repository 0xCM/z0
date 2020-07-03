//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst; 
    using static V0;
    using static Typed;

    partial class dvec
    {
        // [7      6     5    4     3     2     1     0    ]
        // [15_14 13_12 11_10 09_08 07_06 05_04 03_02 01_00]
        // [2*k + 1 2*k | k=0,..,7]
        // 2 <-> 3
        // [15_14 13_12 11_10 09_08 05_04 07_06 03_02 01_00 ]

        [MethodImpl(Inline), Op]        
        public static Vector128<byte> vswap(Vector128<byte> src, int i, int j)
        {
            var perm = V0.vincrements<byte>(w128);
            perm = perm.Cell(j,(byte)i);
            perm = perm.Cell(i,(byte)j);
            return V0d.vshuf16x8(src,perm);            
        }
        
        [MethodImpl(Inline), Op]        
        public static Vector128<ushort> vswap(Vector128<ushort> src, int i, int j)
        {
            var perm = V0.vincrements<byte>(w128);

            var i0 = Bits.pindex(i, bit.Off);
            var i1 = Bits.pindex(i, bit.On);
            var j0 = Bits.pindex(j, bit.Off);
            var j1 = Bits.pindex(j, bit.On);

            perm = vcell(i0, j0, perm);
            perm = vcell(i1, j1, perm);
            perm = vcell(j0, i0, perm);
            perm = vcell(j1, i1, perm);

            return V0d.vshuf16x8(src,perm);            
        }
    }
}