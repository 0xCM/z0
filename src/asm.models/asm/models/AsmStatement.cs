//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmStatement
    {        
        public static AsmStatement Empty => new AsmStatement(Mnemonic.INVALID, sys.empty<string>());

        public Mnemonic Mnemonic {get;}

        public string[] Operands {get;}
        
        [MethodImpl(Inline)]
        public AsmStatement(Mnemonic mnemonic, string[] operands)
        {
            Mnemonic = mnemonic;
            Operands = operands;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Mnemonic == 0 && (Operands is null || Operands.Length == 0);
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