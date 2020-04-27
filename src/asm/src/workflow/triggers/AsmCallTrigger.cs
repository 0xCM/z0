//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmCallTrigger : IAsmInstructionTrigger
    {
        public int Id {get;}

        readonly Action<Instruction> Handler;
 
        [MethodImpl(Inline)]
        public static AsmCallTrigger Define(Action<Instruction> handler)
            => new AsmCallTrigger(handler);
        
        [MethodImpl(Inline)]
        AsmCallTrigger(Action<Instruction> handler)
        {
            this.Id = AsmTriggers.NextId();
            this.Handler = handler;
        }

        [MethodImpl(Inline)]
        public bool CanFire(Instruction src)
            => src.Mnemonic == Mnemonic.Call;

        [MethodImpl(Inline)]
        public void FireOnMatch(Instruction src)
        {
            if(CanFire(src))
                Handler(src);
        } 
    }
}