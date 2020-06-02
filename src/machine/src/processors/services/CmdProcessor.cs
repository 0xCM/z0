//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;

    using static Seed;
    using static Memories;

    public readonly struct CmdProcessor
    {
        public IMachineContext Context {get;}


        public IDataBroker<AsmCommandKind,AsmCommand> Broker {get;}
    }
}
