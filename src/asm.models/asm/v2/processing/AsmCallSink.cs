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

        readonly AsmFxHandler Receiver;

        [MethodImpl(Inline)]
        public static implicit operator AsmFxSink(AsmCallSink src)
            => new AsmFxSink(Id, src.Deposit);

        [MethodImpl(Inline)]
        public AsmCallSink(AsmFxHandler dst)
            => Receiver = dst;
        
        [MethodImpl(Inline)]
        public void Deposit(in Instruction src)
            => Receiver(src);
    }
}