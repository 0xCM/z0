//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_vxor : IntrinsicTest<t_vxor>
    {
        public void vxor_128x8i()
            => vxor_check<sbyte>(n128);

        public void vxor_128x8u()
            => vxor_check<byte>(n128);            

        public void vxor_128x16i()
            => vxor_check<short>(n128);

        public void vxor_128x16u()
            => vxor_check<ushort>(n128);

        public void vxor_128x32i()
            => vxor_check<int>(n128);

        public void vxor_128x32u()
            => vxor_check<uint>(n128);            

        public void vxor_128x64i()
            => vxor_check<long>(n128);            

        public void vxor_128x64u()
            => vxor_check<ulong>(n128);            

        public void vxor_256x8i()
            => vxor_check<sbyte>(n256);

        public void vxor_256x8u()
            => vxor_check<byte>(n256);            

        public void vxor_256x16i()
            => vxor_check<short>(n256);

        public void vxor_256x16u()
            => vxor_check<ushort>(n256);

        public void vxor_256x32i()
            => vxor_check<int>(n256);

        public void vxor_256x32u()
            => vxor_check<uint>(n256);            

        public void vxor_256x64i()
            => vxor_check<long>(n256);            

        public void vxor_256x64u()
            => vxor_check<ulong>(n256);            

        public void vxor_blocks_128x8i()
            => vxor_blocks_check<sbyte>(n128);

        public void vxor_blocks_256x8i()
            => vxor_blocks_check<sbyte>(n256);

        public void vxor_blocks_128x8u()
            => vxor_blocks_check<byte>(n128);

        public void vxor_blocks_128x16i()
            => vxor_blocks_check<short>(n128);

        public void vxor_blocks_128x16u()
            => vxor_blocks_check<ushort>(n128);

        public void vxor_blocks_128x32i()
            => vxor_blocks_check<int>(n128);

        public void vxor_blocks_128x32u()
            => vxor_blocks_check<uint>(n128);

        public void vxor_blocks_128x64i()
            => vxor_blocks_check<long>(n128);

        public void vxor_blocks_128x64u()
            => vxor_blocks_check<ulong>(n128);

        public void vxor_blocks_256x8u()
            => vxor_blocks_check<byte>(n256);

        public void vxor_blocks_256x16i()
            => vxor_blocks_check<short>(n256);

        public void vxor_blocks_256x16u()
            => vxor_blocks_check<ushort>(n256);

        public void vxor_blocks_256x32i()
            => vxor_blocks_check<int>(n256);

        public void vxor_blocks_256x32u()
            => vxor_blocks_check<uint>(n256);

        public void vxor_blocks_256x64i()
            => vxor_blocks_check<long>(n256);

        public void vxor_blocks_256x64u()
            => vxor_blocks_check<ulong>(n256);

        void vxor_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N128,T>(blocks);
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.BlockedSpan<T>(n, blocks);
            var rhs = Random.BlockedSpan<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.xor(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(lhs[i],rhs[i]), dst[i]);

        }


        void vxor_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.BlockedSpan<T>(n, blocks);
            var rhs = Random.BlockedSpan<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            
            vblock.xor(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(lhs[i],rhs[i]), dst[i]);
        }
     
        void vxor_check<T>(N128 n)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(n);
                var srcY = Random.BlockedSpan<T>(n);
                var vX = srcX.TakeVector();
                var vY = srcY.TakeVector();
                
                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.xor(srcX[i], srcY[i]);
                
                var expect = dstExpect.TakeVector();
                var actual = ginx.vxor(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        void vxor_check<T>(N256 n)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(n);
                var srcY = Random.BlockedSpan<T>(n);
                var vX = srcX.TakeVector();
                var vY = srcY.TakeVector();

                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.xor(srcX[i], srcY[i]);
                
                var expect = dstExpect.TakeVector();
                var actual = ginx.vxor(vX,vY);
                Claim.eq(expect,actual);
                
            }
        } 
    }
}
