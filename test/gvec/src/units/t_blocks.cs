//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public class t_blocks_svc : WfService<t_blocks_svc>
    {

    }

    public class t_blocks : t_inx<t_blocks>
    {
        public void check_cellsize()
        {
            Claim.eq(1, size<sbyte>());
            Claim.eq(1, size<byte>());
            Claim.eq(2, size<short>());
            Claim.eq(4, size<int>());
            Claim.eq(4, size<uint>());
            Claim.eq(4, size<float>());
            Claim.eq(8, size<ulong>());
            Claim.eq(8, size<double>());
            Claim.eq(8, size<long>());

            Claim.eq(1, size<sbyte>());
            Claim.eq(1, size<byte>());
            Claim.eq(2, size<short>());
            Claim.eq(4, size<int>());
            Claim.eq(4, size<uint>());
            Claim.eq(4, size<float>());
            Claim.eq(8, size<ulong>());
            Claim.eq(8, size<double>());
            Claim.eq(8, size<long>());
        }


        public void check_blocklength_128()
        {
            N128 n = default;
            Claim.eq(16, BlockCalcs.blocklength<sbyte>(n));
            Claim.eq(16, BlockCalcs.blocklength<byte>(n));
            Claim.eq(8, BlockCalcs.blocklength<short>(n));
            Claim.eq(8, BlockCalcs.blocklength<ushort>(n));
            Claim.eq(4, BlockCalcs.blocklength<int>(n));
            Claim.eq(4, BlockCalcs.blocklength<uint>(n));
            Claim.eq(2, BlockCalcs.blocklength<long>(n));
            Claim.eq(2, BlockCalcs.blocklength<ulong>(n));
            Claim.eq(4, BlockCalcs.blocklength<float>(n));
            Claim.eq(2, BlockCalcs.blocklength<double>(n));
            Claim.eq(8, BlockCalcs.cellblocks<int>(n,2));
            Claim.eq(4, BlockCalcs.cellblocks<long>(n, 2));
            Claim.eq(32, BlockCalcs.cellblocks<byte>(n, 2));
        }

        public void check_blocklength_256()
        {
            var n = w256;
            Claim.eq(32, BlockCalcs.blocklength<sbyte>(n));
            Claim.eq(32, BlockCalcs.blocklength<byte>(n));
            Claim.eq(16, BlockCalcs.blocklength<short>(n));
            Claim.eq(16, BlockCalcs.blocklength<ushort>(n));
            Claim.eq(8, BlockCalcs.blocklength<int>(n));
            Claim.eq(8, BlockCalcs.blocklength<uint>(n));
            Claim.eq(4, BlockCalcs.blocklength<long>(n));
            Claim.eq(4, BlockCalcs.blocklength<ulong>(n));
            Claim.eq(8, BlockCalcs.blocklength<float>(n));
            Claim.eq(4, BlockCalcs.blocklength<double>(n));
        }

        public void check_block_slice()
        {
            var x = SpanBlocks.safeload(w128, array<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);
            var y = SpanBlocks.safeload(w128, array(1,2,3,4));
            Claim.eq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.eq(block2, SpanBlocks.parts(w128,5,6,7,8));
        }

        public void check_safeload()
        {
            var x = SpanBlocks.safeload(w128, array<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, SpanBlocks.parts(w128,1,2,3,4,5,6,7,8));
        }

        public void check_block_alloc()
        {
            var w = w128;
            var count = Pow2.T08;

            var src = Random.SpanBlocks<int>(w, count);
            var dst = SpanBlocks.alloc<int>(w, count);

            Claim.eq(src.CellCount, dst.CellCount);
            var blocklen = src.BlockLength;

            for(int block = 0, idx = 0; block<count; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];
            }

            Claim.eq(src,dst);
        }
    }
}