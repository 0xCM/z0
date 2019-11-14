//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vnegate : IntrinsicTest<t_vnegate>
    {

        public void negate_128x8i()
            => negate_128_check<sbyte>();

        public void negate_128x16i()
            => negate_128_check<short>();

        public void negate_128x16u()
            => negate_128_check<ushort>();

        public void negate_128x32i()
        {
            negate_128_check<int>();
        }

        public void negate_128x32u()
        {
            negate_128_check<uint>();
        }

        public void negate_128x64i()
        {
            negate_128_check<long>();
        }

        public void negate_128x64u()
        {
            negate_128_check<ulong>();
        }

        public void negate_128x32f()
            => negate_128_check<float>();

        public void negate_128x64f()
            => negate_128_check<double>();

        public void negate_256x8i()
        {
            negate_256_check<sbyte>();
        }

        public void negate_256x8u()
        {
            negate_256_check<byte>();
        }

        public void negate_256x16i()
        {
            negate_256_check<short>();
        }

        public void negate_256x16u()
        {
            negate_256_check<ushort>();
        }

        public void negate_256x32i()
        {
            negate_256_check<int>();
        }

        public void negate_256x32u()
        {
            negate_256_check<uint>();
        }

        public void negate_256x64i()
        {
            negate_256_check<long>();
        }

        public void negate_256x64u()
        {
            negate_256_check<ulong>();
        }

        public void negate_256x32f()
            => negate_256_check<float>();

        public void negate_256x64f()
            => negate_256_check<double>();

        public void negate_blocks_256x8i()
            => negate_blocks_check<sbyte>(n256);

        public void negate_blocks_256x8u()
            => negate_blocks_check<byte>(n256);

        public void negate_blocks_256x16i()
            => negate_blocks_check<short>(n256);

        public void negate_blocks_256x16u()
            => negate_blocks_check<ushort>(n256);

        public void negate_blocks_256x32i()
            => negate_blocks_check<int>(n256);

        public void negate_blocks_256x32u()
            => negate_blocks_check<uint>(n256);

        public void negate_blocks_256x64i()
            => negate_blocks_check<long>(n256);

        public void negate_blocks_256x64u()
            => negate_blocks_check<ulong>(n256);

        void negate_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.StepSize;
            var cells = stats.CellCount;

            var src = Random.BlockedSpan<T>(n, blocks);
            var dst = BlockedSpan.alloc<T>(n, blocks);
            vblock.negate(n, blocks, step, in src.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.negate(src[i]), dst[i]);
        }

        void negate_128_check<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(n);
                Claim.eq(y,z);
            }
        }

        void negate_256_check<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(n);
                Claim.eq(y,z);
            }

        }

    }

}