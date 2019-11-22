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
            Claim.eq(4, Block128<int>.CellSize);
            Claim.eq(1, Block128.cellsize<sbyte>());
            Claim.eq(1, Block128.cellsize<byte>());
            Claim.eq(2, Block128.cellsize<short>());
            Claim.eq(4, Block128.cellsize<int>());
            Claim.eq(4, Block128.cellsize<uint>());
            Claim.eq(4, Block128.cellsize<float>());
            Claim.eq(8, Block128.cellsize<ulong>());
            Claim.eq(8, Block128.cellsize<double>());
            Claim.eq(8, Block128.cellsize<long>());


            Claim.eq(4, Block256<int>.CellSize);
            Claim.eq(1, Block256.cellsize<sbyte>());
            Claim.eq(1, Block256.cellsize<byte>());
            Claim.eq(2, Block256.cellsize<short>());
            Claim.eq(4, Block256.cellsize<int>());
            Claim.eq(4, Block256.cellsize<uint>());
            Claim.eq(4, Block256.cellsize<float>());
            Claim.eq(8, Block256.cellsize<ulong>());
            Claim.eq(8, Block256.cellsize<double>());
            Claim.eq(8, Block256.cellsize<long>());

        }

        public void BlockSize()
        {
            Claim.eq(16, Block128<int>.BlockSize);
            Claim.eq(16, Block128.blocksize<sbyte>());          
            Claim.eq(16, Block128.blocksize<byte>());          
            Claim.eq(16, Block128.blocksize<short>());            
            Claim.eq(16, Block128.blocksize<int>());            
            Claim.eq(16, Block128.blocksize<float>());          
            Claim.eq(16, Block128.blocksize<double>());          
            Claim.eq(16, Block128.blocksize<long>());          

            Claim.eq(32, Block256<int>.BlockSize);
            Claim.eq(32, Block256.blocksize<sbyte>());          
            Claim.eq(32, Block256.blocksize<byte>());          
            Claim.eq(32, Block256.blocksize<short>());            
            Claim.eq(32, Block256.blocksize<int>());            
            Claim.eq(32, Block256.blocksize<float>());          
            Claim.eq(32, Block256.blocksize<double>());          
            Claim.eq(32, Block256.blocksize<long>());          

        }

        public void BlockLength()
        {
            Claim.eq(4, Block128<int>.BlockLength);
            Claim.eq(16, Block128.blocklen<sbyte>());
            Claim.eq(16, Block128.blocklen<byte>());
            Claim.eq(8, Block128.blocklen<short>());
            Claim.eq(8, Block128.blocklen<ushort>());
            Claim.eq(4, Block128.blocklen<int>());
            Claim.eq(4, Block128.blocklen<uint>());
            Claim.eq(2, Block128.blocklen<long>());
            Claim.eq(2, Block128.blocklen<ulong>());
            Claim.eq(4, Block128.blocklen<float>());
            Claim.eq(2, Block128.blocklen<double>());                
            Claim.eq(8, Block128.blocklen<int>(2));
            Claim.eq(4, Block128.blocklen<long>(2));
            Claim.eq(32, Block128.blocklen<byte>(2));


            Claim.eq(8, Block256<int>.BlockLength);
            Claim.eq(32, Block256.blocklen<sbyte>());
            Claim.eq(32, Block256.blocklen<byte>());
            Claim.eq(16, Block256.blocklen<short>());
            Claim.eq(16, Block256.blocklen<ushort>());
            Claim.eq(8, Block256.blocklen<int>());
            Claim.eq(8, Block256.blocklen<uint>());
            Claim.eq(4, Block256.blocklen<long>());
            Claim.eq(4, Block256.blocklen<ulong>());
            Claim.eq(8, Block256.blocklen<float>());
            Claim.eq(4, Block256.blocklen<double>());                
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
            var x = Block128.load(span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);            
            Claim.eq(block0,Block128.load(span(1,2,3,4)));

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.eq(block2,Block128.FromParts(5,6,7,8));

        }
        public void Load1()
        {
            var x = Block128.load(span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, Block128.FromParts(1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
            var blocklen = Block128<int>.BlockLength;                     
            var src = Random.ReadOnlySpan128<int>(blocks);
            var dst = Block128.alloc<int>(blocks);

            Claim.eq(src.Length, dst.Length);

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            Claim.eq(src,dst);

        }


        public void Fill2()
        {
            var blockX = Block128.alloc<int>((int?)1);
            blockX[0] = 1;
            blockX[1] = 2;
            blockX[2] = 3;
            blockX[3] = 4;

            var blockY = Block128.load(blockX.Data);
            Claim.eq(blockX, blockY);

        }

    }


}