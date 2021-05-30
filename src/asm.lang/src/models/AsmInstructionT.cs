//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct AsmInstruction<T> : IAsmInstruction<T>
        where T : unmanaged, ITypedInstruction<T>
    {
        public T Instruction {get;}

        [MethodImpl(Inline)]
        public AsmInstruction(T encoded)
            => Instruction = encoded;

        public AsmHexCode Encoded
        {
            [MethodImpl(Inline)]
            get => Instruction.Encoded;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => bytes(Instruction);
        }

        public ReadOnlySpan<AsmByte> Bytes
        {
            [MethodImpl(Inline)]
            get => recover<AsmByte>(Data);
        }

        public AsmMnemonicCode Mnemonic
        {
            [MethodImpl(Inline)]
            get => Instruction.Mnemonic;
        }

        public uint4 Size
        {
            [MethodImpl(Inline)]
            get => (uint4)Data.Length;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmInstruction<T>(T src)
            => new AsmInstruction<T>(src);
    }
}