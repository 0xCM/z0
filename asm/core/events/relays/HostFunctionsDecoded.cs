//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IHostFunctionsDecodedRelay : IWorkflowRelay
    {
        HostFunctionsDecoded FunctionsDecoded => HostFunctionsDecoded.Empty;
    }

}