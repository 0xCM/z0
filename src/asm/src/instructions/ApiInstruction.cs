//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an instruction within the context of the defining api member
    /// </summary>
    public readonly struct ApiInstruction
    {
        public X86ApiCode Encoded {get;}

        public Instruction Instruction {get;}

        public MemoryAddress BaseAddress {get;}

        public OpUri OpUri
            => Encoded.OpUri;

        public OpIdentity OpId
            => OpUri.OpId;

        public string FormattedInstruction
            => Instruction.FormattedInstruction;

        public AsmSpecifier InstructionCode
            => Instruction.InstructionCode;

        public MemoryAddress IP
            => Instruction.IP;

        public MemoryAddress NextIp
            => Instruction.NextIP;

        public Mnemonic Mnemonic
            => Instruction.Mnemonic;

        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int ByteLength
            => Instruction.ByteLength;

        [MethodImpl(Inline)]
        public static ApiInstruction define(MemoryAddress @base, Instruction fx, X86ApiCode encoded)
            => new ApiInstruction(@base, fx, encoded);

        public static ApiInstruction[] map(X86ApiCode code, Instruction[] src)
        {
            var @base = code.Base;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var data = z.span(code.Encoded.Data);
                var slice = data.Slice((int)offseq.Offset, fx.ByteLength).ToArray();
                var recoded = new X86ApiCode(code.OpUri, fx.IP, slice);
                dst[i] = define(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)fx.ByteLength);
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public ApiInstruction(MemoryAddress @base, Instruction fx, X86ApiCode encoded)
        {
            BaseAddress = @base;
            Instruction = fx;
            Encoded = encoded;
        }
    }
}