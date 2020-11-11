//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static z;

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
            var bits = BitFields.create<EFlagBits>(w32);
            bits[EFlagBits.ZF] = 1;

            var index = bits.FieldIndex(EFlagBits.ZF);
            Claim.eq((uint5)6, index);
            Claim.yea(bits[EFlagBits.ZF]);

            bits[EFlagBits.ZF] = 0;
            Claim.nea(bits[EFlagBits.ZF]);
        }
    }
}
