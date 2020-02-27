//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public interface IAsmCodeIndex
    {
        /// <summary>
        /// Searches for an index entry
        /// </summary>
        /// <param name="id">The targeted operation identifier</param>
        Option<AsmCode> Lookup(OpIdentity id);
        
        /// <summary>
        /// Enumerates all index entries
        /// </summary>
        IEnumerable<AsmCode> Entries {get;}
    }
}