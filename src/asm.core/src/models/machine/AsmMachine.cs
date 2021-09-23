//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOperands;
    using static asm;

    public abstract class AsmMachine<M>
        where M : AsmMachine<M>, new()
    {


    }


    public readonly partial struct AsmMachines
    {

        public sealed class CmpMachine : AsmMachine<CmpMachine>
        {
            Index<AsmInstruction> Buffer;

            public CmpMachine()
            {
                Buffer = core.alloc<AsmInstruction>(128);
            }


        }
    }
}