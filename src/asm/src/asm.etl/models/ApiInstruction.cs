//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an instruction within the context of the defining api member
    /// </summary>
    public readonly struct ApiInstruction
    {
        public ApiCodeBlock Encoded {get;}

        public IceInstruction Instruction {get;}

        [MethodImpl(Inline)]
        public ApiInstruction(IceInstruction fx, ApiCodeBlock encoded)
        {
            Instruction = fx;
            Encoded = encoded;
        }

        public byte ByteLength
        {
            [MethodImpl(Inline)]
            get => (byte)Instruction.ByteLength;
        }

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Encoded.BaseAddress;
        }

        public string OpId
            => Encoded.OpId;

        public BinaryCode EncodedData
            => Encoded.Data;

        public string FormattedInstruction
        {
            [MethodImpl(Inline)]
            get => Instruction.FormattedInstruction;
        }

        public AsmInstructionSpecExprLegacy Specifier
            => Instruction.Specifier;

        public MemoryAddress IP
            => Instruction.IP;

        public MemoryAddress NextIp
            => Instruction.NextIP;

        public IceMnemonic Mnemonic
            => Instruction.Mnemonic;

        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int Size
            => Instruction.ByteLength;
    }
}