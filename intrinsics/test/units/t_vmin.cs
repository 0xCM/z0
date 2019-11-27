//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vmin : IntrinsicTest<t_vmin>
    {
        public void min_128x8i()
            => min_check<sbyte>(n128);

        public void min_128x8u()
            => min_check<byte>(n128);

        public void min_128x16i()
            => min_check<short>(n128);

        public void min_128x16u()
            => min_check<ushort>(n128);

        public void min_128x32i()
            => min_check<int>(n128);

        public void min_128x32u()
            => min_check<uint>(n128);

        public void min_128x64i()
            => min_check<long>(n128);

        public void min_128x64u()
            => min_check<ulong>(n128);

        public void min_256x8i()
            => min_check<sbyte>(n256);

        public void min_256x8u()
            => min_check<byte>(n256);

        public void min_256x16i()
            => min_check<short>(n256);

        public void min_256x16u()
            => min_check<ushort>(n256);

        public void min_256x32i()
            => min_check<int>(n256);

        public void min_256x32u()
            => min_check<uint>(n256);

        public void min_256x64i()
            => min_check<long>(n256);

        public void min_256x64u()
            => min_check<ulong>(n256);

        public void min_block_28x8i()
            => min_block_check<sbyte>(n128);

        public void min_block_128x8u()
            => min_block_check<byte>(n128);

        public void min_block_128x16i()
            => min_block_check<short>(n128);

        public void min_block_128x16u()
            => min_block_check<ushort>(n128);

        public void min_block_128x32i()
            => min_block_check<int>(n128);

        public void min_block_128x32u()
            => min_block_check<uint>(n128);

        public void min_block_128x64i()
            => min_block_check<long>(n128);

        public void min_block_128x64u()
            => min_block_check<ulong>(n128);

        public void min_block_128x32f()
            => min_block_check<float>(n128);

        public void min_block_128x64f()
            => min_block_check<double>(n128);

        public void min_block_256x8i()
            => min_block_check<sbyte>(n256);

        public void min_block_256x8u()
            => min_block_check<byte>(n256);

        public void min_block_256x16i()
            => min_block_check<short>(n256);

        public void min_block_256x16u()
            => min_block_check<ushort>(n256);

        public void min_block_256x32i()
            => min_block_check<int>(n256);

        public void min_block_256x32u()
            => min_block_check<uint>(n256);

        public void min_block_256x64i()
            => min_block_check<long>(n256);

        public void min_block_256x64u()
            => min_block_check<ulong>(n256);

        public void min_block_256x32f()
            => min_block_check<float>(n256);

        public void min_block_256x64f()
            => min_block_check<double>(n256);

        public void min_check<T>(N256 n)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.alloc<T>(n);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.min(xs[i],ys[i]);
                
                var expect = zs.TakeVector();                
                var actual = ginx.vmin(x,y);
                Claim.eq(expect,actual);                
            }
        }

        public void min_check<T>(N128 n)
            where T : unmanaged
        {
            for(var sample=0; sample<SampleSize; sample++)
            {
                var x = Random.CpuVector<T>(n);
                var y = Random.CpuVector<T>(n);

                var xs = x.ToSpan();
                var ys = y.ToSpan();
                var zs = DataBlocks.alloc<T>(n);
                for(var i=0; i<zs.CellCount; i++)
                    zs[i] = gmath.min(xs[i],ys[i]);
                
                var expect = zs.TakeVector();                
                var actual = ginx.vmin(x,y);
                Claim.eq(expect,actual);                
            }
        }


        void min_block_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc(blocks,n, default(T));
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.min(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

        void min_block_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc(blocks,n, default(T));
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.min(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.min(lhs[i],rhs[i]), dst[i]);
        }

    }

}