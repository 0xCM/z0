//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using static Root;
    
    public class t_eflags : t_asmd<t_eflags>
    {
        public void modrm_encode()
        {
            var dst = ModRmEncoder.Table();
            var count = dst.Length;
            
            Claim.eq(256,count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var encoding = ref skip(dst,i);
                //Trace(encoding.Format());

            }
        }

        public void test_flag_bits()
        {
            var bits = BitField32.alloc<FlagRegBits>();
            bits[FlagRegBits.ZF] = 1;
            
            var index = bits.FieldIndex(FlagRegBits.ZF);
            Claim.eq(6, index);
            Claim.yea(bits[FlagRegBits.ZF]);

            bits[FlagRegBits.ZF] = 0;
            Claim.nea(bits[FlagRegBits.ZF]);
        }
    }
}
