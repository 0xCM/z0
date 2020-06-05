//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public interface IAsmCommand : IEncodedCommand, ISequential
    {
        AsmStatement Statement {get;}

        AsmOpCode OpCode {get;}

        AsmInstructionCode Instruction {get;}

        EncodedCommand Encoded {get;}

        ReadOnlySpan<byte> IEncodedCommand.Encoding 
            => Encoded.Encoding;

        byte IEncodedCommand.EncodingSize 
            => Encoded.EncodingSize;
    }

    public interface IAsmCommand<F> : IAsmCommand, IEncodedCommand<F>
        where F: struct, IAsmCommand<F>
    {

    }
}