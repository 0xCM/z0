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
        public MemoryAddress BaseAddress {get;}

        public ApiCodeBlock Encoded {get;}

        public IceInstruction Instruction {get;}

        [MethodImpl(Inline)]
        public ApiInstruction(MemoryAddress @base, IceInstruction fx, ApiCodeBlock encoded)
        {
            BaseAddress = @base;
            Instruction = fx;
            Encoded = encoded;
        }

        public byte ByteLength
        {
            [MethodImpl(Inline)]
            get => (byte)Instruction.ByteLength;
        }

        public OpIdentity OpId
            => Encoded.OpId;

        public BinaryCode EncodedData
            => Encoded.Data;

        public MemoryAddress Offset
        {
            [MethodImpl(Inline)]
            get => IP - BaseAddress;
        }

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

        public AsmOpCodeExpr OpCode
            => asm.opcode(Instruction.OpCode.OpCodeString);
    }
}