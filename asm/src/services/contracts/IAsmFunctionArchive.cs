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
        /// Saves a function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmDescriptor Save(AsmFunction src);

        /// <summary>
        /// Saves a function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmDescriptor Save(AsmSpecs.AsmFunction src);

        /// <summary>
        /// Purges all files from the archive
        /// </summary>
        IAsmFunctionArchive Clear();        
    }
}