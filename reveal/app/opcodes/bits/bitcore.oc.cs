//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
 
    using static zfunc;

    /// <summary>
    /// Opcodes for bitcore-defined operations
    /// </summary>
    [OpCodeProvider]
    public static class bitcore
    {        

        public static BitPos<uint> bitpos_u32(int index)
            => gbits.bitpos(index, HK.u32);

        public static BitPos<uint> bitpos_u32_x(int index)
            => gbits.bitpos<uint>(index);

        public static bit bitmatch_32_32(uint a, byte i, uint b, byte j)
            => gbits.bitmatch(a,i,b,j);

        public static void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
            => gbits.bitseg(src,firstidx,lastidx);


    }

}