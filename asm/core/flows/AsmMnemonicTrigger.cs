//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Fires when an instruction mnemonic matches a specified mnemonic
    /// </summary>
    public readonly struct AsmMnemonicTrigger : IAsmInstructionTrigger
    {
        public static IAsmInstructionTrigger Define(Mnemonic mnemonic, Action<Instruction> handler)
            => new AsmMnemonicTrigger(mnemonic, handler);

        AsmMnemonicTrigger(Mnemonic mnemonic, Action<Instruction> handler)
        {
            this.Id = AsmTriggers.NextId();
            this.Mnemonic = mnemonic;
            this.Handler = handler;
        }

        public int Id {get;}
        
        public readonly Mnemonic Mnemonic;

        readonly Action<Instruction> Handler;
                
        [MethodImpl(Inline)]
        public bool CanFire(Instruction src)
            => src.Mnemonic == this.Mnemonic;

        [MethodImpl(Inline)]
        public void FireOnMatch(Instruction src)
        {
            if(CanFire(src))
                Handler(src);
        }
    }
}