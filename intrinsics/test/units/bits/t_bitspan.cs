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
            BitPack.unpack32x8(src, buffer.AsBytes());
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
            var bytecount = RepCount;
            Block256<uint> unpacked = DataBlocks.alloc(n256,bytecount,z32);
            Block64<byte> buffer = DataBlocks.single(n64,z8);
            Span<byte> packed = stackalloc byte[bytecount];
            
            for(var i=0; i<RepCount; i++)            
            {
                Random.Fill(packed);
                BitPack.unpack8x32(packed, buffer, unpacked);
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

            for(var i=0; i<RepCount; i++)
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

            for(var i=0; i<RepCount; i++)
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

            for(var i=0; i<RepCount; i++)
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

            for(var i=0; i<RepCount; i++)
            {
                Random.Fill(packed);
                var bitspan = packed.ToBitSpan();                
                bitspan_check(packed.AsBytes(),bitspan);
            }
        }

        public void bitspan_from_scalar()
        {
            bitspan_from_scalar_check(z8);
            bitspan_from_scalar_check(z8i);
            bitspan_from_scalar_check(z16);
            bitspan_from_scalar_check(z16i);
            bitspan_from_scalar_check(z32);
            bitspan_from_scalar_check(z32i);
            bitspan_from_scalar_check(z64);
            bitspan_from_scalar_check(z64i);
        }

        public void bitspan_to_scalar()
        {
            bitspan_to_scalar_check(z8);
            bitspan_to_scalar_check(z8i);
            bitspan_to_scalar_check(z16);
            bitspan_to_scalar_check(z16i);
            bitspan_to_scalar_check(z32);
            bitspan_to_scalar_check(z32i);
            bitspan_to_scalar_check(z64);
            bitspan_to_scalar_check(z64i);
        }

        void bitspan_from_scalar_check<T>(T t = default)
            where T : unmanaged
        {
            void check()
            {
                Span<byte> bytes = stackalloc byte[size(t)];
                for(var i=0; i < RepCount; i++)
                {
                    var src = Random.Single(t);                
                    var bitspan = BitPack.bitspan(src);
                    BitConvert.GetBytes(src,bytes);
                    bitspan_check(bytes, bitspan);
                }
            }

            CheckAction<T>(check, "bitspan_from_scalar");
        }

            
        void bitspan_to_scalar_check<T>(T t = default)
            where T : unmanaged
        {
            void check()
            {
                for(var i=0; i< RepCount; i++)
                {
                    var x = Random.Single<T>();
                    var y = BitPack.bitspan(x);
                    var z = BitPack.scalar<T>(y);
                    Claim.eq(x,z);
                }
            }  

            CheckAction<T>(check, "bitspan_to_scalar");

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