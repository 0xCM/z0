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
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [OpCodeProvider]
    public static class vblockops
    {
     
        public static ref readonly uint reftest_1(in uint x, in uint y, ref uint z)
        {
            z = x + y;
            return ref z;
        }
            
        public static ref uint reftest_2(in uint x, in uint y, ref uint z)
        {
            z = x + y;
            return ref z;
        }

        
        public static ref readonly Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
            => ref vblocks.vbsll(a,3,dst);

        public static ReadOnlySpan<short> spanconvert(Span<short> src)
            => src;

   }
}