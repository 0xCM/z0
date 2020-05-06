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
    /// Pairs an instruction with a sequence number
    /// </summary>
    public readonly struct SequencedInstruction
    {
        public int Sequence {get;}

        public Instruction  Instruction {get;}

        [MethodImpl(Inline)]
        public static implicit operator SequencedInstruction((int seq, Instruction inxs) src)
            => new SequencedInstruction(src.seq, src.inxs);

        [MethodImpl(Inline)]
        public SequencedInstruction(int seq, Instruction inxs)
        {
            Sequence = seq;
            Instruction = inxs;
        }
    }
}