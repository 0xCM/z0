//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Defines asm archival service operations
    /// </summary>
    public interface IAsmFunctionArchive : IAsmArchive<IAsmFunctionArchive>
    {
        /// <summary>
        /// Saves a function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmEmissionToken Save(AsmFunction src);

        /// <summary>
        /// Saves a stream of functions to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        IEnumerable<AsmEmissionToken> Save(IEnumerable<AsmFunction> src);

        /// <summary>
        /// Saves a group of related functtions to the archive
        /// </summary>
        /// <param name="group">The source group</param>
        IEnumerable<AsmEmissionToken> Save(AsmFunctionGroup group, bool append);

    }    
}