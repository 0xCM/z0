//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    public interface IAsmHostCapture : IAsmService
    {
        /// <summary>
        /// Extracts the operations supplied by the host, as determined by the DefinedOps operation
        /// </summary>
        /// <param name="src">The defining host</param>
        CapturedEncodingReport CaptureHostOps(ApiHost src);

        /// <summary>
        /// Calculates the operations defined by the host
        /// </summary>
        /// <param name="src">The defining host</param>
        IEnumerable<EncodedOp> DefinedHostOps(ApiHost src);        
    }
}