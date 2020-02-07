//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IAsmCatalogEmitter : IAsmService
    {
        void EmitPrimary(in CaptureExchange exchange, Action<AsmEmissionGroup> receipt);          

        void EmitImm(in CaptureExchange exchange, Action<AsmEmissionGroup> receipt);  
    }
}