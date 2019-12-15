//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_sb_pop : t_sb<t_sb_pop>
    {                
        public void sb_pop_popcnt()
        {
            var buffer16x8 = DataBlocks.alloc<byte>(n128);
            var src = (ushort)0b11001111;

            var srcPop = Bits.pop(src);
            Claim.eq(6,srcPop);

            Bits.unpack16x1(src,buffer16x8);

            var bytes = BitConvert.GetBytes(src);
            Claim.eq(2, bytes.Length);
            
            Claim.eq(srcPop, bytes.PopCount());
            var buffer64x8 = DataBlocks.alloc<byte>(n256,2);
    
            for(var i=0; i< SampleSize; i++)
            {
                var y = BitConverter.GetBytes(Random.Next<ulong>()).ToSpan();
                y.Unpack(buffer64x8);
                Claim.eq(buffer64x8.Data.PopCount(), y.PopCount());
            }

            var bits5 = Random.Span<byte>(5);
            var bits5x64 = Bytes.read<ulong>(bits5);
            var bc5x64PC = Bits.pop(bits5x64);
            var bits5up = bits5.Unpack();
            var bits5upPC = bits5up.PopCount();
            var bits5PC = bits5.PopCount();

            Claim.eq(bc5x64PC, bits5upPC);
            Claim.eq(bc5x64PC, bits5PC);

            var bits279 = Random.Span<byte>(279);
            var bits279PC = bits279.PopCount();
            var bits279upPC = bits279.Unpack().PopCount();
            Claim.eq(bits279upPC, bits279PC);
        }
    }
}