//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Defines base interface for asm archive services
    /// </summary>
    public interface IAsmArchive
    {
        /// <summary>
        /// The top-level organization segment
        /// </summary>
        string Catalog {get;}

        /// <summary>
        /// The sub-level organization segment
        /// </summary>
        string Subject {get;}
    }
}