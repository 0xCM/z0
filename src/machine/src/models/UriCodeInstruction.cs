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
    /// Pairs an instruction with the source from whence it came
    /// </summary>
    public readonly struct UriCodeInstruction
    {        
        public UriCode Code {get;}
            
        public SequencedInstruction Sequenced {get;}

        public int SequenceNumber => Sequenced.Sequence;

        public Instruction Instruction => Sequenced.Instruction;

        public MemoryAddress BaseAddress => Code.Address;        

        public OpIdentity OpId => Code.OpId;

        public OpUri OpUri => Code.OpUri;

        public ApiHostUri HostUri => OpUri.HostPath;

        [MethodImpl(Inline)]
        public static implicit operator UriCodeInstruction((UriCode code, SequencedInstruction inxs) src)
            => new UriCodeInstruction(src.code, src.inxs);

        [MethodImpl(Inline)]
        public UriCodeInstruction(UriCode code, int seq, Instruction inxs)
        {
            Code = code;
            Sequenced = (seq, inxs);
        }

        [MethodImpl(Inline)]
        public UriCodeInstruction(UriCode code, SequencedInstruction inxs)
        {
            Code = code;
            Sequenced = inxs;
        }
    }
}