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


    public class tv_sub : IntrinsicTest<tv_sub>
    {
        
        public void vsub_128x8i_check()
        {
            sub128_check<sbyte>();
        }

        public void vsub_128x8u_check()
        {
            sub128_check<byte>();            
        }

        public void vsub_128x16i_check()
        {
            sub128_check<short>();            
        }

        public void vsub_128x16u_check()
        {
            sub128_check<ushort>();
        }

        public void vsub_128x32i_check()
        {
            sub128_check<int>();            
        }

        public void vsub_128x32u_check()
        {
            sub128_check<uint>();            
        }

        public void vsub_128x64i_check()
        {
            sub128_check<long>();
        }

        public void vsub_128x64u_check()
        {
            sub128_check<ulong>();
        }

        public void vsub_256x8i_check()
        {
            sub256_check<sbyte>();
        }

        public void vsub_256x8u_check()
        {
            sub256_check<byte>();            
        }

        public void vsub_256x16i_check()
        {
            sub256_check<short>();            
        }

        public void vsub_256x16u_check()
        {
            sub256_check<ushort>();
        }

        public void vsub_256x32i_check()
        {
            sub256_check<int>();            
        }

        public void vsub_256x32u_check()
        {
            sub256_check<uint>();            
        }

        public void vsub_256x64i_check()
        {
            sub256_check<long>();
        }

        public void vsub_256x64u_check()
        {
            sub256_check<ulong>();
        }

        public void sub256_batch()
        {
            sub256_batch_check<long>();
            sub256_batch_check<int>();
            sub256_batch_check<byte>();
        }

        void sub128_check<T>(int blocks = 0)
            where T : unmanaged
            => CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector128BinOp<T>(ginx.vsub), gmath.sub<T>);

        void sub256_check<T>(int blocks = 0)
            where T : unmanaged
                => CpuOpVerify.VerifyBinOp(Random, SampleSize, new Vector256BinOp<T>(ginx.vsub), gmath.sub<T>);

        void sub256_batch_check<T>()
            where T : unmanaged
        {
            TypeCaseStart<T>();
            var lhs = Random.Blocks<T>(n256,SampleSize).ReadOnly();
            var rhs = Random.Blocks<T>(n256,SampleSize).ReadOnly();
            var dstA = lhs.Replicate();
            vblock.sub(lhs, rhs, dstA);
            var dstB = Block256.alloc<T>(lhs.BlockCount);
            for(var i = 0; i < dstA.Length; i++)
                dstB[i] = gmath.sub(lhs[i], rhs[i]);
            Claim.yea(dstA.Identical(dstB));
            TypeCaseEnd<T>();
        }
    }

}