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
        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vec128UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            var blocklen = Span128<T>.BlockLength;                     
            
            var src = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,src.Length);
                        
            var expect = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = Vec128.Load<T>(ref tmp[0]);
             
                var vX = src.LoadVec128(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyUnaryOp<T>(IPolyrand random, int blocks, Vec256UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : unmanaged
        {
            var blocklen = Span256<T>.BlockLength;                     
            
            var src = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,src.Length);
                        
            var expect = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = Vec256.Load<T>(ref tmp[0]);
             
                var vX = src.LoadVec256(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector128BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {
            var blocklen = Span128<T>.BlockLength;                     
            
            var lhs = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,lhs.Length);
            
            var rhs = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,rhs.Length);
            
            var expect = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vloadu(in head(tmp), out Vector128<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                ginx.vstore(vExpect, ref expect.Block(block));
                ginx.vstore(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }


        public static void VerifyBinOp<T>(IPolyrand random, int blocks, Vector256BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : unmanaged
        {
            var blocklen = Span256<T>.BlockLength;                     
            
            var lhs = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,lhs.Length);
            
            var rhs = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,rhs.Length);
            
            var expect = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            Span<T> tmp = stackalloc T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                ginx.vloadu(in head(tmp), out Vector256<T> vExpect);
             
                var vX = lhs.LoadVector(block);
                var vY = rhs.LoadVector(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                ginx.vstore(vExpect, ref expect.Block(block));
                ginx.vstore(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

    }

}