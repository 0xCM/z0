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
            var bits = BitField32.Create<EFLAG>();
            bits[EFLAG.ZF] = 1;
            
            var index = bits.ComponentIndex(EFLAG.ZF);
            trace(index.ToString());
            trace(bits.Format());
        }
    }
}
