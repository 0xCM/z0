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

    using static zfunc;

    public class t_bvcreate : BitVectorTest<t_bvcreate>
    {
        public void gbv_16u_from_bs_check()
        {
            gbv_from_bs_check<ushort>();
        }

        public void gbv_32u_from_bs_check()
        {
            gbv_from_bs_check<uint>();
        }

        public void gbv_64u_from_bs_check()
        {
            gbv_from_bs_check<ulong>();
        }

        public void gbv_from_bs_check<T>()
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bs = Random.BitString(5,233);
                var bv = BitCells<T>.From(bs);
                Claim.eq(bs.Length, bv.Length);
                for(var j=0; j<bs.Length; j++)
                {                
                    if(bv[j] != bs[j])
                    {
                        Trace("bs", bs.Format());
                        Trace("bv", bv.Format());
                    }
                    Claim.eq(bv[j],bs[j]);
                }
            }
        }

        public void bvcreate_n64_g32u()
        {
            var dim = new N64();
            var segcount = dim / (int)bitsize<uint>();
            var src = Random.Span<uint>(SampleSize);
            for(var i=0; i<src.Length - segcount; i++)
            {
                var bvSrc = src.Slice(i, segcount);
                var bv = bvSrc.ToBitVector(dim);
                var x = Bits.pack(bvSrc[0], bvSrc[1]);
                for(var j = 0; j < dim; j++)
                    Claim.eq(BitMask.test(x,j), bv[j]);                
            }
        }

        //doesn't work
        void bvcreate_ng13x8u()
        {
            var dim = n13;
            var bv = Random.BitVector<N13,byte>();
            ClaimEqual(bv,bv.ToBitString());
            
            Claim.eq(dim, bv.Length);
            Claim.eq(bitsize<byte>() * bv.CellCount, bv.Capacity);
            Claim.eq(bv.Capacity - dim, bv.Unused);
            bv.Fill(Bit.On);
            Claim.eq(dim, bv.Pop());                    
        }

        public void bvcreate_ng63x64u()
        {
            bvcreate_natg_check<N63,ulong>();

        }

        public void bvcreate_ng13x16u()
        {
            bvcreate_natg_check<N13,ushort>();

        }

        public void bvcreate_ng32x32u()
        {
            bvcreate_natg_check<N32,uint>();

        }


        public void bvcreate_g8u()
        {
            create_generic_check<byte>(128u);
            create_generic_check<byte>(124u);
        }

        public void bvcreate_g16u()
        {
            create_generic_check<ushort>(125u);
            create_generic_check<ushort>(128u);
            create_generic_check<ushort>(13);
        }

        public void bvcreate_g32u()
        {
            create_generic_check<uint>(128u);
            create_generic_check<uint>(126);
            create_generic_check<uint>(32);            
        }

        public void bvcreate_g64u()
        {
            create_generic_check<ulong>(127u);
            create_generic_check<ulong>(128u);
            create_generic_check<ulong>(63);
        }

        public void span_bits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bv = BitVector64.FromScalar(BitConverter.ToUInt64(src));
            Claim.eq(src.ToBitString(), bv.ToBitString());

            for(var i=0; i<src.Length; i++)
            for(var j = 0; j < Pow2.T03; j++)
                Claim.eq(gbits.test(src[i],j), bv.Test(i*Pow2.T03 + j));
        }


        public void absolute_index()
        {
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;     
            var n = 40;      
            var bvz = BitCells<ulong>.FromCell(z,n);
            Span<byte> xSrc =  BitConverter.GetBytes(z);
            var bvx = BitCells.Load(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<n; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void create_N12i32()
        {
            var bv = BitVector.from(0b101110001110, n12);
            Claim.eq(bv[0], Bit.Off);
            Claim.eq(bv[1], Bit.On);
            Claim.eq(bv[11], Bit.On);

        }

        public void lsb64()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(n64);
                var n = Random.Next(1, bv.Length);
                var result = BitVector.lsb(bv,n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }


        public void bvmsb_64u_check()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector(n64);
                var n = Random.Next(1, bv.Length);
                var result = BitVector.msb(bv,n).ToBitString();
                var expect = bv.ToBitString().Reverse()[0, n - 1].Reverse();
                Claim.eq(expect, result);
            }
        }

        void rot8()
        {
            var x = BitVector8.Zero;
            var offset = 3;
            while(++x)
            {
                var y = x.Replicate();
                Trace($"rotl({y}:{offset}) = {BitVector.rotl(y,offset)}"); 
            }
        }


        void bvcreate_natg_check<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var dim = default(N);
            var segcount = BitSize.Segments<T>(dim.value);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i+= segcount)
            {
                var bvSrc = src.Slice(i,segcount);
                var bv = bvSrc.ToBitVector(dim);
                ClaimEqual(bv,bv.ToBitString());
                Claim.eq(dim.value, bv.Length);
                Claim.eq(bitsize<T>() * bv.CellCount, bv.Capacity);
                Claim.eq(bv.Capacity - dim.value, bv.Unused);

                var x = src[i];
                for(byte j = 0; j < (int)dim.value; j++)
                    Claim.eq(gbits.test(x,j).ToBit(), bv[j]);     

                // bv.Fill(Bit.On);
                // Claim.eq(dim.value, bv.Pop());                    

            }
        }


        void create_generic_check<T>(BitSize dim)
            where T : unmanaged
        {
            var segcount = BitSize.Segments<T>(dim);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i += segcount)
            {
                var data = src.Slice(i, segcount);
                var bv = data.ToBitCells(dim);
                var bs = data.ToBitString(dim);
                Claim.eq(bv.Length, dim);
                Claim.eq(bs.Length, dim);
                for(var j=0; j<bv.Length; j++)
                    Claim.eq(bv[j], bs[j]);

            }
        }



    }

}


