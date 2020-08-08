//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IAsmCommand : IEncodedCommand, ISequential
    {
        AsmStatement Statement {get;}

        string OpCode {get;}

        InstructionCodeData Instruction {get;}

        EncodedCommand Encoded {get;}

        byte IEncodedCommand.EncodingSize 
            => Encoded.EncodingSize;
    }

    public interface IAsmCommand<F> : IAsmCommand, IEncodedCommand<F>
        where F: struct, IAsmCommand<F>
    {

    }
}