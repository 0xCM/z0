//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Describes an instruction within the context of the defining api member
    /// </summary>
    public readonly struct ApiInstruction
    {
        public static LocalOffsetVector offsets(Index<ApiInstruction> src)
        {
            var offsets = src.View;
            var count = src.Length;
            var buffer = alloc<Address16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = (Address16)skip(offsets,i).Offset;
            return buffer;
        }

        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        public static Index<ApiInstruction> filter(Index<ApiInstruction> src, AsmMnemonicCode mnemonic)
            => from a in src.Storage
                let i = a.Instruction
                where i.AsmMnemonic == mnemonic.ToString()
                select a;

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

        public AsmStatementExpr Statment
        {
            [MethodImpl(Inline)]
            get => Instruction.FormattedInstruction;
        }

        public AsmFormExpr AsmForm
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
            => AsmCore.opcode(Instruction.OpCode.OpCodeString);
    }
}