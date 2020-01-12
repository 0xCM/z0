//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_bitspan : t_vinx<t_bitspan>
    {
        public void bsequals()
        {
            for(var i=0; i<RepCount; i++)
            {
                var a = Random.Single(z64).ToBitSpan();
                var b = Random.Single(z64).ToBitSpan();
                var c = a.Replicate();
                Claim.yea(a != b);
                Claim.yea(a == c);
            }
        }

        public void bsparse()
        {
            bsparse_check(z8);
            bsparse_check(z16);
            bsparse_check(z32);
            bsparse_check(z64);
        }

        public void bstrim()
        {
            var x0 = 0b_01011000_00001000_11111010_01100101u;
            var x1 = x0.ToBitSpan();
            var x2 = x1.Extract<uint>();
            Claim.eq(x0,x2);            

            var x = 0b10100001100101010001u;
            var bsSrc = "0000010100001100101010001";
            
            var bs1 = BitSpan.parse(bsSrc);
            Claim.eq((int)bs1.Length, bsSrc.Length);

            var bs2 = BitSpan.create(x);
            ClaimEqual(bs1.Trim(),bs2.Trim());

            var y = bs1.Convert<uint>();
            Claim.eq(x,y);

        }

        public void bsand_8()
            => bsand_check(z8);
        
        public void bsand_16()
            => bsand_check(z16);

        public void bsand_32()
            => bsand_check(z32);

        public void bsand_64()
            => bsand_check(z64);

        public void bsor_8()
            => bsor_check(z8);
        
        public void bsor_16()
            => bsor_check(z16);

        public void bsor_32()
            => bsor_check(z32);

        public void bsor_64()
            => bsor_check(z64);

        public void bsxor_8()
            => bsxor_check(z8);
        public void bsxor_16()
            => bsxor_check(z16);

        public void bsxor_32()
            => bsxor_check(z32);

        public void bsxor_64()
            => bsxor_check(z64);

        public void bsbitload_check()
        {            
            var bytecount = RepCount;
            Block256<uint> unpacked = DataBlocks.alloc(n256,bytecount,z32);
            Block64<byte> buffer = DataBlocks.single(n64,z8);
            Span<byte> packed = stackalloc byte[bytecount];
            
            for(var i=0; i<RepCount; i++)            
            {
                Random.Fill(packed);
                BitPack.unpack32(packed, unpacked);
                var bitspan = BitSpan.load(unpacked.As<bit>());
                bitspan_check(packed,bitspan);
            }            
        }

        public void bsformat_8()
            => bsformat_check(z8);

        public void bsformat_16()
            => bsformat_check(z16);

        public void bsformat_32()
            => bsformat_check(z32);

        public void bsformat_64()
            => bsformat_check(z64);

        public void bsload_scalars_8()
            => bsload_scalars_check(z8);

        public void bsload_scalars_16()
            => bsload_scalars_check(z16);

        public void bsload_scalars_32()
            => bsload_scalars_check(z32);

        public void bsload_scalars_64()
            => bsload_scalars_check(z64);

        public void bitslice_32()
        {
            var x = BitMasks.Even32x2;
            var y = x.ToBitSpan();
            var t = z32;

            var z0 = y[0,2,t];
            Claim.eq(0b11,z0);
            var z1 = y[2,2,t];
            Claim.eq(0b00,z1);
            var z2 = y[4,2,t];
            Claim.eq(0b11,z2);
            var z3 = y[6,2,t];
            Claim.eq(0b00,z3);    
        }

        public void loadscalar()
        {
            bscreate_check(z8);
            bscreate_check(z8i);
            bscreate_check(z16);
            bscreate_check(z16i);
            bscreate_check(z32);
            bscreate_check(z32i);
            bscreate_check(z64);
            bscreate_check(z64i);
        }

        public void extract()
        {
            bsextract_check(z8);
            bsextract_check(z8i);
            bsextract_check(z16);
            bsextract_check(z16i);
            bsextract_check(z32);
            bsextract_check(z32i);
            bsextract_check(z64);
            bsextract_check(z64i);
        }

        void bsand_check<T>(T t = default)
            where T : unmanaged
        {            
            var n = bitsize(t);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x & y;
                var a = x.Extract(t);
                var b = y.Extract(t);
                var c = gmath.and(a, b);
                Claim.eq(c, z.Extract(t));
            }
        }

        void bsor_check<T>(T t = default)
            where T : unmanaged
        {            
            var n = bitsize(t);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x | y;
                var a = x.Extract(t);
                var b = y.Extract(t);
                var c = gmath.or(a, b);
                Claim.eq(c, z.Extract(t));
            }
        }

        void bsxor_check<T>(T t = default)
            where T : unmanaged
        {            
            var n = bitsize(t);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x ^ y;
                var a = x.Extract(t);
                var b = y.Extract(t);
                var c = gmath.xor(a, b);
                Claim.eq(c, z.Extract(t));
            }
        }

        void bsformat_check<T>(T t = default)
            where T : unmanaged
        {
            var length = bitsize<T>();
            var src = BitMask.even(n2, n1, t);
            var bitspan = BitSpan.create<T>(src);
            var format = bitspan.Format();

            Claim.eq(length, bitspan.Length);
            for(int i=0, j = length - 1; i< length; i++, j--)
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

        void bsload_scalars_check<T>(T t = default)
            where T : unmanaged
        {
            var length = 64;
            Span<T> buffer = stackalloc T[length];

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(buffer);
                var bitspan = BitSpan.load(buffer);
                bitspan_check(buffer.AsBytes(),bitspan);
            }
        }

        void bscreate_check<T>(T t = default)
            where T : unmanaged
        {
            void check()
            {
                Span<byte> bytes = stackalloc byte[size(t)];
                for(var i=0; i < RepCount; i++)
                {
                    var src = Random.Single(t);                
                    var bitspan = BitSpan.create(src);
                    BitConvert.GetBytes(src,bytes);
                    bitspan_check(bytes, bitspan);
                }
            }

            CheckAction<T>(check, "bscreate");
        }
            
        void bsextract_check<T>(T t = default)
            where T : unmanaged
        {
            void check()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var x = Random.Single<T>();
                    var y = BitSpan.create(x);
                    var z = BitSpan.extract<T>(y);
                    Claim.eq(x,z);
                }
            }  

            CheckAction<T>(check, "bsextract");
        }

        void bsparse_check<T>(T t = default)
            where T : unmanaged
        {
            void check()
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x0 = Random.Next<T>();
                    var x1 = BitSpan.create(x0);
                    var x2 = x1.Format();
                    var x3 = BitSpan.parse(x2);
                    var x4 = x3.Convert<T>();
                    Claim.eq(x0,x4);
                }
            }

            CheckAction(check,CaseName(moniker<T>("bsparse")));
        }

        void bitspan_check(Span<byte> packed, BitSpan bitspan)
        {
            var bitcount = bitspan.Length;
            for(int i=0, k = 0; i < packed.Length; i++, k += 8)
            for(var j=0; j < 8; j++)
                Claim.eq(bit.test(packed[i], j), bitspan[k + j]);
        }

    }
}