//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_blocks : t_identity<t_blocks>
    {        
        
        public  void CellSize()
        {
            Claim.eq(1, blocks.cellsize<sbyte>());
            Claim.eq(1, blocks.cellsize<byte>());
            Claim.eq(2, blocks.cellsize<short>());
            Claim.eq(4, blocks.cellsize<int>());
            Claim.eq(4, blocks.cellsize<uint>());
            Claim.eq(4, blocks.cellsize<float>());
            Claim.eq(8, blocks.cellsize<ulong>());
            Claim.eq(8, blocks.cellsize<double>());
            Claim.eq(8, blocks.cellsize<long>());


            Claim.eq(1, blocks.cellsize<sbyte>());
            Claim.eq(1, blocks.cellsize<byte>());
            Claim.eq(2, blocks.cellsize<short>());
            Claim.eq(4, blocks.cellsize<int>());
            Claim.eq(4, blocks.cellsize<uint>());
            Claim.eq(4, blocks.cellsize<float>());
            Claim.eq(8, blocks.cellsize<ulong>());
            Claim.eq(8, blocks.cellsize<double>());
            Claim.eq(8, blocks.cellsize<long>());

        }


        public void db_blocklen_128()
        {
            N128 n = default;
            Claim.eq(16, blocks.blocklen<sbyte>(n));
            Claim.eq(16, blocks.blocklen<byte>(n));
            Claim.eq(8, blocks.blocklen<short>(n));
            Claim.eq(8, blocks.blocklen<ushort>(n));
            Claim.eq(4, blocks.blocklen<int>(n));
            Claim.eq(4, blocks.blocklen<uint>(n));
            Claim.eq(2, blocks.blocklen<long>(n));
            Claim.eq(2, blocks.blocklen<ulong>(n));
            Claim.eq(4, blocks.blocklen<float>(n));
            Claim.eq(2, blocks.blocklen<double>(n));                
            Claim.eq(8, blocks.blockedcells<int>(n,2));
            Claim.eq(4, blocks.blockedcells<long>(n, 2));
            Claim.eq(32, blocks.blockedcells<byte>(n, 2));


        }

        public void db_blocklen_256()
        {
            N256 n = default;
            Claim.eq(32, blocks.blocklen<sbyte>(n));
            Claim.eq(32, blocks.blocklen<byte>(n));
            Claim.eq(16, blocks.blocklen<short>(n));
            Claim.eq(16, blocks.blocklen<ushort>(n));
            Claim.eq(8, blocks.blocklen<int>(n));
            Claim.eq(8, blocks.blocklen<uint>(n));
            Claim.eq(4, blocks.blocklen<long>(n));
            Claim.eq(4, blocks.blocklen<ulong>(n));
            Claim.eq(8, blocks.blocklen<float>(n));
            Claim.eq(4, blocks.blocklen<double>(n));                

        }


        public void BlockSlice()
        {
            var x = blocks.safeload(n128,span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            Claim.eq(4, block0.Length);   
            var y = blocks.safeload(n128,span(1,2,3,4));         
            Claim.numeq(block0, y);

            var block2 = x.Block(1);
            Claim.eq(4, block2.Length);
            Claim.numeq(block2,blocks.parts(n128,5,6,7,8));

        }
        public void Load1()
        {
            var x = blocks.safeload(n128,span<int>(1,2,3,4,5,6,7,8));
            Claim.eq(x.BlockCount,2);
            Claim.numeq(x, blocks.parts(n128,1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
                        
            var src = Random.Blocks<int>(n128,blocks);
            var dst = Z0.blocks.alloc<int>(n128, blocks);

            Claim.eq(src.CellCount, dst.CellCount);
            var blocklen = src.BlockLength;

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            Claim.numeq(src,dst);

        }

    }

}