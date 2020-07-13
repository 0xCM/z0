//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static Konst;

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