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

    public class t_blocks : UnitTest<t_blocks>
    {
        

        public void db_16_basecase()
        {
            
            var b1 = Random.Blocks<byte>(n16,64);
            var b2 = b1.As<ulong>();
            Claim.eq(b1.BitCount, b2.BitCount);
            
        }

        
        public  void CellSize()
        {
            Claim.eq(1, DataBlocks.cellsize<sbyte>());
            Claim.eq(1, DataBlocks.cellsize<byte>());
            Claim.eq(2, DataBlocks.cellsize<short>());
            Claim.eq(4, DataBlocks.cellsize<int>());
            Claim.eq(4, DataBlocks.cellsize<uint>());
            Claim.eq(4, DataBlocks.cellsize<float>());
            Claim.eq(8, DataBlocks.cellsize<ulong>());
            Claim.eq(8, DataBlocks.cellsize<double>());
            Claim.eq(8, DataBlocks.cellsize<long>());


            Claim.eq(1, DataBlocks.cellsize<sbyte>());
            Claim.eq(1, DataBlocks.cellsize<byte>());
            Claim.eq(2, DataBlocks.cellsize<short>());
            Claim.eq(4, DataBlocks.cellsize<int>());
            Claim.eq(4, DataBlocks.cellsize<uint>());
            Claim.eq(4, DataBlocks.cellsize<float>());
            Claim.eq(8, DataBlocks.cellsize<ulong>());
            Claim.eq(8, DataBlocks.cellsize<double>());
            Claim.eq(8, DataBlocks.cellsize<long>());

        }


        public void db_blocklen_128()
        {
            N128 n = default;
            Claim.eq(16, DataBlocks.blocklen<sbyte>(n));
            Claim.eq(16, DataBlocks.blocklen<byte>(n));
            Claim.eq(8, DataBlocks.blocklen<short>(n));
            Claim.eq(8, DataBlocks.blocklen<ushort>(n));
            Claim.eq(4, DataBlocks.blocklen<int>(n));
            Claim.eq(4, DataBlocks.blocklen<uint>(n));
            Claim.eq(2, DataBlocks.blocklen<long>(n));
            Claim.eq(2, DataBlocks.blocklen<ulong>(n));
            Claim.eq(4, DataBlocks.blocklen<float>(n));
            Claim.eq(2, DataBlocks.blocklen<double>(n));                
            Claim.eq(8, DataBlocks.blockedcells<int>(n,2));
            Claim.eq(4, DataBlocks.blockedcells<long>(n, 2));
            Claim.eq(32, DataBlocks.blockedcells<byte>(n, 2));


        }

        public void db_blocklen_256()
        {
            N256 n = default;
            Claim.eq(32, DataBlocks.blocklen<sbyte>(n));
            Claim.eq(32, DataBlocks.blocklen<byte>(n));
            Claim.eq(16, DataBlocks.blocklen<short>(n));
            Claim.eq(16, DataBlocks.blocklen<ushort>(n));
            Claim.eq(8, DataBlocks.blocklen<int>(n));
            Claim.eq(8, DataBlocks.blocklen<uint>(n));
            Claim.eq(4, DataBlocks.blocklen<long>(n));
            Claim.eq(4, DataBlocks.blocklen<ulong>(n));
            Claim.eq(8, DataBlocks.blocklen<float>(n));
            Claim.eq(4, DataBlocks.blocklen<double>(n));                

        }

        public void BlockCount()
        {
            Claim.eq(1, DataBlocks.wholeblocks<sbyte>(n128,16));
            Claim.eq(1, DataBlocks.wholeblocks<byte>(n128,16));

            Claim.eq(1, DataBlocks.wholeblocks<short>(n128,8));
            Claim.eq(1, DataBlocks.wholeblocks<ushort>(n128,8));

            Claim.eq(1, DataBlocks.wholeblocks<int>(n128,4));
            Claim.eq(1, DataBlocks.wholeblocks<uint>(n128,4));
            Claim.eq(1, DataBlocks.wholeblocks<float>(n128,4));

            Claim.eq(1, DataBlocks.wholeblocks<long>(n128,2));
            Claim.eq(1, DataBlocks.wholeblocks<ulong>(n128,2));
            Claim.eq(1, DataBlocks.wholeblocks<double>(n128,2));

            Claim.eq(1, DataBlocks.wholeblocks<sbyte>(n256, 32));
            Claim.eq(1, DataBlocks.wholeblocks<byte>(n256, 32));

            Claim.eq(1, DataBlocks.wholeblocks<short>(n256, 16));
            Claim.eq(1, DataBlocks.wholeblocks<ushort>(n256, 16));

            Claim.eq(1, DataBlocks.wholeblocks<int>(n256, 8));
            Claim.eq(1, DataBlocks.wholeblocks<uint>(n256, 8));
            Claim.eq(1, DataBlocks.wholeblocks<float>(n256, 8));

            Claim.eq(1, DataBlocks.wholeblocks<long>(n256, 4));
            Claim.eq(1, DataBlocks.wholeblocks<ulong>(n256, 4));
            Claim.eq(1, DataBlocks.wholeblocks<double>(n256, 4));
        }

        public void BlockSlice()
        {
            var x = DataBlocks.safeload(n128,span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.CellCount);   
            var y = DataBlocks.safeload(n128,span(1,2,3,4));         
            Claim.eq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.CellCount);
            Claim.eq(block2,DataBlocks.parts(n128,5,6,7,8));

        }
        public void Load1()
        {
            var x = DataBlocks.safeload(n128,span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, DataBlocks.parts(n128,1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
                        
            var src = Random.Blocks<int>(n128,blocks).ReadOnly();
            var dst = DataBlocks.alloc<int>(n128,blocks);

            Claim.eq(src.CellCount, dst.CellCount);
            var blocklen = src.BlockLength;

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            Claim.eq(src,dst);

        }

    }

}