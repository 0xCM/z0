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
    public interface IAsmFunctionArchive : IAsmArchive
    {
        /// <summary>
        /// Saves a function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmFileDescriptor Save(AsmFunction src);

        /// <summary>
        /// Purges all files from the archive
        /// </summary>
        IAsmFunctionArchive Clear();        
    }
}