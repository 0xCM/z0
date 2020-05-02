//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class t_eflags : UnitTest<t_eflags>
    {
        public void test_flag_bits()
        {
            var bits = BitField32.Alloc<EFLAG>();
            bits[EFLAG.ZF] = 1;
            
            var index = bits.FieldIndex(EFLAG.ZF);
            Claim.eq(6, index);
            Claim.yea(bits[EFLAG.ZF]);

            bits[EFLAG.ZF] = 0;
            Claim.nea(bits[EFLAG.ZF]);
        }
    }
}
