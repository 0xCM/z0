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
    
    /// <summary>
    /// Specifies a service operation that calculates base addresses for host-defined operations
    /// </summary>
    public interface IAsmOpAddressProvider : IAsmService
    {
        /// <summary>
        /// Calculates the operations defined by the host
        /// </summary>
        /// <param name="src">The defining host</param>
        IEnumerable<OpAddress> Addresses(ApiHost src);                
    }

    public interface IAsmBaseAddressProvider : IAsmService, IAnyFormattableSeq<MemoryAddress>
    {

    }
}