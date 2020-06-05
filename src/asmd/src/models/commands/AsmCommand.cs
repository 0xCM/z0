//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines an encoded instruction
    /// </summary>
    public readonly struct AsmCommand : IAsmCommand<AsmCommand>
    {        
        public int Sequence {get;}

        public AsmStatement Statement {get;}

        public AsmOpCode OpCode {get;}

        public AsmInstructionCode Instruction {get;}

        public EncodedCommand Encoded {get;}

        [MethodImpl(Inline)]
        internal AsmCommand(int seq, AsmStatement statement, string opcode, string instruction, EncodedCommand encoded)
        {
            this.Sequence = seq;
            this.Statement = statement;
            this.OpCode = new AsmOpCode(opcode);
            this.Instruction = new AsmInstructionCode(instruction);
            this.Encoded = encoded;
        }
        
        public byte EncodingSize
        {
            [MethodImpl(Inline)]
            get => Encoded.EncodingSize;
        }
    }
}