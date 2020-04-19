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
    using static BlockChecks;

    public class t_blocks : t_vinx<t_blocks>
    {                

        public  void CellSize()
        {
            CheckNumeric.eq(1, Blocks.cellsize<sbyte>());
            CheckNumeric.eq(1, Blocks.cellsize<byte>());
            CheckNumeric.eq(2, Blocks.cellsize<short>());
            CheckNumeric.eq(4, Blocks.cellsize<int>());
            CheckNumeric.eq(4, Blocks.cellsize<uint>());
            CheckNumeric.eq(4, Blocks.cellsize<float>());
            CheckNumeric.eq(8, Blocks.cellsize<ulong>());
            CheckNumeric.eq(8, Blocks.cellsize<double>());
            CheckNumeric.eq(8, Blocks.cellsize<long>());


            CheckNumeric.eq(1, Blocks.cellsize<sbyte>());
            CheckNumeric.eq(1, Blocks.cellsize<byte>());
            CheckNumeric.eq(2, Blocks.cellsize<short>());
            CheckNumeric.eq(4, Blocks.cellsize<int>());
            CheckNumeric.eq(4, Blocks.cellsize<uint>());
            CheckNumeric.eq(4, Blocks.cellsize<float>());
            CheckNumeric.eq(8, Blocks.cellsize<ulong>());
            CheckNumeric.eq(8, Blocks.cellsize<double>());
            CheckNumeric.eq(8, Blocks.cellsize<long>());
        }


        public void db_blocklen_128()
        {
            N128 n = default;
            CheckNumeric.eq(16, Blocks.length<sbyte>(n));
            CheckNumeric.eq(16, Blocks.length<byte>(n));
            CheckNumeric.eq(8, Blocks.length<short>(n));
            CheckNumeric.eq(8, Blocks.length<ushort>(n));
            CheckNumeric.eq(4, Blocks.length<int>(n));
            CheckNumeric.eq(4, Blocks.length<uint>(n));
            CheckNumeric.eq(2, Blocks.length<long>(n));
            CheckNumeric.eq(2, Blocks.length<ulong>(n));
            CheckNumeric.eq(4, Blocks.length<float>(n));
            CheckNumeric.eq(2, Blocks.length<double>(n));                
            CheckNumeric.eq(8, Blocks.cellblocks<int>(n,2));
            CheckNumeric.eq(4, Blocks.cellblocks<long>(n, 2));
            CheckNumeric.eq(32, Blocks.cellblocks<byte>(n, 2));


        }

        public void db_blocklen_256()
        {
            N256 n = default;
            CheckNumeric.eq(32, Blocks.length<sbyte>(n));
            CheckNumeric.eq(32, Blocks.length<byte>(n));
            CheckNumeric.eq(16, Blocks.length<short>(n));
            CheckNumeric.eq(16, Blocks.length<ushort>(n));
            CheckNumeric.eq(8, Blocks.length<int>(n));
            CheckNumeric.eq(8, Blocks.length<uint>(n));
            CheckNumeric.eq(4, Blocks.length<long>(n));
            CheckNumeric.eq(4, Blocks.length<ulong>(n));
            CheckNumeric.eq(8, Blocks.length<float>(n));
            CheckNumeric.eq(4, Blocks.length<double>(n));                

        }


        public void BlockSlice()
        {
            var x = Blocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));

            var block0 = x.Block(0);
            CheckNumeric.eq(4, block0.Length);   
            var y = Blocks.safeload(n128, span(1,2,3,4));         
            CheckNumeric.eq(block0, y);

            var block2 = x.Block(1);
            CheckNumeric.eq(4, block2.Length);
            CheckNumeric.eq(block2, Blocks.parts(n128,5,6,7,8));

        }
        public void Load1()
        {
            var x = Blocks.safeload(n128, span<int>(1,2,3,4,5,6,7,8));
            CheckNumeric.eq(x.BlockCount,2);
            BlockChecks.eq(x, Blocks.parts(n128,1,2,3,4,5,6,7,8));
            
        }

        public void Fill1()
        {

            var blocks = Pow2.T08;   
                        
            var src = Random.Blocks<int>(n128,blocks);
            var dst = Z0.Blocks.alloc<int>(n128, blocks);

            CheckNumeric.eq(src.CellCount, dst.CellCount);
            var blocklen = src.BlockLength;

            for(int block = 0, idx = 0; block<blocks; block++, idx ++)
            {
                for(var i =0; i<blocklen; i++)
                    dst[block*blocklen + i] = src[block*blocklen + i];                
            }

            BlockChecks.eq(src,dst);
        }
    }
}