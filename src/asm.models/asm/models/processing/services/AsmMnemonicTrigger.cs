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
    /// Fires when an instruction mnemonic matches a specified mnemonic
    /// </summary>
    public readonly struct AsmMnemonicTrigger : IAsmFxTrigger
    {        
        public readonly Mnemonic Mnemonic;

        readonly AsmFxHandler Handler;

        [MethodImpl(Inline)]
        public AsmMnemonicTrigger(Mnemonic mnemonic, AsmFxHandler handler)
        {
            Mnemonic = mnemonic;
            Handler = handler;
        }
                
        [MethodImpl(Inline)]
        public bool CanFire(in Instruction src)
            => Mnemonic == src.Mnemonic;

        [MethodImpl(Inline)]
        public void FireOnMatch(in Instruction src)
        {
            if(CanFire(src))
                Handler(src);
        }
    }
}