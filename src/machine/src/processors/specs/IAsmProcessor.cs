//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    
    using Z0.Asm;

    public interface IAsmProcessor<T> : IMachineService, IDataProcessor<T>
    {

    }

    public interface IAsmProcessor<E,T> : IAsmProcessor<T>
        where E : unmanaged, Enum
    {
        IDataBroker<E,T> Broker {get;}

        void Relay(E kind, T data)
            => Broker.Relay(kind,data);
    }

    public interface IAsmProcessor : IAsmProcessor<Mnemonic,LocatedInstruction>
    {
        void OnAnd(LocatedInstruction located)
        {
            
        }

        void OnOr(LocatedInstruction located)
        {
            
        }

        void IDataProcessor.Connect()
        {
            Broker[Mnemonic.And] = DataHandlers.Create<LocatedInstruction>(OnAnd);
            Broker[Mnemonic.Or] = DataHandlers.Create<LocatedInstruction>(OnOr);
        }
    }
}