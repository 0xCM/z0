//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines service contract to support reading text-formatted encoded x86 asm data
    /// </summary>
    public interface IAsmCodeReader : IAsmService
    {
        /// <summary>
        /// Reads the content of a source file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<AsmCode> Read(FilePath src);
    }
}
