//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AsmCallSink
    {
        public const Mnemonic Id = Mnemonic.Call;

        readonly InstructionHandler Receiver;

        [MethodImpl(Inline)]
        public static implicit operator InstructionSink(AsmCallSink src)
            => new InstructionSink(Id, src.Deposit);

        [MethodImpl(Inline)]
        public AsmCallSink(InstructionHandler dst)
            => Receiver = dst;
        
        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}