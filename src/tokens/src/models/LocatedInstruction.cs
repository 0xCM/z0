//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LocatedInstruction : IInstructionInfo<Instruction>
    {
        public MemberCode Encoded {get;}

        public OffsetSeq OffsetSeq {get;}

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

        public AsmInstructionCode InstructionCode 
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
        public static LocatedInstruction One(MemoryAddress @base, OffsetSeq offseq, Instruction inxs, MemberCode encoded)
            => new LocatedInstruction(@base,offseq,inxs,encoded);

        public static LocatedInstruction[] Many(MemberCode code, Instruction[] src)
        {            
            var @base = code.Address;
            var offseq = OffsetSeq.Zero;
            var count = src.Length;
            var dst = new LocatedInstruction[count];
            
            for(ushort i=0; i<count; i++)
            {
                var inxs = src[i];
                var data = Root.span(code.Encoded.Data);
                var slice = data.Slice(offseq.Offset, inxs.ByteLength).ToArray();
                var recoded = MemberCode.Define(code.OpUri, inxs.IP, slice);  
                dst[i] = One(@base, offseq, inxs, recoded);
                offseq = offseq.AccrueOffset(inxs.ByteLength);
            }
            return dst;
        }

        [MethodImpl(Inline)]
        public LocatedInstruction(MemoryAddress @base, OffsetSeq offseq, Instruction inxs, MemberCode encoded)
        {
            BaseAddress = @base;
            OffsetSeq = offseq;
            Instruction = inxs;
            Encoded = encoded;
        }
    }
}