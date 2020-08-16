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
        void OnJA(LocatedAsmFx src)
        {
            term.announce();
        }

        void OnJAE(LocatedAsmFx src)
        {
            term.announce();            
        }

        void OnJB(LocatedAsmFx src)
        {
            term.announce();            
        }

        void OnJBE(LocatedAsmFx src)
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

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,LocatedAsmFx>
    {
        void OnAnd(LocatedAsmFx located)
        {
            
        }

        void OnOr(LocatedAsmFx located)
        {
            
        }

        void IDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = DataHandlers.Create<LocatedAsmFx>(OnAnd);
            Broker[Mnemonic.Or] = DataHandlers.Create<LocatedAsmFx>(OnOr);
        }
    }
}