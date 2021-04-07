//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmInstructions;
    using static Hex8Seq;
    using static AsmRegOps;
    using static AsmHexCodes;
    using static AsmImm;

    partial struct AsmStatement
    {
        /// <summary>
        /// | FF /4       | JMP r/m64    | M     | Valid
        /// </summary>
        /// <param name="dst"></param>
        public Jmp jmp(r64 dst)
            => Builder.jmp(asmhex(xff));
    }
}