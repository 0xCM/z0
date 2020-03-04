//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAsmStreamWriter : IAsmServiceAllocation
    {
        /// <summary>
        /// The writer output path
        /// </summary>
        FilePath TargetPath {get;}        
    }
}