//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.AsmSpecs;

    using static zfunc;

    public enum AsmArchiveFileKind
    {
        None = 0,

        Hex = 1,

        Asm = 2,

        Cil = 3,
        
    }

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
        /// Saves a group of related functtions to the archive
        /// </summary>
        /// <param name="group">The source group</param>
        Option<AsmEmissionGroup> Save(AsmFunctionGroup group, bool append);

    }    
}