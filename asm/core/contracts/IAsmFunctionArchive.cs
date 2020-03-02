//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines service contract for persisting asm functions which are derived from .net member functions
    /// </summary>
    public interface IAsmFunctionArchive : IAsmArchive<IAsmFunctionArchive>
    {
        /// <summary>
        /// Saves a group of related functtions to the archive
        /// </summary>
        /// <param name="group">The source group</param>
        Option<AsmCaptureTokenGroup> Save(AsmFunctionGroup group, bool append);
    }    
}