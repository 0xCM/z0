//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public enum AsmHandlerKind : ushort
    {
    }

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,BasedAsmFx>
    {
        void OnAnd(BasedAsmFx located)
        {

        }

        void OnOr(BasedAsmFx located)
        {

        }

        void IWfDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = AB.handler<BasedAsmFx>(OnAnd);
            Broker[Mnemonic.Or] = AB.handler<BasedAsmFx>(OnOr);
        }
    }

    public interface IAsmProcessor<T> : IWfDataProcessor<T>
    {
        void Process(T src);
    }


    public interface IAsmProcessor<E,T> : IAsmProcessor<T>
        where E : unmanaged, Enum
    {
        IWfDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }
}