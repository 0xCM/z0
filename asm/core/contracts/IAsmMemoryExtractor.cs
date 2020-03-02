//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a service that extracts encoded data from a given base address
    /// </summary>
    public interface IAsmMemoryExtractor : IAsmService
    {
        Option<EncodedData> Extract(MemoryAddress src);        
    }    
}