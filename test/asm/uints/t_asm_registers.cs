//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;


    public sealed class t_asm_registers : t_asm<t_asm_registers>
    {
        public void t_register_lookup()
        {
            var lookup = Registers.lookup();
            Claim.yea(lookup.Gp32.Count == 16);
        }
    }
}
