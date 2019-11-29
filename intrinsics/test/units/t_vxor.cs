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
        protected override int CycleCount
            => Pow2.T12;

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
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var xb = Random.Blocks<T>(n, blocks);
            var yb = Random.Blocks<T>(n, blocks);
            var zb = DataBlocks.alloc<T>(n, blocks);
            vblock.xor(n, blocks, step, in xb.Head, in yb.Head, ref zb.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
            
            zb.Clear();
            vblock.xor(xb, yb, zb);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }

        public void vxor_bench_256x32u()
            => vxor_bench<uint>(n256);

        public void vxor_bench_256x8u()
            => vxor_bench<byte>(n256);

        public void vxor_bench_256x64u()
            => vxor_bench<ulong>(n256);

        void vxor_bench<T>(N256 n)
            where T : unmanaged
        {
            xor_gmath_bench<T>(n);
            xor_intrinsic_bench<T>(n);
        }

        void xor_gmath_bench<T>(N256 n, SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_gmath_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(n);
            var xb = Random.Blocks<T>(n,blocks);
            var yb = Random.Blocks<T>(n,blocks);
            var zb = DataBlocks.alloc<T>(n,blocks);
            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
            {                
                for(var block = 0; block< blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    zb.Block(block)[cell] = gmath.xor(xb.Block(block)[cell], yb.Block(block)[cell]);                                    
            }
            counter.Stop();
            Benchmark(opname, counter,opcount);
        }

        void xor_intrinsic_bench<T>(N256 n, SystemCounter counter = default)
            where T : unmanaged
        {
            var opname = $"xor_ginx_{moniker<T>()}";
            var blocks = 8;
            var blocklen = DataBlocks.blocklen<T>(n);
            var xb = Random.Blocks<T>(n,blocks);
            var yb = Random.Blocks<T>(n,blocks);
            var zb = DataBlocks.alloc<T>(n,blocks);
            var opcount = 0;
            var cellcount = xb.CellCount;

            counter.Start();
            for(var i=0; i<CycleCount; i++, opcount += cellcount)
                vblock.xor(xb, yb, zb);
            counter.Stop();
            Benchmark(opname, counter,opcount);

        }

        protected void vxor_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var xb = Random.Blocks<T>(n, blocks);
            var yb = Random.Blocks<T>(n, blocks);
            var zb = DataBlocks.alloc<T>(n, blocks);
            
            vblock.xor(n, blocks, step, in xb.Head, in yb.Head, ref zb.Head);
            
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);

            zb.Clear();
            vblock.xor(xb, yb, zb);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.xor(xb[i],yb[i]), zb[i]);
        }

        protected void vxor_check<T>(N128 n)
            where T : unmanaged
        {
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();
                
                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.xor(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vxor(vX,vY);
                Claim.eq(expect,actual);                
            }
        }

        protected void vxor_check<T>(N256 n)
            where T : unmanaged
        {            
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.Blocks<T>(n);
                var srcY = Random.Blocks<T>(n);
                var vX = srcX.LoadVector();
                var vY = srcY.LoadVector();

                var dstExpect = DataBlocks.alloc<T>(n);
                for(var i=0; i< dstExpect.CellCount; i++)
                    dstExpect[i] = gmath.xor(srcX[i], srcY[i]);
                
                var expect = dstExpect.LoadVector();
                var actual = ginx.vxor(vX,vY);
                Claim.eq(expect,actual);
                
            }
        } 
    }
}
