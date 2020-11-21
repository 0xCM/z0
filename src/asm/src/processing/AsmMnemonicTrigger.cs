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
        public bool TestCondition(in Instruction src)
            => Mnemonic == src.Mnemonic;

        [MethodImpl(Inline)]
        public void TryFire(in Instruction src)
        {
            if(TestCondition(src))
                Handler(src);
        }
    }
}