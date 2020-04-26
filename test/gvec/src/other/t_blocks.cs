//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public class t_blocks : t_inx<t_blocks>
    {                

        public  void CellSize()
        {
            Claim.eq(1, Blocks.cellsize<sbyte>());
            Claim.eq(1, Blocks.cellsize<byte>());
            Claim.eq(2, Blocks.cellsize<short>());
            Claim.eq(4, Blocks.cellsize<int>());
            Claim.eq(4, Blocks.cellsize<uint>());
            Claim.eq(4, Blocks.cellsize<float>());
            Claim.eq(8, Blocks.cellsize<ulong>());
            Claim.eq(8, Blocks.cellsize<double>());
            Claim.eq(8, Blocks.cellsize<long>());


            Claim.eq(1, Blocks.cellsize<sbyte>());
            Claim.eq(1, Blocks.cellsize<byte>());
            Claim.eq(2, Blocks.cellsize<short>());
            Claim.eq(4, Blocks.cellsize<int>());
            Claim.eq(4, Blocks.cellsize<uint>());
            Claim.eq(4, Blocks.cellsize<float>());
            Claim.eq(8, Blocks.cellsize<ulong>());
            Claim.eq(8, Blocks.cellsize<double>());
            Claim.eq(8, Blocks.cellsize<long>());
        }


        public void db_blocklen_128()
        {
            N128 n = default;
            Claim.eq(16, Blocks.length<sbyte>(n));
            Claim.eq(16, Blocks.length<byte>(n));
            Claim.eq(8, Blocks.length<short>(n));
            Claim.eq(8, Blocks.length<ushort>(n));
            Claim.eq(4, Blocks.length<int>(n));
            Claim.eq(4, Blocks.length<uint>(n));
            Claim.eq(2, Blocks.length<long>(n));
            Claim.eq(2, Blocks.length<ulong>(n));
            Claim.eq(4, Blocks.length<float>(n));
            Claim.eq(2, Blocks.length<double>(n));                
            Claim.eq(8, Blocks.cellblocks<int>(n,2));
            Claim.eq(4, Blocks.cellblocks<long>(n, 2));
            Claim.eq(32, Blocks.cellblocks<byte>(n, 2));


        }

        public void db_blocklen_256()
        {
            N256 n = default;
            Claim.eq(32, Blocks.length<sbyte>(n));
            Claim.eq(32, Blocks.length<byte>(n));
            Claim.eq(16, Blocks.length<short>(n));
            Claim.eq(16, Blocks.length<ushort>(n));
            Claim.eq(8, Blocks.length<int>(n));
            Claim.eq(8, Blocks.length<uint>(n));
            Claim.eq(4, Blocks.length<long>(n));
            Claim.eq(4, Blocks.length<ulong>(n));
            Claim.eq(8, Blocks.length<float>(n));
            Claim.eq(4, Blocks.length<double>(n));                

        }


        public void BlockSlice()
        {
            var x = Blocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);   
            var y = Blocks.safeload(n128, span(1,2,3,4));         
            Claim.eq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.eq(block2, Blocks.parts(n128,5,6,7,8));

        }
        public void Load1()
        {
            var x = Blocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.eq(x, Blocks.parts(n128,1,2,3,4,5,6,7,8));
            
        }

        public void alloc_blocks()
        {

            var w = w128;
            var count = Pow2.T08;   
                        
            var src = Random.Blocks<int>(w, count);
            var dst = Blocks.alloc<int>(w, count);

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