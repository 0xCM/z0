//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BasedAsmFx : IAsmFxInfo<Instruction>
    {
        public X86ApiCode Encoded {get;}

        public OffsetSequence OffsetSeq {get;}

        public Instruction Instruction {get;}

        public MemoryAddress BaseAddress {get;}

        /// <summary>
        /// The encoded content as byte array
        /// </summary>
        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public OpUri OpUri
            => Encoded.OpUri;

        public OpIdentity OpId
            => OpUri.OpId;

        public string FormattedInstruction
            => Instruction.FormattedInstruction;

        public AsmFxCode InstructionCode
            => Instruction.InstructionCode;

        public MemoryAddress IP
            => Instruction.IP;

        public MemoryAddress NextIp
            => Instruction.NextIP;

        public MemoryAddress NextIp16
            => Instruction.NextIP16;

        public MemoryAddress NextIp32
            => Instruction.NextIP32;

        public Mnemonic Mnemonic
            => Instruction.Mnemonic;

        /// <summary>
        /// The encoded byte count
        /// </summary>
        public int ByteLength
            => Instruction.ByteLength;

        [MethodImpl(Inline)]
        public static BasedAsmFx One(MemoryAddress @base, OffsetSequence offseq, Instruction fx, X86ApiCode encoded)
            => new BasedAsmFx(@base, offseq, fx, encoded);

        public static BasedAsmFx[] Many(X86ApiCode code, Instruction[] src)
        {
            var @base = code.Address;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new BasedAsmFx[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var data = z.span(code.Encoded.Data);
                var slice = data.Slice((int)offseq.Offset, fx.ByteLength).ToArray();
                var recoded = new X86ApiCode(code.OpUri, fx.IP, slice);
                dst[i] = One(@base, offseq, fx, recoded);
                offseq = offseq.AccrueOffset((uint)fx.ByteLength);
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public BasedAsmFx(MemoryAddress @base, OffsetSequence offseq, Instruction fx, X86ApiCode encoded)
        {
            BaseAddress = @base;
            OffsetSeq = offseq;
            Instruction = fx;
            Encoded = encoded;
        }
    }
}