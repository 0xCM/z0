//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_bitpack : t_sinx<t_bitpack>
    {
        public void unpack_16()
        {
            for(var sample = 0; sample < SampleSize; sample ++)
            {
                var src = Random.Next<ushort>();
                var dst = DataBlocks.single<byte>(n128);

                BitPack.unpack(src, dst);            
                unpack_check(src,dst);

                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_32()
        {
            for(var sample=0; sample< SampleSize; sample++)
            {
                var src = Random.Next<uint>();
                var dst = DataBlocks.single<byte>(n256);
                BitPack.unpack(src, dst);

                unpack_check(src,dst);
                
                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_64()
        {
            for(var sample=0; sample< SampleSize; sample++)
            {
                var src = Random.Next<ulong>();
                var dst = DataBlocks.single<byte>(n512);
                BitPack.unpack(src, dst);

                unpack_check(src,dst);
                
                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }

        }

        public void bitspan_format_direction()
        {
            byte src = 1;
            var bitspan = BitPack.bitspan(src);
            var fmt = bitspan.Format();
            Claim.eq(8,fmt.Length);
            Claim.eq(bit.One, fmt[7]);

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