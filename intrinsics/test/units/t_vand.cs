//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public class t_vand : IntrinsicTest<t_vand>
    {
        public void vand_128x8i()
            => vand_128_check<sbyte>();

        public void vand_128x8u()
            => vand_128_check<byte>();            

        public void vand_128x16i()
            => vand_128_check<short>();

        public void vand_128x16u()
            => vand_128_check<ushort>();

        public void vand_128x32i()
            => vand_128_check<int>();

        public void vand_128x32u()
            => vand_128_check<uint>();            

        public void vand_128x64i()
            => vand_128_check<long>();            

        public void vand_128x64u()
            => vand_128_check<ulong>();            

        public void vand_256x8i()
            => vand_256_check<sbyte>();

        public void vand_256x8u()
            => vand_256_check<byte>();            

        public void vand_256x16i()
            => vand_256_check<short>();

        public void vand_256x16u()
            => vand_256_check<ushort>();

        public void vand_256x32i()
            => vand_256_check<int>();

        public void vand_256x32u()
            => vand_256_check<uint>();            

        public void vand_256x64i()
            => vand_256_check<long>();            

        public void vand_256x64u()
            => vand_256_check<ulong>();            

        public void and_blocks_128x8i()
            => and_blocks_check<sbyte>(n128);

        public void and_blocks_128x8u()
            => and_blocks_check<byte>(n128);

        public void and_blocks_128x16i()
            => and_blocks_check<short>(n128);

        public void and_blocks_128x16u()
            => and_blocks_check<ushort>(n128);

        public void and_blocks_128x32i()
            => and_blocks_check<int>(n128);

        public void and_blocks_128x32u()
            => and_blocks_check<uint>(n128);

        public void and_blocks_128x64i()
            => and_blocks_check<long>(n128);

        public void and_blocks_128x64u()
            => and_blocks_check<ulong>(n128);

        public void and_blocks_256x8i()
            => and_blocks_check<sbyte>(n256);

        public void and_blocks_256x8u()
            => and_blocks_check<byte>(n256);

        public void and_blocks_256x16i()
            => and_blocks_check<short>(n256);

        public void and_blocks_256x16u()
            => and_blocks_check<ushort>(n256);

        public void and_blocks_256x32i()
            => and_blocks_check<int>(n256);

        public void and_blocks_256x32u()
            => and_blocks_check<uint>(n256);

        public void and_blocks_256x64i()
            => and_blocks_check<long>(n256);

        public void and_blocks_256x64u()
            => and_blocks_check<ulong>(n256);

        void and_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc(blocks,n, default(T));
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.BlockedSpan<T>(n, blocks);
            var rhs = Random.BlockedSpan<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.and(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.and(lhs[i],rhs[i]), dst[i]);
        }

        void and_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc(blocks,n, default(T));
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.BlockedSpan<T>(n, blocks);
            var rhs = Random.BlockedSpan<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.and(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.and(lhs[i],rhs[i]), dst[i]);
        }
     
        void vand_128_check<T>()
            where T : unmanaged
        {
            var N = n128;
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(N);
                var srcY = Random.BlockedSpan<T>(N);
                var vX = ginx.vload(N, in head(srcX));
                var vY = ginx.vload(N, in head(srcY));
                
                var dstExpect = DataBlocks.alloc<T>(N);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(N, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        void vand_256_check<T>()
            where T : unmanaged
        {
            var N = n256;
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(N);
                var srcY = Random.BlockedSpan<T>(N);
                var vX = ginx.vload(N, in head(srcX));
                var vY = ginx.vload(N, in head(srcY));
                var dstExpect = DataBlocks.alloc<T>(N);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(N, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);
                
            }
        }

    }

}