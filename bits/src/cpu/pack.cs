//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    
    partial class CpuBits
    {         


        //pack 32 1-bit values from 32 8-bit segments
        [MethodImpl(Inline)]
        public static uint vpack32x1x8(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n256, in head(src)));
            x = ginx.vsll(x,7);
            return ginx.vmovemask(x);
        }

        //pack 16 1-bit values from 16 8-bit segments
        [MethodImpl(Inline)]
        public static ushort vpack16x1x8(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n128, in head(src)));
            x = ginx.vsll(x,7);
            return (ushort)ginx.vmovemask(x);
        }

        //pack 8 1-bit values from 8 8-bit segments
        [MethodImpl(Inline)]
        public static byte vpack8x1x8(ReadOnlySpan<byte> src)
        {
            var x = ginx.vscalar(n128, head64(src));
            x = ginx.vsll(x,7);
            return (byte)ginx.vmovemask(x);
        }
    }
}