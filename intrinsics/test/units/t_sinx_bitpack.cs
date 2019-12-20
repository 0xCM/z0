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

                BitPack.unpackbits(src, dst);            
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
                BitPack.unpackbits(src, dst);

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
                BitPack.unpackbits(src, dst);

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

        public void bitspan_16()
        {
            const int length = 16;
            var src = BitMask.even(n2, n1, z16);
            var bitspan = BitPack.bitspan(src);
            var format = bitspan.Format();

            Claim.eq(length, bitspan.Length);
            for(int i=0, j= length - 1; i< length; i++, j--)
            {
                if(even(i))
                {
                    Claim.yea(bitspan[i]);
                    Claim.eq(bit.One, format[j]);
                }
                else
                {
                    Claim.nea(bitspan[i]);
                    Claim.eq(bit.Zero, format[j]);
                }
            }            
        }

        public void bitspan_32()
        {
            const int length = 32;
            var src = BitMask.even(n2, n1, z32);
            var bitspan = BitPack.bitspan(src);
            var format = bitspan.Format();

            Claim.eq(length, bitspan.Length);
            for(int i=0, j= length - 1; i< length; i++, j--)
            {
                if(even(i))
                {
                    Claim.yea(bitspan[i]);
                    Claim.eq(bit.One, format[j]);
                }
                else
                {
                    Claim.nea(bitspan[i]);
                    Claim.eq(bit.Zero, format[j]);
                }
            }            
        }

        public void bitspan_64()
        {
            const int length = 64;
            var src = BitMask.even(n2, n1, z64);
            var bitspan = BitPack.bitspan(src);
            var format = bitspan.Format();

            Claim.eq(length, bitspan.Length);
            for(int i=0, j= length - 1; i< length; i++, j--)
            {
                if(even(i))
                {
                    Claim.yea(bitspan[i]);
                    Claim.eq(bit.One, format[j]);
                }
                else
                {
                    Claim.nea(bitspan[i]);
                    Claim.eq(bit.Zero, format[j]);
                }
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