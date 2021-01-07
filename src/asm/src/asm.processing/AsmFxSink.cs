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

        public IceMnemonic Kind {get;}

        [MethodImpl(Inline)]
        public AsmFxSink(IceMnemonic kind, AsmFxHandler receiver)
        {
            Kind = kind;
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Deposit(in IceInstruction src)
            => Receiver(src);
    }
}
