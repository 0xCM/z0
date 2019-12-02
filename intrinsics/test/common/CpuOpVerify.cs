//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public static class CpuOpVerify
    {
        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vector128UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            
            var src = random.Blocks<T>(n128,blocks).ReadOnly();
            var blocklen = src.BlockLength;
            Claim.eq(blocks*blocklen,src.CellCount);
                        
            var expect = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = ginx.vload<T>(n128, in head(tmp));
             
                var vX = src.LoadVector(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vector256UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            
            var src = random.Blocks<T>(n256,blocks).ReadOnly();
            var blocklen = src.BlockLength;                     

            Claim.eq(blocks*blocklen,src.CellCount);
                        
            var expect = DataBlocks.alloc<T>(n256, blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = ginx.vload<T>(n256, in head(tmp));
             
                var vX = src.LoadVector(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector128BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {
            
            var lhs = random.Blocks<T>(n128,blocks).ReadOnly();
            var blocklen = lhs.BlockLength;
            Claim.eq(blocks*blocklen,lhs.CellCount);
            
            var rhs = random.Blocks<T>(n128,blocks).ReadOnly();
            Claim.eq(blocks*blocklen,rhs.CellCount);
            
            var expect = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n128,blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vload(in head(tmp), out Vector128<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector256BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {                    
            var lhs = random.Blocks<T>(n256, blocks).ReadOnly();
            var blocklen = lhs.BlockLength;                     
            Claim.eq(blocks*blocklen,lhs.CellCount);
            
            var rhs = random.Blocks<T>(n256,blocks).ReadOnly();
            Claim.eq(blocks*blocklen,rhs.CellCount);
            
            var expect = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = DataBlocks.alloc<T>(n256,blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vload(in head(tmp), out Vector256<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                vstore(vExpect, ref expect.BlockRef(block));
                vstore(vActual, ref actual.BlockRef(block));
            }
            Claim.eq(expect, actual);
        }

    }

}