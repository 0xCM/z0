//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines what is effectively an asm emitter at (! .net) assembly-level granularity
    /// </summary>
    public interface IAsmAssemblyArchiver : IAsmService, IExecutable
    {
        /// <summary>
        /// The identifer of the .net assembly for which native asm should be captured and persisted to an archive
        /// </summary>
        /// <param name="id">The .net assembly identifier</param>
        void Archive(AssemblyId id);        
    }
}