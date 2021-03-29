//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;
    using static AsmMem;
    using static AsmInstructions;
    using static Hex8Seq;
    partial class AsmCases
    {
        partial struct Statements
        {
            /// <summary>
            /// (JA rel8) 77 cb
            /// </summary>
            /// <param name="cb"></param>
            [MethodImpl(Inline), Op]
            public Ja ja(Address8 cb)
                => Builder.ja(AsmBytes.define(x77, cb));

            /// <summary>
            /// (JA rel32) 0F 87 cd
            /// </summary>
            /// <param name="cb"></param>
            [MethodImpl(Inline), Op]
            public Ja ja(Address32 cd)
                => Builder.ja(AsmBytes.define(x77, cd));

            // public AsmStatement ja(byte imm8)
            //     => new AsmStatement(Builder.ja(), new Args(asm.imm8(imm8)));
        }
    }
}