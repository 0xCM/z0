//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    
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

    }
}