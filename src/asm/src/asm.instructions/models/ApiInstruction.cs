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

        public MemoryAddress Base {get;}

        public string OpId
            => Encoded.OpId;

        public BinaryCode EncodedData
            => Encoded.Data;

        public string FormattedInstruction
            => Instruction.FormattedInstruction;

        public AsmSpecifier Specifier
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

        [MethodImpl(Inline)]
        public ApiInstruction(MemoryAddress @base, IceInstruction fx, ApiCodeBlock encoded)
        {
            Base = @base;
            Instruction = fx;
            Encoded = encoded;
        }
    }
}