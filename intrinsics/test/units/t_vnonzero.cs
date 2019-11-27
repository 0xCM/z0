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


    public class tv_nonzero : IntrinsicTest<tv_nonzero>
    {
        public void nonzero128()
        {
            nonzero128_check<sbyte>();
            nonzero128_check<byte>();
            nonzero128_check<short>();
            nonzero128_check<ushort>();
            nonzero128_check<int>();
            nonzero128_check<uint>();
            nonzero128_check<long>();
            nonzero128_check<ulong>();
        }

        public void nonzero256()
        {
            nonzero256_check<sbyte>();
            nonzero256_check<byte>();
            nonzero256_check<short>();
            nonzero256_check<ushort>();
            nonzero256_check<int>();
            nonzero256_check<uint>();
            nonzero256_check<long>();
            nonzero256_check<ulong>();

        }

        void nonzero128_check<T>(N128 n = default)
            where T : unmanaged
        {
            
            var  src = Random.Blocks<T>(n, blocks: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = ginx.vload(n, in src.BlockSeek(i));
                Claim.yea(ginx.vnonz(v));
            }
            
            Claim.nea(ginx.vnonz(vzero<T>(n)));
        }

        void nonzero256_check<T>(N256 n = default)
            where T : unmanaged
        {
            var  src = Random.Blocks<T>(n, blocks: SampleSize);
            for(var i = 0; i< src.BlockCount; i++)
            {
                var v = ginx.vload(n, in src.BlockSeek(i));
                Claim.yea(ginx.vnonz(v));
            }
            
            Claim.nea(ginx.vnonz(vzero<T>(n)));
        }

    }

}