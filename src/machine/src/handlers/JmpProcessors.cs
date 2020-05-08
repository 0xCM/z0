//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IDataProcessor
    {
        
    }
    
    
    public interface IDataProcessor<T> : IDataProcessor
    {
        
    }

    public struct JmpProcessors : IDataProcessor<LocatedCode>
    {
        IDataBroker<JmpKind,LocatedCode> Broker;

        public static IDataProcessor<LocatedCode> Create(IMachineContext context)
        {
            var broker = DataBroker64<JmpKind,LocatedCode>.Alloc();
            return new JmpProcessors(broker);            
        }

        JmpProcessors(DataBroker64<JmpKind,LocatedCode> broker) 
        {
            Broker = broker;
            broker[JmpKind.JA] = DataHandlers.Create<LocatedCode>(OnJA);
            broker[JmpKind.JAE] = DataHandlers.Create<LocatedCode>(OnJAE);
            broker[JmpKind.JB] = DataHandlers.Create<LocatedCode>(OnJB);
            broker[JmpKind.JBE] = DataHandlers.Create<LocatedCode>(OnJBE);
        }

        void OnJA(LocatedCode inxs)
        {
            term.announce();
        }

        void OnJAE(LocatedCode inxs)
        {
            term.announce();            
        }

        void OnJB(LocatedCode inxs)
        {
            term.announce();            
        }

        void OnJBE(LocatedCode inxs)
        {
            term.announce();            
        }
    }

}