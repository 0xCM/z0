//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    public delegate void InstructionHandler(in Instruction src);

    /// <summary>
    /// Fires when an instruction mnemonic matches a specified mnemonic
    /// </summary>
    public readonly struct AsmMnemonicTrigger : IInstructionTrigger
    {        
        public readonly Mnemonic Mnemonic;

        readonly InstructionHandler Handler;

        [MethodImpl(Inline)]
        public static AsmMnemonicTrigger Define(Mnemonic mnemonic, InstructionHandler handler)
            => new AsmMnemonicTrigger(mnemonic, handler);

        [MethodImpl(Inline)]
        internal AsmMnemonicTrigger(Mnemonic mnemonic, InstructionHandler handler)
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