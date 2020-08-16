//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly struct AsmCommand
    {        
        public int Sequence {get;}

        public AsmStatement Statement {get;}

        public string OpCode {get;}

        public AsmFxCodeData Instruction {get;}

        public EncodedFx Encoded {get;}

        [MethodImpl(Inline)]
        public AsmCommand(int seq, AsmStatement statement, string opcode, string instruction, EncodedFx encoded)
        {
            Sequence = seq;
            Statement = statement;
            OpCode = opcode;
            Instruction = new AsmFxCodeData(instruction);
            Encoded = encoded;
        }
        
        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => Encoded.EncodingSize;
        }
    }
}