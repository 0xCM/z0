//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public class t_pop : t_bitcore<t_pop>
    {                
        static Span<byte> unpack8x1(ReadOnlySpan<byte> src, Span<byte> dst)
        {            
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                BitStore.select(src[i]).CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<byte> Unpack(Span<byte> src)
            => unpack8x1(src, new byte[src.Length*8]);

        [MethodImpl(Inline)]        
        public static void Unpack(Span<byte> src, Span<byte> dst)
            => unpack8x1(src, dst);

        public void sb_pop_popcnt()
        {
            var buffer16x8 = Blocks.alloc<byte>(n128);
            var src = (ushort)0b11001111;

            var srcPop = Bits.pop(src);
            Claim.eq(6,srcPop);

            Bits.unpack16x1(src,buffer16x8);

            var bytes = BitConvert.GetBytes(src);
            Claim.eq(2, bytes.Length);
            
            Claim.eq(srcPop, bytes.PopCount());
            var buffer64x8 = Blocks.alloc<byte>(n256,2);
    
            for(var i=0; i< RepCount; i++)
            {
                var y = BitConverter.GetBytes(Random.Next<ulong>()).ToSpan();
                Unpack(y,buffer64x8);
                Claim.eq(buffer64x8.Data.PopCount(), y.PopCount());
            }

            // var bits5 = Random.Span<byte>(5);
            // var bits5x64 = Bytes.cell<ulong>(bits5);
            // var bc5x64PC = Bits.pop(bits5x64);
            // var bits5up = Unpack(bits5);
            // var bits5upPC = bits5up.PopCount();
            // var bits5PC = bits5.PopCount();

            // Claim.eq(bc5x64PC, bits5upPC);
            // Claim.eq(bc5x64PC, bits5PC);

            // var bits279 = Random.Span<byte>(279);
            // var bits279PC = bits279.PopCount();
            // var bits279upPC = Unpack(bits279).PopCount();
            // Claim.eq(bits279upPC, bits279PC);
        }
    }
}