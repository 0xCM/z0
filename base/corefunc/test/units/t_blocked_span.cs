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

    
    public class t_blocked_span : UnitTest<t_blocked_span>
    {
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


        public void db_blocksize_128()
        {
            const int size = 16;
            N128 n = default;

            Claim.eq(size, DataBlocks.blocksize<sbyte>(n));          
            Claim.eq(size, DataBlocks.blocksize<byte>(n));          
            Claim.eq(size, DataBlocks.blocksize<short>(n));            
            Claim.eq(size, DataBlocks.blocksize<int>(n));            
            Claim.eq(size, DataBlocks.blocksize<float>(n));          
            Claim.eq(size, DataBlocks.blocksize<double>(n));          
            Claim.eq(size, DataBlocks.blocksize<long>(n));          
        }

        public void db_blocksize_256()
        {
            const int size = 32;
            N256 n = default;

            Claim.eq(size, DataBlocks.blocksize<sbyte>(n));          
            Claim.eq(size, DataBlocks.blocksize<byte>(n));          
            Claim.eq(size, DataBlocks.blocksize<short>(n));            
            Claim.eq(size, DataBlocks.blocksize<int>(n));            
            Claim.eq(size, DataBlocks.blocksize<float>(n));          
            Claim.eq(size, DataBlocks.blocksize<double>(n));          
            Claim.eq(size, DataBlocks.blocksize<long>(n));          

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
            Claim.eq(8, DataBlocks.blocklen<int>(n,2));
            Claim.eq(4, DataBlocks.blocklen<long>(n, 2));
            Claim.eq(32, DataBlocks.blocklen<byte>(n, 2));


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
            Claim.eq(1, Block128.fullblocks<sbyte>(16));
            Claim.eq(1, Block128.fullblocks<byte>(16));

            Claim.eq(1, Block128.fullblocks<short>(8));
            Claim.eq(1, Block128.fullblocks<ushort>(8));

            Claim.eq(1, Block128.fullblocks<int>(4));
            Claim.eq(1, Block128.fullblocks<uint>(4));
            Claim.eq(1, Block128.fullblocks<float>(4));

            Claim.eq(1, Block128.fullblocks<long>(2));
            Claim.eq(1, Block128.fullblocks<ulong>(2));
            Claim.eq(1, Block128.fullblocks<double>(2));

            Claim.eq(1, Block256.fullblocks<sbyte>(32));
            Claim.eq(1, Block256.fullblocks<byte>(32));

            Claim.eq(1, Block256.fullblocks<short>(16));
            Claim.eq(1, Block256.fullblocks<ushort>(16));

            Claim.eq(1, Block256.fullblocks<int>(8));
            Claim.eq(1, Block256.fullblocks<uint>(8));
            Claim.eq(1, Block256.fullblocks<float>(8));

            Claim.eq(1, Block256.fullblocks<long>(4));
            Claim.eq(1, Block256.fullblocks<ulong>(4));
            Claim.eq(1, Block256.fullblocks<double>(4));
        }


        public void Alignment()
        {

            Claim.eq(4, Block128.align<int>(4));
            Claim.yea(Block128.aligned<int>(4));

            Claim.eq(8, Block128.align<int>(5));
            Claim.nea(Block128.aligned<int>(5));

            Claim.eq(8, Block128.align<int>(6));
            Claim.nea(Block128.aligned<int>(6));

            Claim.eq(8, Block128.align<int>(7));
            Claim.nea(Block128.aligned<int>(7));

            Claim.eq(8, Block128.align<int>(8));
            Claim.yea(Block128.aligned<int>(8));

            Claim.eq(12, Block128.align<int>(9));
            Claim.nea(Block128.aligned<int>(9));

        }

        public void BlockSlice()
        {
            var x = DataBlocks.load(n128,span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);   
            var y = DataBlocks.load(n128,span(1,2,3,4));         
            Claim.eq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.eq(block2,Block128.FromParts(5,6,7,8));

        }
        public void Load1()
        {
            var x = DataBlocks.load(n128,span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, Block128.FromParts(1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
            var blocklen = Block128<int>.BlockLength;                     
            var src = Random.ConstBlocks<int>(n128,blocks);
            var dst = DataBlocks.alloc<int>(n128,blocks);

            Claim.eq(src.Length, dst.Length);

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            Claim.eq(src,dst);

        }

    }

}