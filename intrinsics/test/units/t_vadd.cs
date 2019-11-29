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

    public class t_vadd : IntrinsicTest<t_vadd>
    {

        public void add_128x8i()
            => add128_check<sbyte>();

        public void add_128x8u()
            => add128_check<byte>();

        public void add_128x16u()
            => add128_check<ushort>();

        public void add_128x16i()
            => add128_check<short>();

        public void add_128x32i()
            => add128_check<int>();

        public void add_128x32u()
            => add128_check<int>();

        public void add_128x64u()
            => add128_check<ulong>();

        public void and_128x64i()
            => add128_check<long>();

        public void add256()
        {
            add256_check<sbyte>();
            add256_check<byte>();
            add256_check<short>();
            add256_check<ushort>();
            add256_check<int>();
            add256_check<uint>();
            add256_check<long>();
            add256_check<ulong>();

        }

        public void add_blocks_128x8i()
            => add_blocks_check<sbyte>(n128);

        public void add_blocks_128x8u()
            => add_blocks_check<byte>(n128);

        public void add_blocks_128x16i()
            => add_blocks_check<short>(n128);

        public void add_blocks_128x16u()
            => add_blocks_check<ushort>(n128);

        public void add_blocks_128x32i()
            => add_blocks_check<int>(n128);

        public void add_blocks_128x32u()
            => add_blocks_check<uint>(n128);

        public void add_blocks_128x64i()
            => add_blocks_check<long>(n128);

        public void add_blocks_128x64u()
            => add_blocks_check<ulong>(n128);

        public void add_blocks_256x8i()
            => add_blocks_check<sbyte>(n256);

        public void add_blocks_256x8u()
            => add_blocks_check<byte>(n256);

        public void add_blocks_256x16i()
            => add_blocks_check<short>(n256);

        public void add_blocks_256x16u()
            => add_blocks_check<ushort>(n256);

        public void add_blocks_256x32i()
            => add_blocks_check<int>(n256);

        public void add_blocks_256x32u()
            => add_blocks_check<uint>(n256);

        public void add_blocks_256x64i()
            => add_blocks_check<long>(n256);

        public void add_blocks_256x64u()
            => add_blocks_check<ulong>(n256);

        void add_blocks_check<T>(N128 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N128,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.add(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.add(lhs[i],rhs[i]), dst[i]);
        }

        void add_blocks_check<T>(N256 n)
            where T : unmanaged
        {
            var blocks = SampleSize;
            var stats = VBlockStats.Calc<N256,T>(blocks);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var lhs = Random.Blocks<T>(n, blocks);
            var rhs = Random.Blocks<T>(n, blocks);
            var dst = DataBlocks.alloc<T>(n, blocks);
            vblock.add(n, blocks, step, in lhs.Head, in rhs.Head, ref dst.Head);
            for(var i=0; i<cells; i++)
                Claim.eq(gmath.add(lhs[i],rhs[i]), dst[i]);
        }

        void add128_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector128BinOp<T>(ginx.vadd), gmath.add<T>);
            TypeCaseEnd<T>();
        }

        void add256_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector256BinOp<T>(ginx.vadd<T>), gmath.add<T>);
            TypeCaseEnd<T>();
        }

    }

}