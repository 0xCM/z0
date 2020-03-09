//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines serivce contract for catalog-granularity asm emission
    /// </summary>
    public interface IAsmCatalogEmitter : IAsmService, ISink<AsmEmissionTokens<OpUri>>
    {
        /// <summary>
        /// Emits non-immediate captures
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        void EmitPrimary(in OpExtractExchange exchange, AsmEmissionObserver observer);          

        /// <summary>
        /// Emits immediate captures
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        void EmitImm(in OpExtractExchange exchange, AsmEmissionObserver observer);  
    }
}