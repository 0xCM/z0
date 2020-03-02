//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    /// <summary>
    /// Characterizes a service that extracts host-defined operations
    /// </summary>
    public interface IAsmHostExtractor : IAsmOpAddressProvider
    {
        /// <summary>
        /// Extracts the operations supplied by the host, as determined by the DefinedOps operation
        /// </summary>
        /// <param name="src">The defining host</param>
        AsmOpExtractReport ExtractOps(ApiHost src);
    }
}