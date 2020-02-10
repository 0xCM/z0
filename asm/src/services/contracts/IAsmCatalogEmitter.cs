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
    public interface IAsmCatalogEmitter : IAsmService
    {
        /// <summary>
        /// Emits non-immediate captures
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="receipt">The emission evidence receiver</param>
        void EmitPrimary(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt);          

        /// <summary>
        /// Emits immediate captures
        /// </summary>
        /// <param name="exchange">The selected exchange</param>
        /// <param name="receipt">The emission evidence receiver</param>
        void EmitImm(in CaptureExchange exchange, Action<CaptureTokenGroup> receipt);  
    }
}