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
    using static AsmInstructions;
    using static Hex8Seq;
    using static AsmCodes;

    partial struct AsmEncodings
    {
        [ApiHost("encodings.logic")]
        public readonly partial struct Logic
        {
            /// <summary>
            /// (AND AL, imm8)[24 ib]
            /// </summary>
            /// <param name="r"></param>
            /// <param name="imm8"></param>
            public static AsmHexCode and(al r, Imm8 imm8)
                => AsmEncoder.encode(x24, imm8);

            /// <summary>
            /// (AND r/m8, imm8)[80 /4 ib]
            /// </summary>
            /// <param name="r"></param>
            /// <param name="imm8"></param>
            [MethodImpl(Inline), Op]
            public static AsmHexCode and(r8b r, Imm8 imm8)
                => AsmEncoder.encode(x24, imm8);
        }
    }
}