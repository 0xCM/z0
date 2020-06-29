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
    public readonly struct AsmCommand : IAsmCommand<AsmCommand>
    {        
        public int Sequence {get;}

        public AsmStatement Statement {get;}

        public AsmOpCode OpCode {get;}

        public InstructionCodeData Instruction {get;}

        public EncodedCommand Encoded {get;}

        [MethodImpl(Inline)]
        public AsmCommand(int seq, AsmStatement statement, string opcode, string instruction, EncodedCommand encoded)
        {
            this.Sequence = seq;
            this.Statement = statement;
            this.OpCode = new AsmOpCode(opcode);
            this.Instruction = new InstructionCodeData(instruction);
            this.Encoded = encoded;
        }
        
        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => Encoded.EncodingSize;
        }
    }
}