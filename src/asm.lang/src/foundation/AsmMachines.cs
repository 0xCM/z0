//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
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

        [Op]
        public static V512Bank vbank(W512 w, byte count)
            => new V512Bank(new Cell512[count]);

        [Op]
        public static V256Bank vbank(W256 w, byte count)
            => new V256Bank(new Cell256[count]);

        [Op]
        public static V128Bank vbank(W128 w, byte count)
            => new V128Bank(new Cell128[count]);

        [Op]
        public static Gp64Bank gpbank(W64 w, byte count)
            => new Gp64Bank(new Cell64[count]);

        public static void run(ref AsmMachine m)
        {

        }
    }
}