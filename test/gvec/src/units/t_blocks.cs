//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_blocks : t_inx<t_blocks>
    {
        public  void check_cellsize()
        {
            Claim.eq(1, BufferBlocks.cellsize<sbyte>());
            Claim.eq(1, BufferBlocks.cellsize<byte>());
            Claim.eq(2, BufferBlocks.cellsize<short>());
            Claim.eq(4, BufferBlocks.cellsize<int>());
            Claim.eq(4, BufferBlocks.cellsize<uint>());
            Claim.eq(4, BufferBlocks.cellsize<float>());
            Claim.eq(8, BufferBlocks.cellsize<ulong>());
            Claim.eq(8, BufferBlocks.cellsize<double>());
            Claim.eq(8, BufferBlocks.cellsize<long>());


            Claim.eq(1, BufferBlocks.cellsize<sbyte>());
            Claim.eq(1, BufferBlocks.cellsize<byte>());
            Claim.eq(2, BufferBlocks.cellsize<short>());
            Claim.eq(4, BufferBlocks.cellsize<int>());
            Claim.eq(4, BufferBlocks.cellsize<uint>());
            Claim.eq(4, BufferBlocks.cellsize<float>());
            Claim.eq(8, BufferBlocks.cellsize<ulong>());
            Claim.eq(8, BufferBlocks.cellsize<double>());
            Claim.eq(8, BufferBlocks.cellsize<long>());
        }


        public void check_blocklength_128()
        {
            N128 n = default;
            Claim.eq(16, BufferBlocks.blocklength<sbyte>(n));
            Claim.eq(16, BufferBlocks.blocklength<byte>(n));
            Claim.eq(8, BufferBlocks.blocklength<short>(n));
            Claim.eq(8, BufferBlocks.blocklength<ushort>(n));
            Claim.eq(4, BufferBlocks.blocklength<int>(n));
            Claim.eq(4, BufferBlocks.blocklength<uint>(n));
            Claim.eq(2, BufferBlocks.blocklength<long>(n));
            Claim.eq(2, BufferBlocks.blocklength<ulong>(n));
            Claim.eq(4, BufferBlocks.blocklength<float>(n));
            Claim.eq(2, BufferBlocks.blocklength<double>(n));
            Claim.eq(8, BufferBlocks.cellblocks<int>(n,2));
            Claim.eq(4, BufferBlocks.cellblocks<long>(n, 2));
            Claim.eq(32, BufferBlocks.cellblocks<byte>(n, 2));


        }

        public void check_blocklength_256()
        {
            N256 n = default;
            Claim.eq(32, BufferBlocks.blocklength<sbyte>(n));
            Claim.eq(32, BufferBlocks.blocklength<byte>(n));
            Claim.eq(16, BufferBlocks.blocklength<short>(n));
            Claim.eq(16, BufferBlocks.blocklength<ushort>(n));
            Claim.eq(8, BufferBlocks.blocklength<int>(n));
            Claim.eq(8, BufferBlocks.blocklength<uint>(n));
            Claim.eq(4, BufferBlocks.blocklength<long>(n));
            Claim.eq(4, BufferBlocks.blocklength<ulong>(n));
            Claim.eq(8, BufferBlocks.blocklength<float>(n));
            Claim.eq(4, BufferBlocks.blocklength<double>(n));
        }


        public void check_block_slice()
        {
            var x = BufferBlocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);
            var y = BufferBlocks.safeload(n128, span(1,2,3,4));
            Claim.Eq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.Eq(block2, BufferBlocks.parts(n128,5,6,7,8));

        }

        public void check_safeload()
        {
            var x = BufferBlocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, BufferBlocks.parts(n128,1,2,3,4,5,6,7,8));
        }

        public void check_block_alloc()
        {

            var w = w128;
            var count = Pow2.T08;

            var src = Random.Blocks<int>(w, count);
            var dst = BufferBlocks.alloc<int>(w, count);

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