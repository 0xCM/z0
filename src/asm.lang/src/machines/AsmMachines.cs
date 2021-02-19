//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static AsmRegBanks;

    [ApiHost]
    public readonly partial struct AsmMachines
    {
        [Op]
        public static AsmMachine machine(N0 n)
        {
            var regs =  new AsmRegBank(vbank(w512,32), gpbank(w64, 16));
            var machine = new AsmMachine(regs);
            return machine;
        }


        public static void run(ref AsmMachine m)
        {


        }
    }
}