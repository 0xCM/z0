//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Gone2;

    public class t_eflags : UnitTest<t_eflags>
    {

        public void test_flag_bits()
        {
            var bits = BitField32.Create<EFLAG>();
            bits[EFLAG.ZF] = 1;
            
            var index = bits.ComponentIndex(EFLAG.ZF);
            NotifyConsole(index.ToString());
            NotifyConsole(bits.Format());

        }
    }
}
