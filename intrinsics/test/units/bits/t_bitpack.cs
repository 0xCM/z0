//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static zfunc;

    public class t_bitpack : t_vinx<t_bitpack>
    {
        public void unpack_16()
        {
            for(var sample = 0; sample < RepCount; sample ++)
            {
                var src = Random.Next<ushort>();
                var dst = DataBlocks.single<byte>(n128);

                BitPack.unpack16x8(src, dst);            
                unpack_check(src,dst);

                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_32()
        {
            for(var sample=0; sample< RepCount; sample++)
            {
                var src = Random.Next<uint>();
                var dst = DataBlocks.single<byte>(n256);
                BitPack.unpack32x8(src, dst);

                unpack_check(src,dst);
                
                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }
        }

        public void unpack_64()
        {
            for(var sample=0; sample< RepCount; sample++)
            {
                var src = Random.Next<ulong>();
                var dst = DataBlocks.single<byte>(n512);
                BitPack.unpack64x8(src, dst);

                unpack_check(src,dst);
                
                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }

        }

        public void pack_32x4()
        {
            var count = n4;
            var block = n32;
            for(var sample = 0; sample < RepCount; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                var packed = BitPack.pack(bitseq);
                Claim.eq(bs.TakeScalar<byte>(), packed);
            }
        }


        public void unpack_64x32()
        {
            var dst = new uint[64];

            for(var rep = 0; rep < RepCount; rep++)
            {
                var src = Random.Single(z64);
                BitPack.unpack32(src,dst);
                for(var i=0; i< dst.Length; i++)
                    Claim.eq((uint)bit.test(src,i), dst[i]);
            }
        }

        public void pack_8x1_256()
        {
            var count = n32;
            var block = n256;
            
            for(var sample = 0; sample < RepCount; sample++)
            {
                var bs = Random.BitString(count);
                var bitseq = bs.BitSeq.Blocked(block);
                uint packed = BitPack.pack(bitseq);
                for(var i=0; i< count; i++)
                    Claim.eq(bs[i], BitMask.testbit(packed, i));
            }
        }

        public void pack_32()
        {
            var n = 32;
            Span<bit> buffer = new bit[n];
            for(var i=0; i<RepCount; i++)
            {
                var bits = Random.Bits().Take(Random.Next<uint>(5,25)).ToSpan();
                
                var expect = 0u;
                for(var j=0; j<bits.Length; j++)
                    expect |= (uint)bits[j] << j;

                buffer.Clear();
                bits.CopyTo(buffer);
                var result = BitPack.pack<uint>(buffer);
                
                Claim.eq(expect, result);

            }
        }

        public void pack_8x1_basecase()
        {
            void case1()
            {
                var src = DataBlocks.single<byte>(n256);
                VPattern.vones<byte>(n256).StoreTo(src);
                var dst = BitPack.pack(src);
                Claim.eq(dst,uint.MaxValue);

            }

            void case2()
            {
                var src = DataBlocks.single<byte>(n128);
                VPattern.vones<byte>(n128).StoreTo(src);
                var dst = BitPack.pack(src);
                Claim.eq(dst,ushort.MaxValue);
            }

            case1();
            case2();
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