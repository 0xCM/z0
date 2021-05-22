//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Describes an instruction within the context of the defining api member
    /// </summary>
    public class ApiInstruction : IComparable<ApiInstruction>
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

        public byte InstructionSize
        {
            [MethodImpl(Inline)]
            get => (byte)Instruction.InstructionSize;
        }

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => Encoded.OpUri.Part;
        }

        public OpUri Uri
        {
            [MethodImpl(Inline)]
            get => Encoded.OpUri;
        }

        public OpIdentity OpId
        {
            [MethodImpl(Inline)]
            get => Encoded.OpId;
        }

        public BinaryCode EncodedData
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public AsmHexCode AmsHex
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public MemoryAddress Offset
        {
            [MethodImpl(Inline)]
            get => IP - BaseAddress;
        }

        public AsmStatementExpr Statment
        {
            [MethodImpl(Inline)]
            get => Instruction.FormattedInstruction;
        }

        public AsmFormExpr AsmForm
        {
            [MethodImpl(Inline)]
            get => Instruction.Specifier;
        }

        public MemoryAddress IP
        {
            [MethodImpl(Inline)]
            get => Instruction.IP;
        }

        public MemoryAddress NextIp
        {
            [MethodImpl(Inline)]
            get => Instruction.NextIP;
        }

        public IceMnemonic Mnemonic
        {
            [MethodImpl(Inline)]
            get => Instruction.Mnemonic;
        }

        public AsmMnemonic MnemonicExpr
        {
            [MethodImpl(Inline)]
            get => Mnemonic.ToString();
        }

        // public AsmMnemonicCode MnemonicCode
        // {
        //     get => MnemonicExpr;
        // }

       public AsmOpCodeExpr OpCode
       {
            [MethodImpl(Inline)]
            get => AsmCore.opcode(Instruction.OpCode.OpCodeString);
       }

        [MethodImpl(Inline)]
        public int CompareTo(ApiInstruction src)
            => IP.CompareTo(src.IP);
    }
}