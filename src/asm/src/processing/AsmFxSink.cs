//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct AsmFxSink
    {
        readonly AsmFxHandler Receiver;

        public Mnemonic Kind {get;}

        [MethodImpl(Inline)]
        public AsmFxSink(Mnemonic kind, AsmFxHandler receiver)
        {
            Kind = kind;
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}
