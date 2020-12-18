//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    using static z;

    public class t_invoke : t_asm<t_invoke>
    {
        public static AsmCall Invoke8u
            => asm.call("Arrays.empty_8u ", 0x7ff9af96c260, 0x0f, 0x7ff9af96b9c8, "sys.empty_8u", 0x7ff9af971d40);

        public static AsmCall Invoke16u
            => asm.call("Arrays.empty_16u", 0x7ff9af96c2c0, 0x0f, 0x7ff9af96ba08, "sys.empty_16u", 0x7ff9af971db0);

        public static AsmCall Invoke16i
            => asm.call("Arrays.empty_16i",0x7ff9af96c2f0, 0x0f, 0x7ff9af96ba28, "sys.empty_16i", 0x7ff9af971df0);

        public static AsmCall Invoke32u
            => asm.call("Arrays.empty_32u",0x7ff9af96c320, 0x0f, 0x7ff9af96ba48, "sys.empty_32u", 0x7ff9af971e30);

        public static AsmCall Invoke64u
            => asm.call("Arrays.empty_64u", 0x7ff9af96c380, 0x0f, 0x7ff9af96ba88, "sys.empty_64u", 0x7ff9af971eb0);

        public void print_calls()
        {
            var samples = z.array(Invoke8u, Invoke16u, Invoke16i, Invoke32u, Invoke64u);
            for(var i=0u; i<samples.Length; i++)
                Trace(skip(samples,i).Format());
        }
    }
}