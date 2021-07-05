//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public interface IAsmInstruction
    {
        AsmMnemonicCode Mnemonic {get;}

        AsmHexCode Encoded {get;}

        ReadOnlySpan<byte> Data {get;}

        ReadOnlySpan<AsmByte> Bytes {get;}

        byte Size {get;}
    }

    public interface IAsmInstruction<T> : IAsmInstruction
        where T : unmanaged, ITypedInstruction<T>
    {
        T Instruction {get;}

        AsmHexCode IAsmInstruction.Encoded
            => Instruction.Encoded;

        ReadOnlySpan<byte> IAsmInstruction.Data
            => bytes(Instruction);

        ReadOnlySpan<AsmByte> IAsmInstruction.Bytes
            => recover<AsmByte>(Data);

        AsmMnemonicCode IAsmInstruction.Mnemonic
            => Instruction.Mnemonic;
    }
}