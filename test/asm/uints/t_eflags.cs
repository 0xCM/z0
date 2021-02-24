//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static z;

    public class t_eflags : t_asm<t_eflags>
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
            // var bits = BitFieldsLegacy.create<EFlagKind>(w32);
            // bits[EFlagKind.ZF] = 1;

            // var index = bits.FieldIndex(EFlagKind.ZF);
            // Claim.eq((uint5)6, index);
            // Claim.yea(bits[EFlagKind.ZF]);

            // bits[EFlagKind.ZF] = 0;
            // Claim.nea(bits[EFlagKind.ZF]);
        }
    }
}
