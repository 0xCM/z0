//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Pairs an instruction with useful context facets
    /// </summary>
    public readonly struct OpInstruction : IAsmInxs<Instruction>
    {        
        /// <summary>
        /// The uri of the defining operation
        /// </summary>
        public OpUri OpUri  {get;}

        /// <summary>
        /// The instruction content
        /// </summary>
        public Instruction Instruction {get;}

        /// <summary>
        /// A sequence number that orders the instructions relative to other instructions for the operation
        /// </summary>
        public int Seq {get;}
                  
        /// <summary>
        /// The instruction base address
        /// </summary>
        public MemoryAddress BaseAddress {get;}

        public OpIdentity OpId => OpUri.OpId;
        
        public ApiHostUri Host  => OpUri.Host;

        public PartId Part => OpUri.Part;        

        [MethodImpl(Inline)]
        public static OpInstruction Define(MemoryAddress @base, OpUri uri, int seq, Instruction inxs)
            => new OpInstruction(@base, uri,seq,inxs);

        [MethodImpl(Inline)]
        public OpInstruction(MemoryAddress @base, OpUri uri, int seq, Instruction inxs)
        {
            Seq = seq;
            Instruction = inxs;
            BaseAddress = @base;
            OpUri = uri;
        }
    }
}