//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System.Collections.Generic;

    public interface IEncodedHexReader
    {
        /// <summary>
        /// Reads the content of a source file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<IdentifiedCode> Read(FilePath src);        
    }
}