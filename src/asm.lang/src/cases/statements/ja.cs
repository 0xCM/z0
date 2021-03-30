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

    using M = AsmMnemonicCode;

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

            /// <summary>
            /// PUSH r16 | 50 +rw
            /// </summary>
            /// <param name="r"></param>
            [MethodImpl(Inline), Op]
            public static AsmStatement<r16> push(r16 r)
                => asm.statement(M.PUSH, r);

            /// <summary>
            /// PUSH r32 | 50 +rd
            /// </summary>
            /// <param name="r"></param>
            [MethodImpl(Inline), Op]
            public static AsmStatement<r32> push(r32 r)
                => asm.statement(M.PUSH, r);

            /// <summary>
            /// PUSH r64 | 50 +ro
            /// </summary>
            /// <param name="r"></param>
            [MethodImpl(Inline), Op]
            public static AsmStatement<r64> push(r64 r)
                => asm.statement(M.PUSH, r);
        }
    }
}