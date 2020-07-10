//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct CallSink : IInstructionHSink<CallSink,Call>
    {
        public const Mnemonic Id = Mnemonic.Call;

        readonly InstructionHandler Receiver;

        [MethodImpl(Inline)]
        public static implicit operator InstructionSink(CallSink src)
            => new InstructionSink(Id, src.Deposit);

        [MethodImpl(Inline)]
        internal CallSink(InstructionHandler dst)
            => Receiver = dst;
        
        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}