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

    public class t_vand : IntrinsicTest<t_vand>
    {
        public void vand_g128x8i()
            => vand_g128_check<sbyte>();

        public void vand_g128x8u()
            => vand_g128_check<byte>();            

        public void vand_g128x16i()
            => vand_g128_check<short>();

        public void vand_g128x16u()
            => vand_g128_check<ushort>();

        public void vand_g128x32i()
            => vand_g128_check<int>();

        public void vand_g128x32u()
            => vand_g128_check<uint>();            

        public void vand_g128x64i()
            => vand_g128_check<long>();            

        public void vand_g128x64u()
            => vand_g128_check<ulong>();            

        public void vand_g256x8i()
            => vand_g256_check<sbyte>();

        public void vand_g256x8u()
            => vand_g256_check<byte>();            

        public void vand_g256x16i()
            => vand_g256_check<short>();

        public void vand_g256x16u()
            => vand_g256_check<ushort>();

        public void vand_g256x32i()
            => vand_g256_check<int>();

        public void vand_g256x32u()
            => vand_g256_check<uint>();            

        public void vand_g256x64i()
            => vand_g256_check<long>();            

        public void vand_g256x64u()
            => vand_g256_check<ulong>();            

     
        void vand_g128_check<T>()
            where T : unmanaged
        {
            var N = n128;
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(N);
                var srcY = Random.BlockedSpan<T>(N);
                var vX = ginx.vload(N, in head(srcX));
                var vY = ginx.vload(N, in head(srcY));
                var dstExpect = BlockedSpan.AllocBlock<T>(N);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(N, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);
                
            }
        }

        void vand_g256_check<T>()
            where T : unmanaged
        {
            var N = n256;
            for(var block = 0; block < SampleSize; block++)
            {
                var srcX = Random.BlockedSpan<T>(N);
                var srcY = Random.BlockedSpan<T>(N);
                var vX = ginx.vload(N, in head(srcX));
                var vY = ginx.vload(N, in head(srcY));
                var dstExpect = BlockedSpan.AllocBlock<T>(N);
                for(var i=0; i< dstExpect.Length; i++)
                    dstExpect[i] = gmath.and(srcX[i], srcY[i]);
                var expect = ginx.vload(N, in head(dstExpect));
                var actual = ginx.vand(vX,vY);
                Claim.eq(expect,actual);
                
            }
        }

    }

}