//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public interface IAsmHexReader: IAsmService
    {
        /// <summary>
        /// Reads the content of a source file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<AsmOpBits> Read(FilePath src);        
    }
}