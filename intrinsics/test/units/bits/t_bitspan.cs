//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_bitspan : t_sinx<t_bitspan>
    {
        public void equality()
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

        public void and()
        {            
            var t = z64;
            var n = bitsize(t);
            
            var xb = BitSpan.alloc(n);
            var yb = BitSpan.alloc(n);
            var zb = BitSpan.alloc(n);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x & y;
                var xs = x.Scalar(t);
                var ys = y.Scalar(t);
                var zs = xs & ys;
                Claim.eq(zs, z.Scalar(t));
            }
        }

        public void or()
        {            
            var t = z64;
            var n = bitsize(t);
            
            var xb = BitSpan.alloc(n);
            var yb = BitSpan.alloc(n);
            var zb = BitSpan.alloc(n);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x | y;
                var xs = x.Scalar(t);
                var ys = y.Scalar(t);
                var zs = xs | ys;
                Claim.eq(zs, z.Scalar(t));
            }
        }

        public void xor()
        {            
            var t = z64;
            var n = bitsize(t);

            for(var rep = 0; rep <= RepCount; rep++)
            {
                var x = Random.BitSpan(n);
                var y = Random.BitSpan(n);
                var z = x ^ y;
                var xs = x.Scalar(t);
                var ys = y.Scalar(t);
                var zs = xs ^ ys;
                Claim.eq(zs, z.Scalar(t));
            }
        }

        public void format_direction()
        {
            byte src = 1;
            var bitspan = BitSpan.create<byte>(src);
            var fmt = bitspan.Format();
            Claim.eq(8,fmt.Length);
            Claim.eq(bit.One, fmt[7]);

        }

        public void loadbits()
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

        public void format_16()
        {
            const int length = 16;
            var src = BitMask.even(n2, n1, z16);
            var bitspan = BitSpan.create<ushort>(src);
            var format = bitspan.Format();
            Trace(format);

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

        public void format_32()
        {
            const int length = 32;
            var src = BitMask.even(n2, n1, z32);
            var bitspan = BitSpan.create<uint>(src);
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

        public void format_64()
        {
            const int length = 64;
            var src = BitMask.even(n2, n1, z64);
            var bitspan = BitSpan.create<ulong>(src);
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

        public void loadscalars_8()
        {
            var length = 64;
            Span<byte> buffer = stackalloc byte[length];

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(buffer);
                var bitspan = BitSpan.load(buffer);
                bitspan_check(buffer,bitspan);
            }
        }

        public void loadscalars_16()
        {
            var length = 64;
            Span<ushort> buffer = stackalloc ushort[length];

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(buffer);
                var bitspan = BitSpan.load(buffer);
                bitspan_check(buffer.AsBytes(),bitspan);
            }
        }

        public void loadscalars_32()
        {
            var length = 64;
            Span<uint> buffer = stackalloc uint[length];

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(buffer);
                var bitspan = BitSpan.load(buffer);
                bitspan_check(buffer.AsBytes(),bitspan);
            }
        }

        public void loadscalars_64()
        {
            var length = 64;
            Span<ulong> buffer = stackalloc ulong[length];

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(buffer);
                var bitspan = BitSpan.load(buffer);
                bitspan_check(buffer.AsBytes(),bitspan);
            }
        }

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
            loadscalar_check(z8);
            loadscalar_check(z8i);
            loadscalar_check(z16);
            loadscalar_check(z16i);
            loadscalar_check(z32);
            loadscalar_check(z32i);
            loadscalar_check(z64);
            loadscalar_check(z64i);
        }

        public void extract()
        {
            extract_check(z8);
            extract_check(z8i);
            extract_check(z16);
            extract_check(z16i);
            extract_check(z32);
            extract_check(z32i);
            extract_check(z64);
            extract_check(z64i);
        }

        void loadscalar_check<T>(T t = default)
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

            CheckAction<T>(check, "loadscalar");
        }
            
        void extract_check<T>(T t = default)
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

            CheckAction<T>(check, "extract");

        }

        void bitspan_check(Span<byte> packed, BitSpan bitspan)
        {
            var bitcount = bitspan.Length;
            for(int i=0, k = 0; i < packed.Length; i++, k += 8)
            for(var j=0; j < 8; j++)
                Claim.eq(BitMask.testbit(packed[i], j), bitspan[k + j]);
        }
    }
}