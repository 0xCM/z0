//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    
    partial class CpuBits
    {         
        /// <summary>
        /// Packs 32 1-bit values
        /// </summary>
        [MethodImpl(Inline)]
        public static uint vpack32x1(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n256, in head(src)));
            x = ginx.vsll(x,7);
            return ginx.vtakemask(x);
        }

        /// <summary>
        /// Pack 16 1-bit values
        /// </summary>
        /// <param name="src">The pack source</param>
        [MethodImpl(Inline)]
        public static ushort vpack16x1(ReadOnlySpan<byte> src)
        {
            var x = v64u(ginx.vload(n128, in head(src)));
            x = ginx.vsll(x,7);
            return ginx.vtakemask(x);
        }

        /// <summary>
        /// Pack 8 1-bit values
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]
        public static byte vpack8x1(ReadOnlySpan<byte> src)
        {
            var x = ginx.vscalar(n128, head64(src));
            x = ginx.vsll(x,7);
            return (byte)ginx.vtakemask(x);
        }

        /// <summary>
        /// Packs 32 1-bit values from each block
        /// </summary>
        /// <param name="src">The pack source</param>
        /// <param name="dst">The pack target</param>
        [MethodImpl(Inline)]
        public static void vpack32x1(in ConstBlock256<byte> src, Span<uint> dst)
        {
            ref var target = ref head(dst);
            var blocks = math.min(src.BlockCount,dst.Length);
            for(var i=0; i<blocks; i++)
                seek(ref target, i) = ginx.vtakemask(ginx.vsll(src.LoadVector(i),7));                
        }
    }
}