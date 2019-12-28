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

        public void bitspan_load_reference()
        {
            var src = uint.MaxValue;
            Span<uint> buffer = new uint[32];
            BitPack.unpack(src, buffer.AsBytes());
            Trace(buffer.AsBytes().FormatList());        
        }

        public void bitspan_format_direction()
        {
            byte src = 1;
            var bitspan = BitPack.bitspan(src);
            var fmt = bitspan.Format();
            Claim.eq(8,fmt.Length);
            Claim.eq(bit.One, fmt[7]);

        }

        public void bitspan_buffered_8()
        {            
            var bytecount = SampleCount;
            Block256<uint> unpacked = DataBlocks.alloc(n256,bytecount,z32);
            Block64<byte> buffer = DataBlocks.single(n64,z8);
            Span<byte> packed = stackalloc byte[bytecount];
            
            for(var i=0; i<SampleCount; i++)            
            {
                Random.Fill(packed);
                BitPack.unpack(packed, buffer, unpacked);
                var bitspan = BitSpan.load(unpacked.As<bit>());
                bitspan_check(packed,bitspan);
            }
            
        }

        public void bitspan_outline_16()
        {
            const int length = 16;
            var src = BitMask.even(n2, n1, z16);
            var bitspan = BitPack.bitspan(src);
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

        public void bitspan_outline_32()
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

        public void bitspan_outline_64()
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

        public void bitspan_from_span8()
        {
            var length = 64;
            Span<byte> packed = stackalloc byte[length];

            for(var i=0; i<SampleCount; i++)
            {
                Random.Fill(packed);
                var bitspan = packed.ToBitSpan();                
                bitspan_check(packed,bitspan);
            }

        }

        public void bitspan_from_span16()
        {
            var length = 64;
            Span<ushort> packed = stackalloc ushort[length];

            for(var i=0; i<SampleCount; i++)
            {
                Random.Fill(packed);
                var bitspan = packed.ToBitSpan();                
                bitspan_check(packed.AsBytes(),bitspan);
            }
        }

        public void bitspan_from_span32()
        {
            var length = 64;
            Span<uint> packed = stackalloc uint[length];

            for(var i=0; i<SampleCount; i++)
            {
                Random.Fill(packed);
                var bitspan = packed.ToBitSpan();                
                bitspan_check(packed.AsBytes(),bitspan);
            }
        }

        public void bitspan_from_span64()
        {
            var length = 64;
            Span<ulong> packed = stackalloc ulong[length];

            for(var i=0; i<SampleCount; i++)
            {
                Random.Fill(packed);
                var bitspan = packed.ToBitSpan();                
                bitspan_check(packed.AsBytes(),bitspan);
            }
        }


        public void bitspan_from_scalar8()
        {
            var length = 8;
            var t = z8;

            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Bytes(length).ToSpan();
                var bitspan = src.ToBitSpan();                
                bitspan_check(src,bitspan);
            }

            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next(t);                
                var bitspan = src.ToBitSpan();                
                bitspan_check(new byte[]{src},bitspan);
            }

        }    

        public void bitspan_from_scalar16()
        {        
            var t = z16;
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next(t);                
                var bitspan = src.ToBitSpan();                
                bitspan_check(src.AsBytes(),bitspan);
            }
        }

        public void bitspan_from_scalar32()
        {        
            var t = z32;
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next(t);                
                var bitspan = src.ToBitSpan();                
                bitspan_check(src.AsBytes(), bitspan);
            }
        }

        public void bitspan_from_scalar64()
        {        
            var t = z64;
            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Next(t);                
                var bitspan = src.ToBitSpan();                
                bitspan_check(src.AsBytes(), bitspan);
            }
        }

        public void bitspan_to_scalar8()
        {
            var n = n8;
            for(var i=0; i< SampleCount; i++)
            {
                var src = Random.Single(n);

                var bs = src.ToBitSpan();            
                Claim.eq(n,bs.Length);        
                
                var dst = BitPack.pack(bs,n);
                Claim.eq(src,dst);
            }            
        }

        public void bitspan_to_scalar16()
        {
            var n = n16;            
            for(var i=0; i< SampleCount; i++)
            {
                var src = Random.Single(n);
                
                var bs = src.ToBitSpan();            
                Claim.eq(n,bs.Length);        

                var dst = BitPack.pack(bs,n);
                Claim.eq(src,dst);
            }            
        }

        public void bitspan_to_scalar32()
        {
            var n = n32;            
            for(var i=0; i< SampleCount; i++)
            {
                var src = Random.Single(n);

                var bs = src.ToBitSpan();            
                Claim.eq(n,bs.Length);        

                var dst = BitPack.pack(bs,n);
                Claim.eq(src,dst);

            }
            
        }

        public void bitspan_to_scalar64()
        {
            var n = n64;            

            for(var i=0; i<SampleCount; i++)
            {
                var src = Random.Single(n);            
                
                var bs = src.ToBitSpan();    
                Claim.eq(n, bs.Length);    

                Claim.eq(src,BitPack.pack(bs,n));
            }

        }

        static void ones_check<T>(T t = default)
            where T : unmanaged
        {
            var length = bitsize(t);
            var ones = gmath.ones(t);
            var bs = BitPack.bitspan(ones);
            Claim.eq(length, bs.Length);
            Claim.eq(length, bs.Pop());

        }

        public void ones_check()
        {
            ones_check(z8);   
            ones_check(z8i);   
            ones_check(z16);   
            ones_check(z16i);   
            ones_check(z32);   
            ones_check(z32i);   
            ones_check(z64);   
            ones_check(z64i);   
        }

        protected static void bitspan_check(Span<byte> packed, BitSpan bitspan)
        {
            var bitcount = bitspan.Length;
            for(int i=0, k = 0; i < packed.Length; i++, k += 8)
            for(var j=0; j< 8; j++)
                Claim.eq(BitMask.testbit(packed[i], j), bitspan[k + j]);
        }
    }
}