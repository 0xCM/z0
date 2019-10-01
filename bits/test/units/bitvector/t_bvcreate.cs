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
                var bv = BitVector<T>.From(bs);
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
                    Claim.eq(BitMask.test(x,j).ToBit(), bv[j]);                
            }
        }

        public void bvcreate_8g_fixed()
        {
            bv_create_fixedG<BitVector8,byte>();
        }

        public void bvcreate_16g_fixed()
        {
            bv_create_fixedG<BitVector16,ushort>();
        }

        public void bvcreate_32g_fixed()
        {
            bv_create_fixedG<BitVector32,uint>();
        }

        public void bvcreate_64g_fixed()
        {
            bv_create_fixedG<BitVector64,ulong>();
        }

        void bv_create_fixedG<V,S>()
            where V : unmanaged, IFixedScalarBits<V,S>
            where S : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<S>();
                var bv = gbits.bitvector<V,S>(src);
                var bs = BitString.FromScalar(src);
                for(var j=0; j< bv.Length; j++)
                    Claim.eq(bv[j], bs[j]);            
            }
        }

        public void bvcreate_g8u_unfixed()
        {
            create_generic_unfixed_check<byte>(128u);
            create_generic_unfixed_check<byte>(124u);

        }

        public void bvcreate_g16u_unfixed()
        {
            create_generic_unfixed_check<ushort>(125u);
            create_generic_unfixed_check<ushort>(128u);
            create_generic_unfixed_check<ushort>(13);
        }

        public void bvcreate_g32u_unfixed()
        {
            create_generic_unfixed_check<uint>(128u);
            create_generic_unfixed_check<uint>(126);
            create_generic_unfixed_check<uint>(32);            
        }

        public void bvcreate_g64u_unfixed()
        {
            create_generic_unfixed_check<ulong>(127u);
            create_generic_unfixed_check<ulong>(128u);
            create_generic_unfixed_check<ulong>(63);

        }

        public void bvcreate_gnat_unfixed()
        {
            create_ngunfixed_check<N63,ulong>();
            create_ngunfixed_check<N13,ushort>();
            create_ngunfixed_check<N32,uint>();
        }

        public void span_bits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.FromScalar(BitConverter.ToUInt64(src));

            for(var i=0; i<src.Length; i++)
            {
                ref var x = ref src[i];
                for(var j = 0; j < Pow2.T03; j++)
                    Claim.eq(gbits.test(x,j), bvSrc.Test(i*Pow2.T03 + j));
            }
        }


        public void absolute_index()
        {
            ulong z = 0b01011_00010_01110_11010_00111_00101_01110_10110;           
            var bvz = bitvector.from(z,40);
            Span<byte> xSrc =  BitConverter.GetBytes(z);
            var bvx = BitVector.Load(xSrc.Slice(0,5).ToArray());
            Claim.eq(gbits.pop(z), bvz.Pop());
            Claim.eq(gbits.pop(z), bvx.Pop());

            for(var i=0; i<40; i++)
                Claim.eq(bvz[i], bvx[i]);
        }

        public void create_N12i32()
        {
            var bv = bitvector.from(0b101110001110, n12);
            Claim.eq(bv[0], Bit.Off);
            Claim.eq(bv[1], Bit.On);
            Claim.eq(bv[11], Bit.On);

        }

        public void lsb64()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Lsb(n).ToBitString();
                var expect = bv.ToBitString()[0, n - 1];
                Claim.eq(expect, result);
            }
        }

        public void msb64()
        {
            for(var i=0; i< SampleSize; i++)            
            {
                var bv = Random.BitVector64();
                var n = Random.Next(1, bv.Length);
                var result = bv.Msb(n).ToBitString();
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
                Trace($"rotl({y}:{offset}) = {y.Rol((byte)offset)}"); 
            }
        }

        public void powers()
        {
            var x = Random.BitVector8();
            var expect2 = x * x;
            var actual2 = x^2;
            Claim.eq(expect2, actual2);

            var expect4 = expect2 * expect2;
            var actual4 = x^4;
            Claim.eq(expect4, actual4);

            var expect8 = expect4 * expect4;
            var actual8 = x^8;
            Claim.eq(expect8, actual8);

            var expect16 = expect8 * expect8;
            var actual16 = x^16;
            Claim.eq(expect16, actual16);
        }

        public void powers2()
        {

            var max = 0;
            var vectors = BitVector8.All.ToArray();
            const int MaxCount = 256;
            Claim.yea(vectors.Length == MaxCount);
            Claim.eq(vectors.ToSet().Count, MaxCount);

            for(var i=0; i< MaxCount; i++)
            {
                var v = vectors[i];
                if(v.Empty)
                    continue;

                for(var j=2; j<MaxCount; j++)                
                {
                    
                    var p = v^j;
                    if(p == BitVector8.One)
                    {
                        if(j > max)
                            max = j;
                        break;
                    }
                }

            }

        }

        void create_ngunfixed_check<N,T>()
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
                var x = src[i];
                for(byte j = 0; j < (int)dim.value; j++)
                    Claim.eq(gbits.test(x,j).ToBit(), bv[j]);                

            }
        }

        void create_generic_unfixed_check<T>(BitSize dim)
            where T : unmanaged
        {
            var segcount = BitSize.Segments<T>(dim);
            var src = Random.Span<T>(SampleSize);
            for(var i=0; i<SampleSize; i += segcount)
            {
                var data = src.Slice(i, segcount);
                var bv = data.ToBitVector(dim);
                var bs = data.ToBitString(dim);
                Claim.eq(bv.Length, dim);
                Claim.eq(bs.Length, dim);
                for(var j=0; j<bv.Length; j++)
                    Claim.eq(bv[j], bs[j]);

            }
        }



    }

}


