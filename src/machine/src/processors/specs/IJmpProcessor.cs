//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    
    using Z0.Asm.Data;
    using Z0.Asm;

    using static Seed;

    public interface IJmpProcessor : IAsmProcessor<JmpKind,LocatedInstruction>
    {
        void OnJA(LocatedInstruction inxs)
        {
            term.announce();
        }

        void OnJAE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        void OnJB(LocatedInstruction inxs)
        {
            term.announce();            
        }

        void OnJBE(LocatedInstruction inxs)
        {
            term.announce();            
        }

        // void IDataProcessor.Connect()
        // {
        //     Broker[JmpKind.JA] = DataHandlers.Create<LocatedInstruction>(OnJA);
        //     Broker[JmpKind.JAE] = DataHandlers.Create<LocatedInstruction>(OnJAE);
        //     Broker[JmpKind.JB] = DataHandlers.Create<LocatedInstruction>(OnJB);
        //     Broker[JmpKind.JBE] = DataHandlers.Create<LocatedInstruction>(OnJBE);
        // }
    }
}