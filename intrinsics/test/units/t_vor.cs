//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using D = GDel;

    public class t_vor : IntrinsicTest<t_vor>
    {

        public void vor_128x8i()
            => vor_check<sbyte>(n128);

        public void vor_128x8u()
            => vor_check<byte>(n128);            

        public void vor_128x16i()
            => vor_check<short>(n128);

        public void vor_128x16u()
            => vor_check<ushort>(n128);

        public void vor_128x32i()
            => vor_check<int>(n128);

        public void vor_128x32u()
            => vor_check<uint>(n128);            

        public void vor_128x64i()
            => vor_check<long>(n128);            

        public void vor_128x64u()
            => vor_check<ulong>(n128);            

        public void vor_256x8i()
            => vor_check<sbyte>(n256);

        public void vor_256x8u()
            => vor_check<byte>(n256);            

        public void vor_256x16i()
            => vor_check<short>(n256);

        public void vor_256x16u()
            => vor_check<ushort>(n256);

        public void vor_256x32i()
            => vor_check<int>(n256);

        public void vor_256x32u()
            => vor_check<uint>(n256);            

        public void vor_256x64i()
            => vor_check<long>(n256);            

        public void vor_256x64u()
            => vor_check<ulong>(n256);            

        public void vor_blocks_128x8i()
            => vor_blocks_check<sbyte>(n128);

        public void vor_blocks_256x8i()
            => vor_blocks_check<sbyte>(n256);

        public void vor_blocks_128x8u()
            => vor_blocks_check<byte>(n128);

        public void vor_blocks_128x16i()
            => vor_blocks_check<short>(n128);

        public void vor_blocks_128x16u()
            => vor_blocks_check<ushort>(n128);

        public void vor_blocks_128x32i()
            => vor_blocks_check<int>(n128);

        public void vor_blocks_128x32u()
            => vor_blocks_check<uint>(n128);

        public void vor_blocks_128x64i()
            => vor_blocks_check<long>(n128);

        public void vor_blocks_128x64u()
            => vor_blocks_check<ulong>(n128);

        public void vor_blocks_256x8u()
            => vor_blocks_check<byte>(n256);

        public void vor_blocks_256x16i()
            => vor_blocks_check<short>(n256);

        public void vor_blocks_256x16u()
            => vor_blocks_check<ushort>(n256);

        public void vor_blocks_256x32i()
            => vor_blocks_check<int>(n256);

        public void vor_blocks_256x32u()
            => vor_blocks_check<uint>(n256);

        public void vor_blocks_256x64i()
            => vor_blocks_check<long>(n256);

        public void vor_blocks_256x64u()
            => vor_blocks_check<ulong>(n256);

        void vor_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N128,T>(blocks);
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            
            vblock.or(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);

        }


        void vor_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            
            vblock.or(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.or(lhs[i],rhs[i]), dst[i]);
        }
     
        void vor_check<T>(N128 n)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.TakeVector();
                var vY = srcY.TakeVector();
                
                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.TakeVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        void vor_check<T>(N256 n)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.TakeVector();
                var vY = srcY.TakeVector();

                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.or(srcX[i], srcY[i]);
                
                var expect = dstExpect.TakeVector();
                var actual = ginx.vor(vX,vY);
                Claim.eq(expect,actual);
                
            }
        } 
    }
}
