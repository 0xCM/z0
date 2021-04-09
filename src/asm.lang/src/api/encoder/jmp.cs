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
    using static AsmOps;
    using static AsmHexCodes;

    partial struct AsmEncoder
    {
        /// <summary>
        /// | FF /4       | JMP r/m64    | M     | Valid
        /// </summary>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public Jmp jmp(r64 dst)
            => Builder.jmp(asmhex(xff));
    }
}