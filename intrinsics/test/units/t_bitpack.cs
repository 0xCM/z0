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
            for(var sample = 0; sample < RepCount; sample ++)
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
            for(var sample=0; sample< RepCount; sample++)
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
            for(var sample=0; sample< RepCount; sample++)
            {
                var src = Random.Next<ulong>();
                var dst = DataBlocks.single<byte>(n512);
                BitPack.unpack(src, dst);

                unpack_check(src,dst);
                
                var rebound = BitPack.pack(dst);
                Claim.eq(src,rebound);
            }

        }

        public void bitpack_32x4()
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


        public void sb_pack_8x1_256()
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

        public void sb_pack_8x1_basecase()
        {
            void case1()
            {
                var src = DataBlocks.single<byte>(n256);
                CpuVector.vones<byte>(n256).StoreTo(src);
                var dst = BitPack.pack(src);
                Claim.eq(dst,uint.MaxValue);

            }

            void case2()
            {
                var src = DataBlocks.single<byte>(n128);
                CpuVector.vones<byte>(n128).StoreTo(src);
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