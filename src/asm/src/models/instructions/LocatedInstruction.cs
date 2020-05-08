//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LocatedInstruction : IAsmInxs<Instruction>
    {
        public UriCode Encoded {get;}

        public OffsetSeq OffsetSeq {get;}

        public Instruction Instruction {get;}

        public MemoryAddress BaseAddress {get;}

        public OpUri OpUri  => Encoded.OpUri;

        public OpIdentity OpId => OpUri.OpId;

        public OpAddress OpAddress => new OpAddress(OpUri, Encoded.Address);

        public int ByteLength => Instruction.ByteLength;

        [MethodImpl(Inline)]
        public static LocatedInstruction One(MemoryAddress @base, OffsetSeq offseq, Instruction inxs, UriCode encoded)
            => new LocatedInstruction(@base,offseq,inxs,encoded);

        public static LocatedInstruction[] Many(UriCode code, Instruction[] src)
        {            
            var @base = code.Address;
            var offseq = OffsetSeq.Zero;
            var count = src.Length;
            var dst = new LocatedInstruction[count];
            
            for(ushort i=0; i<count; i++)
            {
                var inxs = src[i];
                var slice = code.Encoded.Bytes.Slice(offseq.Offset, inxs.ByteLength).ToArray();
                var recoded = UriCode.Define(code.OpUri, inxs.IP, slice);  
                dst[i] = One(@base, offseq, inxs, recoded);
                offseq.AccrueOffset(inxs.ByteLength);
            }
            return dst;
        }


        [MethodImpl(Inline)]
        public LocatedInstruction(MemoryAddress @base, OffsetSeq offseq, Instruction inxs, UriCode encoded)
        {
            BaseAddress = @base;
            OffsetSeq = offseq;
            Instruction = inxs;
            Encoded = encoded;
        }
    }
}