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
        public void sb_pop_bitstore()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var src = Random.Next<ulong>();
                var pc1 = BitStore.pop(src);
                var pc2 = Bits.pop(src);
                Claim.eq(pc1,pc2);
            }
        }

        public void sb_pop_popcnt()
        {
            Span<byte> bits16 = stackalloc byte[16];
            var src = (ushort)0b11001111;
            Bits.unpack16x1(src,bits16);
            var bitsPC = bits16.PopCount();
            Claim.eq(6,bitsPC);

            var bytes = BitConvert.GetBytes(src);
            Claim.eq(2, bytes.Length);
            
            var bytesPC = bytes.PopCount();
            Claim.eq(bitsPC, bytesPC);

            Span<byte> bits64 = stackalloc byte[64];
    
            for(var i=0; i< SampleSize; i++)
            {
                var y = BitConverter.GetBytes(Random.Next<ulong>()).ToSpan();
                y.Unpack(bits64);
                Claim.eq(bits64.PopCount(), y.PopCount());
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