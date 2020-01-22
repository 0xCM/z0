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
    /// Defines asm archival service operations
    /// </summary>
    public interface IAsmFunctionArchive : IAsmArchive
    {
        /// <summary>
        /// Saves a single function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmDescriptor Save(AsmFunction src);

        /// <summary>
        /// Saves a group of functions to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        IEnumerable<AsmDescriptor> Save(IEnumerable<AsmFunction> src);       
        
        /// <summary>
        /// Purges all files from the archive
        /// </summary>
        void Clear();        
    }
}