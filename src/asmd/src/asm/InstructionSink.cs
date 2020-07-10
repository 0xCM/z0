//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct InstructionSink : IInstructionSink
    {
        readonly InstructionHandler Receiver;

        public Mnemonic Kind {get;}

        [MethodImpl(Inline)]
        public InstructionSink(Mnemonic kind, InstructionHandler receiver)
        {
            Kind = kind;
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}
