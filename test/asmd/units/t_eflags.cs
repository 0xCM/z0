//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using static Control;
    
    public class t_eflags : t_asmd<t_eflags>
    {
        public void modrm_encode()
        {
            var encoder = PrefixEncoders.ModRm;
            Span<ModRmEncoding> dst = new ModRmEncoding[1024];
            var count = encoder.table(dst);
            Claim.eq(256,count);
            
            for(var i=0; i<count; i++)
            {
                ref readonly var encoding = ref skip(dst,i);
                //Trace(encoding.Format());

            }


        }

        public void test_flag_bits()
        {
            var bits = BitField32.Alloc<EFlagBits>();
            bits[EFlagBits.ZF] = 1;
            
            var index = bits.FieldIndex(EFlagBits.ZF);
            Claim.eq(6, index);
            Claim.yea(bits[EFlagBits.ZF]);

            bits[EFlagBits.ZF] = 0;
            Claim.nea(bits[EFlagBits.ZF]);
        }
    }
}
