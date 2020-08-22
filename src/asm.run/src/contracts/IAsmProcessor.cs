//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    public interface IAsmProcessor<T> : IDataProcessor<T>
    {
        void Process(T src);
    }

    public interface IJmpProcessor
    {
        void OnJA(BasedAsmFx src)
        {
            term.announce();
        }

        void OnJAE(BasedAsmFx src)
        {
            term.announce();
        }

        void OnJB(BasedAsmFx src)
        {
            term.announce();
        }

        void OnJBE(BasedAsmFx src)
        {
            term.announce();
        }
    }

    public interface IAsmProcessor<E,T> : IAsmProcessor<T>
        where E : unmanaged, Enum
    {
        IDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,BasedAsmFx>
    {
        void OnAnd(BasedAsmFx located)
        {

        }

        void OnOr(BasedAsmFx located)
        {

        }

        void IDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = WfDataHandlers.create<BasedAsmFx>(OnAnd);
            Broker[Mnemonic.Or] = WfDataHandlers.create<BasedAsmFx>(OnOr);
        }
    }
}