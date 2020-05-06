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
        
        public SequencedInstruction Instruction {get;}

        [MethodImpl(Inline)]
        public static implicit operator UriCodeInstruction((UriCode code, SequencedInstruction inxs) src)
            => new UriCodeInstruction(src.code, src.inxs);

        [MethodImpl(Inline)]
        public UriCodeInstruction(UriCode code, int seq, Instruction inxs)
        {
            Code = code;
            Instruction = (seq, inxs);
        }

        [MethodImpl(Inline)]
        public UriCodeInstruction(UriCode code, SequencedInstruction inxs)
        {
            Code = code;
            Instruction = inxs;
        }
    }
}