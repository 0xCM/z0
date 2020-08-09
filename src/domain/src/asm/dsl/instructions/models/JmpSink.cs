//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct JmpSink
    {
        public const Mnemonic Id = Mnemonic.Jmp;

        readonly InstructionHandler Receiver;

        [MethodImpl(Inline)]
        internal JmpSink(InstructionHandler dst)
            => Receiver = dst;
        
        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}