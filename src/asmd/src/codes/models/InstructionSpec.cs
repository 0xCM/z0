//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public readonly struct InstructionSpec
    {        
        public static InstructionSpec Empty 
            => new InstructionSpec(InstructionExpression.Empty, string.Empty, Control.array<string>());        
        
        public InstructionExpression Source {get;}
        
        public string Mnemonic {get;}

        public string[] Operands {get;}

        public int Arity => Operands.Length;

        [MethodImpl(Inline)]
        public InstructionSpec(InstructionExpression src, string mnemonic, string[] operands)
        {
            Source = src;
            Mnemonic = mnemonic;
            Operands = operands;
        }
    }
}