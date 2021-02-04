//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

    partial struct AsmDocParts
    {
        /// <summary>
        /// Captures the data required to specify an asm statement, e.g. 'mov rcx,rsi
        /// </summary>
        public readonly struct Statement
        {
            public AsmMnemonic Mnemonic {get;}

            public string[] Operands {get;}

            [MethodImpl(Inline)]
            public Statement(AsmMnemonic mnemonic, string[] operands)
            {
                Mnemonic = mnemonic;
                Operands = operands;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Mnemonic.IsEmpty || (Operands is null || Operands.Length == 0);
            }

            public string Format()
            {
                var operands =  Operands is null ? string.Empty : Operands.Length != 0 ?Operands.Concat(Chars.Comma) : string.Empty;
                var mnemonic = Mnemonic.ToString().ToLower();
                return text.concat(mnemonic, Chars.Space, operands);
            }

            public override string ToString()
                => Format();
        }
    }
}