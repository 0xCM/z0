//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_sinx_bitpack : t_sinx<t_sinx_bitpack>
    {
        public void unpack_16()
        {
            for(var sample = 0; sample < SampleSize; sample ++)
            {
                var src = Random.Next<ushort>();
                var dst = DataBlocks.single<byte>(n128);

                ginxs.unpackbits(src, dst);            
                unpack_check(src,dst);

                var rebound = ginxs.bitpack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_32()
        {
            for(var sample=0; sample< SampleSize; sample++)
            {
                var src = Random.Next<uint>();
                var dst = DataBlocks.single<byte>(n256);
                ginxs.unpackbits(src, dst);

                unpack_check(src,dst);
                
                var rebound = ginxs.bitpack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_64()
        {
            for(var sample=0; sample< SampleSize; sample++)
            {
                var src = Random.Next<ulong>();
                var dst = DataBlocks.single<byte>(n512);
                ginxs.unpackbits(src, dst);

                unpack_check(src,dst);
                
                var rebound = ginxs.bitpack(dst);
                Claim.eq(src,rebound);
            }

        }


        void unpack_check<T>(T src, in ReadOnlySpan<byte> y)
            where T : unmanaged
        {
            var count = math.min(bitsize<T>(), y.Length);
            for(var i=0; i<count; i++)
                Claim.eq((byte)gbits.test(src, i), y[i]);

            Claim.eq(BitString.load(y).TakeScalar<T>(), src);
        }
    }
}