//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct CmdProcessor
    {
        public IMachineContext Context {get;}

        //public IDataBroker<AsmCommandGroup,AsmCommand> Broker {get;}
    }
}
